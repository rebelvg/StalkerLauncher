using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading;
using Newtonsoft.Json;
using Ookii.Dialogs.Wpf;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.FileIO;

namespace StalkerLauncher
{
    public partial class Form1 : Form
    {
        string launcherVersion = "0.12";

        StalkerLauncherXmlSettings LauncherSettings;

        [DllImport("kernel32.dll")]
        static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, SymbolicLink dwFlags);

        enum SymbolicLink
        {
            File = 0,
            Directory = 1
        }

        public Form1()
        {
            InitializeComponent();

            try
            {
                if (Process.GetProcessesByName("StalkerLauncher").Length > 1)
                {
                    MessageBox.Show("Launcher is already running.");
                    System.Environment.Exit(1);
                }

                string iniDirectoryPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\StalkerLauncher";

                xmlPath_textBox.Text = iniDirectoryPath + "\\StalkerLauncher.xml";

                if (!Directory.Exists(iniDirectoryPath))
                {
                    try
                    {
                        Directory.CreateDirectory(iniDirectoryPath);
                    }
                    catch
                    {
                        MessageBox.Show("Couldn't create a folder at " + iniDirectoryPath);
                    }
                }

                if (File.Exists(xmlPath_textBox.Text))
                {
                    ReadXmlFile();
                }
                else
                {
                    try
                    {
                        LauncherSettings = new StalkerLauncherXmlSettings();

                        System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(StalkerLauncherXmlSettings));

                        System.IO.FileStream writer = System.IO.File.Create(xmlPath_textBox.Text);
                        serializer.Serialize(writer, LauncherSettings);
                        writer.Close();

                        ReadXmlFile();
                    }
                    catch
                    {
                        MessageBox.Show("Saving xml settings failed.");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Launcher crashed while initializing. Try running it as administrator.\n\n" + e);
                System.Environment.Exit(1);
            }

            label1.Text = "Version " + launcherVersion;
        }

        public class StalkerLauncherXmlSettings
        {
            public string pathToStalker_textBox = Directory.GetCurrentDirectory() + "\\stalker.exe";
            public List<string> modsList_listView;
            public List<string> checkedModsList_listView;
            public string startLine_textBox;
        }

        public void ReadXmlFile()
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(StalkerLauncherXmlSettings));

            StreamReader reader = new StreamReader(xmlPath_textBox.Text);

            try
            {
                LauncherSettings = (StalkerLauncherXmlSettings)serializer.Deserialize(reader);
                reader.Close();

                pathToStalker_textBox.Text = LauncherSettings.pathToStalker_textBox;

                foreach (string X in LauncherSettings.modsList_listView)
                {
                    if (!modsList_listView.Items.Cast<ListViewItem>().Select(x => x.Text).Contains(X))
                    {
                        modsList_listView.Items.Add(X);
                    }
                }

                foreach (ListViewItem X in modsList_listView.Items)
                {
                    if (LauncherSettings.checkedModsList_listView.Contains(X.Text))
                    {
                        X.Checked = true;
                    }
                }

                startLine_textBox.Text = LauncherSettings.startLine_textBox;
            }
            catch
            {
                reader.Close();

                DialogResult dialogResult = MessageBox.Show("Create a new one?", "Xml file is corrupted.", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    SaveXmlFile();
                }
                if (dialogResult == DialogResult.No)
                {
                    System.Environment.Exit(1);
                }
            }
        }

        public void SaveXmlFile()
        {
            try
            {
                LauncherSettings = new StalkerLauncherXmlSettings();

                LauncherSettings.pathToStalker_textBox = pathToStalker_textBox.Text;
                LauncherSettings.modsList_listView = modsList_listView.Items.Cast<ListViewItem>().Select(x => x.Text).ToList();
                LauncherSettings.checkedModsList_listView = modsList_listView.CheckedItems.Cast<ListViewItem>().Select(x => x.Text).ToList();
                LauncherSettings.startLine_textBox = startLine_textBox.Text;

                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(StalkerLauncherXmlSettings));

                System.IO.FileStream writer = System.IO.File.Create(xmlPath_textBox.Text);
                serializer.Serialize(writer, LauncherSettings);
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Saving xml settings failed.");
            }
        }

        public string ReturnStalkerFolder()
        {
            return Path.GetDirectoryName(pathToStalker_textBox.Text);
        }

        public string ReturnStalkerGamedataFolder()
        {
            return Path.GetDirectoryName(pathToStalker_textBox.Text) + "\\gamedata";
        }

        private void changePathToArma3Client_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectFile = new OpenFileDialog();

            selectFile.Title = "Select stalker exe";
            selectFile.Filter = "Executable File (.exe) | *.exe";
            selectFile.RestoreDirectory = true;

            if (selectFile.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(Path.GetDirectoryName(selectFile.FileName) + "\\gamedata"))
                    pathToStalker_textBox.Text = selectFile.FileName;
                else
                    MessageBox.Show("This folder should have gamedata folder in it.");
            }

            RefreshPresetModsList();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveXmlFile();
        }

        private void saveSettingsClient_button_Click(object sender, EventArgs e)
        {
            SaveXmlFile();
        }

        private void addMod_button_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog chosenFolder = new VistaFolderBrowserDialog();
            chosenFolder.Description = "Select custom mod folder.";
            chosenFolder.UseDescriptionForTitle = true;

            if (chosenFolder.ShowDialog().Value)
            {
                if (Directory.Exists(chosenFolder.SelectedPath + "\\gamedata"))
                {
                    modsList_listView.Items.Add(chosenFolder.SelectedPath);

                    var item = modsList_listView.FindItemWithText(chosenFolder.SelectedPath);

                    if (item != null)
                        item.Checked = true;
                }
                else
                {
                    MessageBox.Show("This folder should have gamedata folder in it.");
                }
            }

            RefreshPresetModsList();
        }

        private void upMod_button_Click(object sender, EventArgs e)
        {
            if (modsList_listView.SelectedItems.Count != 1)
                return;

            var currentIndex = modsList_listView.SelectedItems[0].Index;
            var item = modsList_listView.Items[currentIndex];

            if (currentIndex > 0)
            {
                modsList_listView.Items.RemoveAt(currentIndex);
                modsList_listView.Items.Insert(currentIndex - 1, item);
            }
        }

        private void lowerMod_button_Click(object sender, EventArgs e)
        {
            if (modsList_listView.SelectedItems.Count != 1)
                return;

            var currentIndex = modsList_listView.SelectedItems[0].Index;
            var item = modsList_listView.Items[currentIndex];

            if (currentIndex < modsList_listView.Items.Count - 1)
            {
                modsList_listView.Items.RemoveAt(currentIndex);
                modsList_listView.Items.Insert(currentIndex + 1, item);
            }
        }

        private void removeMod_button_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in modsList_listView.Items)
            {
                if (!item.Checked)
                    item.Remove();
            }
        }

        public bool ClearGamedata()
        {
            if (!Directory.Exists(ReturnStalkerGamedataFolder()))
                return false;

            List<string> folderFiles = Directory.GetFiles(ReturnStalkerGamedataFolder(), "*", System.IO.SearchOption.TopDirectoryOnly).ToList();

            DialogResult dialogResultFiles = MessageBox.Show("Move " + folderFiles.Count + " gamedata files from " + ReturnStalkerGamedataFolder() + " to recycle bin?", "WARNING", MessageBoxButtons.YesNo);

            List<string> folderFolders = Directory.GetDirectories(ReturnStalkerGamedataFolder(), "*", System.IO.SearchOption.TopDirectoryOnly).ToList();

            if (dialogResultFiles == DialogResult.Yes)
            {
                foreach (string X in folderFiles)
                {
                    FileSystem.DeleteFile(X, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }

                DialogResult dialogResultFolders = MessageBox.Show("Move " + folderFolders.Count + " gamedata folders from " + ReturnStalkerGamedataFolder() + " to recycle bin?", "WARNING", MessageBoxButtons.YesNo);

                if (dialogResultFolders == DialogResult.Yes)
                {
                    foreach (string X in folderFolders)
                    {
                        FileSystem.DeleteDirectory(X, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                    }
                }
                else return false;

                MessageBox.Show("Gamedata deleted.");
            }
            else return false;

            return true;
        }

        public bool BuildGamedata()
        {
            RefreshPresetModsList();

            if (!ClearGamedata())
                return false;

            Dictionary<string, string> gamedataFiles = new Dictionary<string, string>();

            foreach (ListViewItem A in modsList_listView.CheckedItems)
            {
                string gamedataPath = A.Text + "\\gamedata";

                if (!Directory.Exists(gamedataPath))
                {
                    MessageBox.Show(gamedataPath + " folder doesn't exist.");
                    return false;
                }

                List<string> folderFiles = Directory.GetFiles(gamedataPath, "*", System.IO.SearchOption.AllDirectories).ToList();

                foreach (string B in folderFiles)
                {
                    gamedataFiles[B.Replace(gamedataPath, "")] = B;
                }
            }

            Thread NewThread = new Thread(() => CopyFilesNewThread(gamedataFiles));
            NewThread.Start();            

            return true;
        }

        private void launch_button_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathToStalker_textBox.Text))
            {
                Process myProcess = new Process();

                myProcess.StartInfo.FileName = pathToStalker_textBox.Text;
                myProcess.StartInfo.Arguments = startLine_textBox.Text;
                myProcess.Start();
            }
            else
            {
                MessageBox.Show(pathToStalker_textBox.Text + " not found.");
            }
        }

        private void CheckPath(string filePath)
        {
            List<string> pathList = Path.GetDirectoryName(filePath).Split(Path.DirectorySeparatorChar).ToList();

            string fullpath = pathList[0];

            pathList.RemoveAt(0);

            foreach (string X in pathList)
            {
                fullpath += "\\" + X;

                if (!Directory.Exists(fullpath))
                    Directory.CreateDirectory(fullpath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearGamedata();
        }

        private void buildGamedata_button_Click(object sender, EventArgs e)
        {
            BuildGamedata();
        }

        public void SetColorOnText(TextBox box)
        {
            if (Directory.Exists(box.Text) || File.Exists(box.Text))
                box.BackColor = Color.Green;
            else
                box.BackColor = Color.Red;
        }

        public void SetColorOnCustomList(ListView list, ColumnHeader header)
        {
            foreach (ListViewItem X in list.Items)
            {
                if (Directory.Exists(X.Text + "\\gamedata"))
                {
                    if (X.BackColor != Color.Green)
                        X.BackColor = Color.Green;
                }
                else
                {
                    if (X.BackColor != Color.Red)
                        X.BackColor = Color.Red;
                }
            }

            header.Width = -2;
        }

        public void RefreshPresetModsList()
        {
            SetColorOnText(pathToStalker_textBox);
            SetColorOnCustomList(modsList_listView, columnHeader7);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            RefreshPresetModsList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/rebelvg/StalkerLauncher");
        }

        public void LockInterface(string text)
        {
            this.Invoke(new Action(() =>
            {
                this.Enabled = false;
                ChangeHeader(text);
            }));
        }

        public void UnlockInterface()
        {
            this.Invoke(new Action(() =>
            {
                this.Enabled = true;
                ChangeHeader("Stalker Launcher");
            }));
        }

        public void ChangeHeader(string text)
        {
            this.Invoke(new Action(() =>
            {
                this.Text = text;
            }));
        }

        public void CopyFilesNewThread(Dictionary<string, string> gamedataFiles)
        {
            LockInterface("Copying...");

            this.Invoke(new Action(() =>
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = gamedataFiles.Count();
                progressBar1.Value = 0;
                progressBar1.Step = 1;
            }));

            foreach (KeyValuePair<string, string> entry in gamedataFiles)
            {
                CheckPath(ReturnStalkerGamedataFolder() + entry.Key);

                ChangeHeader("Copying... (" + progressBar1.Value + "/" + progressBar1.Maximum + ")");

                File.Copy(entry.Value, ReturnStalkerGamedataFolder() + entry.Key, true);

                this.Invoke(new Action(() => progressBar1.PerformStep()));

                ChangeHeader("Copying... (" + progressBar1.Value + "/" + progressBar1.Maximum + ")");                
            }

            MessageBox.Show("Gamedata built. " + gamedataFiles.Count + " files were copied.");

            UnlockInterface();
        }
    }
}

namespace StalkerLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.presetName_textBox = new System.Windows.Forms.TextBox();
            this.removePreset_button = new System.Windows.Forms.Button();
            this.addPreset_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addModsFolder_button = new System.Windows.Forms.Button();
            this.clearAndBuildGamedata_button = new System.Windows.Forms.Button();
            this.selectAll_button = new System.Windows.Forms.Button();
            this.deselectAll_button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buildGamedata_button = new System.Windows.Forms.Button();
            this.removeMod_button = new System.Windows.Forms.Button();
            this.lowerMod_button = new System.Windows.Forms.Button();
            this.upMod_button = new System.Windows.Forms.Button();
            this.addMod_button = new System.Windows.Forms.Button();
            this.saveSettingsClient_button = new System.Windows.Forms.Button();
            this.changePathToArma3Client_button = new System.Windows.Forms.Button();
            this.launch_button = new System.Windows.Forms.Button();
            this.startLine_textBox = new System.Windows.Forms.TextBox();
            this.modsList_listView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pathToStalker_textBox = new System.Windows.Forms.TextBox();
            this.xmlPath_textBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stalkerGamedata_listView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modsGamedata_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1047, 689);
            this.tabControl1.TabIndex = 48;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.presetName_textBox);
            this.tabPage1.Controls.Add(this.removePreset_button);
            this.tabPage1.Controls.Add(this.addPreset_button);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.addModsFolder_button);
            this.tabPage1.Controls.Add(this.clearAndBuildGamedata_button);
            this.tabPage1.Controls.Add(this.selectAll_button);
            this.tabPage1.Controls.Add(this.deselectAll_button);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buildGamedata_button);
            this.tabPage1.Controls.Add(this.removeMod_button);
            this.tabPage1.Controls.Add(this.lowerMod_button);
            this.tabPage1.Controls.Add(this.upMod_button);
            this.tabPage1.Controls.Add(this.addMod_button);
            this.tabPage1.Controls.Add(this.saveSettingsClient_button);
            this.tabPage1.Controls.Add(this.changePathToArma3Client_button);
            this.tabPage1.Controls.Add(this.launch_button);
            this.tabPage1.Controls.Add(this.startLine_textBox);
            this.tabPage1.Controls.Add(this.modsList_listView);
            this.tabPage1.Controls.Add(this.pathToStalker_textBox);
            this.tabPage1.Controls.Add(this.xmlPath_textBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1039, 660);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // presetName_textBox
            // 
            this.presetName_textBox.Location = new System.Drawing.Point(268, 183);
            this.presetName_textBox.Name = "presetName_textBox";
            this.presetName_textBox.Size = new System.Drawing.Size(178, 20);
            this.presetName_textBox.TabIndex = 75;
            // 
            // removePreset_button
            // 
            this.removePreset_button.Location = new System.Drawing.Point(358, 153);
            this.removePreset_button.Name = "removePreset_button";
            this.removePreset_button.Size = new System.Drawing.Size(88, 24);
            this.removePreset_button.TabIndex = 74;
            this.removePreset_button.Text = "Remove Preset";
            this.removePreset_button.UseVisualStyleBackColor = true;
            this.removePreset_button.Click += new System.EventHandler(this.removePreset_button_Click);
            // 
            // addPreset_button
            // 
            this.addPreset_button.Location = new System.Drawing.Point(372, 209);
            this.addPreset_button.Name = "addPreset_button";
            this.addPreset_button.Size = new System.Drawing.Size(74, 24);
            this.addPreset_button.TabIndex = 73;
            this.addPreset_button.Text = "Add Preset";
            this.addPreset_button.UseVisualStyleBackColor = true;
            this.addPreset_button.Click += new System.EventHandler(this.addPreset_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 72;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
            // 
            // addModsFolder_button
            // 
            this.addModsFolder_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addModsFolder_button.Location = new System.Drawing.Point(482, 450);
            this.addModsFolder_button.Name = "addModsFolder_button";
            this.addModsFolder_button.Size = new System.Drawing.Size(105, 36);
            this.addModsFolder_button.TabIndex = 71;
            this.addModsFolder_button.Text = "Add Mods Folder";
            this.addModsFolder_button.UseVisualStyleBackColor = true;
            this.addModsFolder_button.Click += new System.EventHandler(this.addModsFolder_button_Click);
            // 
            // clearAndBuildGamedata_button
            // 
            this.clearAndBuildGamedata_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearAndBuildGamedata_button.Location = new System.Drawing.Point(796, 555);
            this.clearAndBuildGamedata_button.Name = "clearAndBuildGamedata_button";
            this.clearAndBuildGamedata_button.Size = new System.Drawing.Size(93, 38);
            this.clearAndBuildGamedata_button.TabIndex = 70;
            this.clearAndBuildGamedata_button.Text = "Clear and Build Gamedata";
            this.clearAndBuildGamedata_button.UseVisualStyleBackColor = true;
            this.clearAndBuildGamedata_button.Click += new System.EventHandler(this.clearAndBuildGamedata_button_Click);
            // 
            // selectAll_button
            // 
            this.selectAll_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectAll_button.Location = new System.Drawing.Point(370, 392);
            this.selectAll_button.Name = "selectAll_button";
            this.selectAll_button.Size = new System.Drawing.Size(76, 23);
            this.selectAll_button.TabIndex = 69;
            this.selectAll_button.Text = "Select All";
            this.selectAll_button.UseVisualStyleBackColor = true;
            this.selectAll_button.Click += new System.EventHandler(this.selectAll_button_Click);
            // 
            // deselectAll_button
            // 
            this.deselectAll_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deselectAll_button.Location = new System.Drawing.Point(370, 421);
            this.deselectAll_button.Name = "deselectAll_button";
            this.deselectAll_button.Size = new System.Drawing.Size(76, 23);
            this.deselectAll_button.TabIndex = 68;
            this.deselectAll_button.Text = "Deselect All";
            this.deselectAll_button.UseVisualStyleBackColor = true;
            this.deselectAll_button.Click += new System.EventHandler(this.deselectAll_button_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(452, 599);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(338, 23);
            this.progressBar1.TabIndex = 67;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(8, 620);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 66;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Startup Line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Stalker (.exe)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Xml Path";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 641);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Version 0.999";
            // 
            // buildGamedata_button
            // 
            this.buildGamedata_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buildGamedata_button.Location = new System.Drawing.Point(796, 599);
            this.buildGamedata_button.Name = "buildGamedata_button";
            this.buildGamedata_button.Size = new System.Drawing.Size(93, 23);
            this.buildGamedata_button.TabIndex = 61;
            this.buildGamedata_button.Text = "Build Gamedata";
            this.buildGamedata_button.UseVisualStyleBackColor = true;
            this.buildGamedata_button.Click += new System.EventHandler(this.buildGamedata_button_Click);
            // 
            // removeMod_button
            // 
            this.removeMod_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeMod_button.Location = new System.Drawing.Point(926, 450);
            this.removeMod_button.Name = "removeMod_button";
            this.removeMod_button.Size = new System.Drawing.Size(105, 36);
            this.removeMod_button.TabIndex = 58;
            this.removeMod_button.Text = "Remove Unchecked";
            this.removeMod_button.UseVisualStyleBackColor = true;
            this.removeMod_button.Click += new System.EventHandler(this.removeMod_button_Click);
            // 
            // lowerMod_button
            // 
            this.lowerMod_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lowerMod_button.Location = new System.Drawing.Point(815, 450);
            this.lowerMod_button.Name = "lowerMod_button";
            this.lowerMod_button.Size = new System.Drawing.Size(105, 36);
            this.lowerMod_button.TabIndex = 57;
            this.lowerMod_button.Text = "Lower Selected";
            this.lowerMod_button.UseVisualStyleBackColor = true;
            this.lowerMod_button.Click += new System.EventHandler(this.lowerMod_button_Click);
            // 
            // upMod_button
            // 
            this.upMod_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upMod_button.Location = new System.Drawing.Point(704, 450);
            this.upMod_button.Name = "upMod_button";
            this.upMod_button.Size = new System.Drawing.Size(105, 36);
            this.upMod_button.TabIndex = 56;
            this.upMod_button.Text = "Up Selected";
            this.upMod_button.UseVisualStyleBackColor = true;
            this.upMod_button.Click += new System.EventHandler(this.upMod_button_Click);
            // 
            // addMod_button
            // 
            this.addMod_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addMod_button.Location = new System.Drawing.Point(593, 450);
            this.addMod_button.Name = "addMod_button";
            this.addMod_button.Size = new System.Drawing.Size(105, 36);
            this.addMod_button.TabIndex = 55;
            this.addMod_button.Text = "Add Mod";
            this.addMod_button.UseVisualStyleBackColor = true;
            this.addMod_button.Click += new System.EventHandler(this.addMod_button_Click);
            // 
            // saveSettingsClient_button
            // 
            this.saveSettingsClient_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSettingsClient_button.Location = new System.Drawing.Point(796, 631);
            this.saveSettingsClient_button.Name = "saveSettingsClient_button";
            this.saveSettingsClient_button.Size = new System.Drawing.Size(93, 23);
            this.saveSettingsClient_button.TabIndex = 54;
            this.saveSettingsClient_button.Text = "Save Settings";
            this.saveSettingsClient_button.UseVisualStyleBackColor = true;
            this.saveSettingsClient_button.Click += new System.EventHandler(this.saveSettingsClient_button_Click);
            // 
            // changePathToArma3Client_button
            // 
            this.changePathToArma3Client_button.Location = new System.Drawing.Point(420, 61);
            this.changePathToArma3Client_button.Name = "changePathToArma3Client_button";
            this.changePathToArma3Client_button.Size = new System.Drawing.Size(26, 20);
            this.changePathToArma3Client_button.TabIndex = 53;
            this.changePathToArma3Client_button.Text = "...";
            this.changePathToArma3Client_button.UseVisualStyleBackColor = true;
            this.changePathToArma3Client_button.Click += new System.EventHandler(this.changePathToArma3Client_button_Click);
            // 
            // launch_button
            // 
            this.launch_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.launch_button.Location = new System.Drawing.Point(895, 599);
            this.launch_button.Name = "launch_button";
            this.launch_button.Size = new System.Drawing.Size(136, 55);
            this.launch_button.TabIndex = 52;
            this.launch_button.Text = "LAUNCH";
            this.launch_button.UseVisualStyleBackColor = true;
            this.launch_button.Click += new System.EventHandler(this.launch_button_Click);
            // 
            // startLine_textBox
            // 
            this.startLine_textBox.Location = new System.Drawing.Point(6, 100);
            this.startLine_textBox.Name = "startLine_textBox";
            this.startLine_textBox.Size = new System.Drawing.Size(440, 20);
            this.startLine_textBox.TabIndex = 51;
            // 
            // modsList_listView
            // 
            this.modsList_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modsList_listView.CheckBoxes = true;
            this.modsList_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.modsList_listView.FullRowSelect = true;
            this.modsList_listView.GridLines = true;
            this.modsList_listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.modsList_listView.HideSelection = false;
            this.modsList_listView.Location = new System.Drawing.Point(452, 6);
            this.modsList_listView.MultiSelect = false;
            this.modsList_listView.Name = "modsList_listView";
            this.modsList_listView.Size = new System.Drawing.Size(579, 438);
            this.modsList_listView.TabIndex = 50;
            this.modsList_listView.UseCompatibleStateImageBehavior = false;
            this.modsList_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mods";
            this.columnHeader7.Width = 549;
            // 
            // pathToStalker_textBox
            // 
            this.pathToStalker_textBox.Location = new System.Drawing.Point(6, 61);
            this.pathToStalker_textBox.Name = "pathToStalker_textBox";
            this.pathToStalker_textBox.ReadOnly = true;
            this.pathToStalker_textBox.Size = new System.Drawing.Size(408, 20);
            this.pathToStalker_textBox.TabIndex = 49;
            // 
            // xmlPath_textBox
            // 
            this.xmlPath_textBox.Location = new System.Drawing.Point(6, 22);
            this.xmlPath_textBox.Name = "xmlPath_textBox";
            this.xmlPath_textBox.ReadOnly = true;
            this.xmlPath_textBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xmlPath_textBox.Size = new System.Drawing.Size(440, 20);
            this.xmlPath_textBox.TabIndex = 48;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.stalkerGamedata_listView);
            this.tabPage2.Controls.Add(this.modsGamedata_listView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1039, 660);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Files";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // stalkerGamedata_listView
            // 
            this.stalkerGamedata_listView.CheckBoxes = true;
            this.stalkerGamedata_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.stalkerGamedata_listView.FullRowSelect = true;
            this.stalkerGamedata_listView.GridLines = true;
            this.stalkerGamedata_listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.stalkerGamedata_listView.Location = new System.Drawing.Point(6, 6);
            this.stalkerGamedata_listView.Name = "stalkerGamedata_listView";
            this.stalkerGamedata_listView.Size = new System.Drawing.Size(502, 646);
            this.stalkerGamedata_listView.TabIndex = 52;
            this.stalkerGamedata_listView.UseCompatibleStateImageBehavior = false;
            this.stalkerGamedata_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stalker Gamedata";
            this.columnHeader2.Width = 478;
            // 
            // modsGamedata_listView
            // 
            this.modsGamedata_listView.CheckBoxes = true;
            this.modsGamedata_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.modsGamedata_listView.FullRowSelect = true;
            this.modsGamedata_listView.GridLines = true;
            this.modsGamedata_listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.modsGamedata_listView.Location = new System.Drawing.Point(514, 6);
            this.modsGamedata_listView.Name = "modsGamedata_listView";
            this.modsGamedata_listView.Size = new System.Drawing.Size(517, 646);
            this.modsGamedata_listView.TabIndex = 51;
            this.modsGamedata_listView.UseCompatibleStateImageBehavior = false;
            this.modsGamedata_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mods Gamedata";
            this.columnHeader1.Width = 478;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 689);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1055, 716);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stalker Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button removeMod_button;
        private System.Windows.Forms.Button lowerMod_button;
        private System.Windows.Forms.Button upMod_button;
        private System.Windows.Forms.Button addMod_button;
        private System.Windows.Forms.Button saveSettingsClient_button;
        private System.Windows.Forms.Button changePathToArma3Client_button;
        private System.Windows.Forms.Button launch_button;
        private System.Windows.Forms.TextBox startLine_textBox;
        private System.Windows.Forms.ListView modsList_listView;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox pathToStalker_textBox;
        private System.Windows.Forms.TextBox xmlPath_textBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView stalkerGamedata_listView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView modsGamedata_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buildGamedata_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button selectAll_button;
        private System.Windows.Forms.Button deselectAll_button;
        private System.Windows.Forms.Button clearAndBuildGamedata_button;
        private System.Windows.Forms.Button addModsFolder_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addPreset_button;
        private System.Windows.Forms.Button removePreset_button;
        private System.Windows.Forms.TextBox presetName_textBox;
    }
}


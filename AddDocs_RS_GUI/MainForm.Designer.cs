namespace AddDocs_RS_GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uxDrawer_Label = new System.Windows.Forms.Label();
            this.uxField1_Label = new System.Windows.Forms.Label();
            this.uxField2_Label = new System.Windows.Forms.Label();
            this.uxField3_Label = new System.Windows.Forms.Label();
            this.uxField4_Label = new System.Windows.Forms.Label();
            this.uxField5_Label = new System.Windows.Forms.Label();
            this.uxDocType_Label = new System.Windows.Forms.Label();
            this.uxDrawer_TextBox = new System.Windows.Forms.TextBox();
            this.uxField1_TextBox = new System.Windows.Forms.TextBox();
            this.uxField2_TextBox = new System.Windows.Forms.TextBox();
            this.uxField5_TextBox = new System.Windows.Forms.TextBox();
            this.uxField4_TextBox = new System.Windows.Forms.TextBox();
            this.uxField3_TextBox = new System.Windows.Forms.TextBox();
            this.uxDocType_TextBox = new System.Windows.Forms.TextBox();
            this.uxSubmitMulti_Button = new System.Windows.Forms.Button();
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.uxFile_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEdit_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxServerInfo_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxDocMode_GroupBox = new System.Windows.Forms.GroupBox();
            this.uxMulti_RadioButton = new System.Windows.Forms.RadioButton();
            this.uxSingle_RadioButton = new System.Windows.Forms.RadioButton();
            this.uxFileMode_GroupBox = new System.Windows.Forms.GroupBox();
            this.uxRecursive_CheckBox = new System.Windows.Forms.CheckBox();
            this.uxRapidFire_RadioButton = new System.Windows.Forms.RadioButton();
            this.uxFolder_RadioButton = new System.Windows.Forms.RadioButton();
            this.uxFile_RadioButton = new System.Windows.Forms.RadioButton();
            this.uxFolder_TextBox = new System.Windows.Forms.TextBox();
            this.uxFolder_Label = new System.Windows.Forms.Label();
            this.uxFileBrowse_Button = new System.Windows.Forms.Button();
            this.uxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.uxImageNowMulti_GroupBox = new System.Windows.Forms.GroupBox();
            this.uxAmountMulti_NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxAmountMulti_Label = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uxImageNowSingle_GroupBox = new System.Windows.Forms.GroupBox();
            this.uxAmountSingle_NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxSubmitSingle_Button = new System.Windows.Forms.Button();
            this.uxDocID_TextBox = new System.Windows.Forms.TextBox();
            this.uxDocID_Label = new System.Windows.Forms.Label();
            this.uxAmountSingle_Label = new System.Windows.Forms.Label();
            this.uxBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.uxProgressBar = new System.Windows.Forms.ProgressBar();
            this.uxMenuStrip.SuspendLayout();
            this.uxDocMode_GroupBox.SuspendLayout();
            this.uxFileMode_GroupBox.SuspendLayout();
            this.uxImageNowMulti_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxAmountMulti_NumUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.uxImageNowSingle_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxAmountSingle_NumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDrawer_Label
            // 
            this.uxDrawer_Label.AutoSize = true;
            this.uxDrawer_Label.Location = new System.Drawing.Point(39, 48);
            this.uxDrawer_Label.Name = "uxDrawer_Label";
            this.uxDrawer_Label.Size = new System.Drawing.Size(44, 13);
            this.uxDrawer_Label.TabIndex = 0;
            this.uxDrawer_Label.Text = "Drawer:";
            // 
            // uxField1_Label
            // 
            this.uxField1_Label.AutoSize = true;
            this.uxField1_Label.Location = new System.Drawing.Point(39, 74);
            this.uxField1_Label.Name = "uxField1_Label";
            this.uxField1_Label.Size = new System.Drawing.Size(41, 13);
            this.uxField1_Label.TabIndex = 1;
            this.uxField1_Label.Text = "Field 1:";
            // 
            // uxField2_Label
            // 
            this.uxField2_Label.AutoSize = true;
            this.uxField2_Label.Location = new System.Drawing.Point(39, 100);
            this.uxField2_Label.Name = "uxField2_Label";
            this.uxField2_Label.Size = new System.Drawing.Size(41, 13);
            this.uxField2_Label.TabIndex = 3;
            this.uxField2_Label.Text = "Field 2:";
            // 
            // uxField3_Label
            // 
            this.uxField3_Label.AutoSize = true;
            this.uxField3_Label.Location = new System.Drawing.Point(39, 126);
            this.uxField3_Label.Name = "uxField3_Label";
            this.uxField3_Label.Size = new System.Drawing.Size(41, 13);
            this.uxField3_Label.TabIndex = 4;
            this.uxField3_Label.Text = "Field 3:";
            // 
            // uxField4_Label
            // 
            this.uxField4_Label.AutoSize = true;
            this.uxField4_Label.Location = new System.Drawing.Point(39, 152);
            this.uxField4_Label.Name = "uxField4_Label";
            this.uxField4_Label.Size = new System.Drawing.Size(41, 13);
            this.uxField4_Label.TabIndex = 5;
            this.uxField4_Label.Text = "Field 4:";
            // 
            // uxField5_Label
            // 
            this.uxField5_Label.AutoSize = true;
            this.uxField5_Label.Location = new System.Drawing.Point(39, 178);
            this.uxField5_Label.Name = "uxField5_Label";
            this.uxField5_Label.Size = new System.Drawing.Size(41, 13);
            this.uxField5_Label.TabIndex = 6;
            this.uxField5_Label.Text = "Field 5:";
            // 
            // uxDocType_Label
            // 
            this.uxDocType_Label.AutoSize = true;
            this.uxDocType_Label.Location = new System.Drawing.Point(26, 204);
            this.uxDocType_Label.Name = "uxDocType_Label";
            this.uxDocType_Label.Size = new System.Drawing.Size(54, 13);
            this.uxDocType_Label.TabIndex = 7;
            this.uxDocType_Label.Text = "DocType:";
            // 
            // uxDrawer_TextBox
            // 
            this.uxDrawer_TextBox.Location = new System.Drawing.Point(89, 45);
            this.uxDrawer_TextBox.MaxLength = 40;
            this.uxDrawer_TextBox.Name = "uxDrawer_TextBox";
            this.uxDrawer_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxDrawer_TextBox.TabIndex = 8;
            this.uxDrawer_TextBox.Text = "Default";
            // 
            // uxField1_TextBox
            // 
            this.uxField1_TextBox.Location = new System.Drawing.Point(89, 71);
            this.uxField1_TextBox.MaxLength = 40;
            this.uxField1_TextBox.Name = "uxField1_TextBox";
            this.uxField1_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxField1_TextBox.TabIndex = 9;
            // 
            // uxField2_TextBox
            // 
            this.uxField2_TextBox.Location = new System.Drawing.Point(89, 97);
            this.uxField2_TextBox.MaxLength = 40;
            this.uxField2_TextBox.Name = "uxField2_TextBox";
            this.uxField2_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxField2_TextBox.TabIndex = 10;
            // 
            // uxField5_TextBox
            // 
            this.uxField5_TextBox.Location = new System.Drawing.Point(89, 175);
            this.uxField5_TextBox.MaxLength = 40;
            this.uxField5_TextBox.Name = "uxField5_TextBox";
            this.uxField5_TextBox.ReadOnly = true;
            this.uxField5_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxField5_TextBox.TabIndex = 13;
            this.uxField5_TextBox.Text = "Unique ID";
            // 
            // uxField4_TextBox
            // 
            this.uxField4_TextBox.Location = new System.Drawing.Point(89, 149);
            this.uxField4_TextBox.MaxLength = 40;
            this.uxField4_TextBox.Name = "uxField4_TextBox";
            this.uxField4_TextBox.ReadOnly = true;
            this.uxField4_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxField4_TextBox.TabIndex = 12;
            this.uxField4_TextBox.Text = "File Name";
            // 
            // uxField3_TextBox
            // 
            this.uxField3_TextBox.Location = new System.Drawing.Point(89, 123);
            this.uxField3_TextBox.MaxLength = 40;
            this.uxField3_TextBox.Name = "uxField3_TextBox";
            this.uxField3_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxField3_TextBox.TabIndex = 11;
            // 
            // uxDocType_TextBox
            // 
            this.uxDocType_TextBox.Location = new System.Drawing.Point(89, 201);
            this.uxDocType_TextBox.MaxLength = 40;
            this.uxDocType_TextBox.Name = "uxDocType_TextBox";
            this.uxDocType_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxDocType_TextBox.TabIndex = 14;
            this.uxDocType_TextBox.Text = "Default";
            // 
            // uxSubmitMulti_Button
            // 
            this.uxSubmitMulti_Button.Location = new System.Drawing.Point(89, 227);
            this.uxSubmitMulti_Button.Name = "uxSubmitMulti_Button";
            this.uxSubmitMulti_Button.Size = new System.Drawing.Size(202, 23);
            this.uxSubmitMulti_Button.TabIndex = 15;
            this.uxSubmitMulti_Button.Text = "Submit";
            this.uxSubmitMulti_Button.UseVisualStyleBackColor = true;
            this.uxSubmitMulti_Button.Click += new System.EventHandler(this.uxSubmit_Button_Click);
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFile_MenuItem,
            this.uxEdit_MenuItem});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(354, 24);
            this.uxMenuStrip.TabIndex = 16;
            this.uxMenuStrip.Text = "exMenuStrip";
            // 
            // uxFile_MenuItem
            // 
            this.uxFile_MenuItem.Name = "uxFile_MenuItem";
            this.uxFile_MenuItem.Size = new System.Drawing.Size(37, 20);
            this.uxFile_MenuItem.Text = "File";
            // 
            // uxEdit_MenuItem
            // 
            this.uxEdit_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxServerInfo_MenuItem});
            this.uxEdit_MenuItem.Name = "uxEdit_MenuItem";
            this.uxEdit_MenuItem.Size = new System.Drawing.Size(55, 20);
            this.uxEdit_MenuItem.Text = "Config";
            // 
            // uxServerInfo_MenuItem
            // 
            this.uxServerInfo_MenuItem.Name = "uxServerInfo_MenuItem";
            this.uxServerInfo_MenuItem.Size = new System.Drawing.Size(130, 22);
            this.uxServerInfo_MenuItem.Text = "Server Info";
            this.uxServerInfo_MenuItem.Click += new System.EventHandler(this.uxServerInfo_MenuItem_Click);
            // 
            // uxDocMode_GroupBox
            // 
            this.uxDocMode_GroupBox.Controls.Add(this.uxMulti_RadioButton);
            this.uxDocMode_GroupBox.Controls.Add(this.uxSingle_RadioButton);
            this.uxDocMode_GroupBox.Location = new System.Drawing.Point(13, 19);
            this.uxDocMode_GroupBox.Name = "uxDocMode_GroupBox";
            this.uxDocMode_GroupBox.Size = new System.Drawing.Size(152, 90);
            this.uxDocMode_GroupBox.TabIndex = 17;
            this.uxDocMode_GroupBox.TabStop = false;
            this.uxDocMode_GroupBox.Text = "ImageNow Mode";
            // 
            // uxMulti_RadioButton
            // 
            this.uxMulti_RadioButton.AutoSize = true;
            this.uxMulti_RadioButton.Checked = true;
            this.uxMulti_RadioButton.Location = new System.Drawing.Point(6, 27);
            this.uxMulti_RadioButton.Name = "uxMulti_RadioButton";
            this.uxMulti_RadioButton.Size = new System.Drawing.Size(47, 17);
            this.uxMulti_RadioButton.TabIndex = 19;
            this.uxMulti_RadioButton.TabStop = true;
            this.uxMulti_RadioButton.Text = "Multi";
            this.uxToolTip.SetToolTip(this.uxMulti_RadioButton, "Create multiple documents in ImageNow");
            this.uxMulti_RadioButton.UseVisualStyleBackColor = true;
            this.uxMulti_RadioButton.CheckedChanged += new System.EventHandler(this.uxMulti_RadioButton_CheckedChanged);
            // 
            // uxSingle_RadioButton
            // 
            this.uxSingle_RadioButton.AutoSize = true;
            this.uxSingle_RadioButton.Location = new System.Drawing.Point(6, 50);
            this.uxSingle_RadioButton.Name = "uxSingle_RadioButton";
            this.uxSingle_RadioButton.Size = new System.Drawing.Size(54, 17);
            this.uxSingle_RadioButton.TabIndex = 18;
            this.uxSingle_RadioButton.Text = "Single";
            this.uxToolTip.SetToolTip(this.uxSingle_RadioButton, "Add pages to a document in ImageNow");
            this.uxSingle_RadioButton.UseVisualStyleBackColor = true;
            this.uxSingle_RadioButton.CheckedChanged += new System.EventHandler(this.uxSingle_RadioButton_CheckedChanged);
            // 
            // uxFileMode_GroupBox
            // 
            this.uxFileMode_GroupBox.Controls.Add(this.uxRecursive_CheckBox);
            this.uxFileMode_GroupBox.Controls.Add(this.uxRapidFire_RadioButton);
            this.uxFileMode_GroupBox.Controls.Add(this.uxFolder_RadioButton);
            this.uxFileMode_GroupBox.Controls.Add(this.uxFile_RadioButton);
            this.uxFileMode_GroupBox.Location = new System.Drawing.Point(171, 19);
            this.uxFileMode_GroupBox.Name = "uxFileMode_GroupBox";
            this.uxFileMode_GroupBox.Size = new System.Drawing.Size(152, 90);
            this.uxFileMode_GroupBox.TabIndex = 18;
            this.uxFileMode_GroupBox.TabStop = false;
            this.uxFileMode_GroupBox.Text = "File Mode";
            // 
            // uxRecursive_CheckBox
            // 
            this.uxRecursive_CheckBox.AutoSize = true;
            this.uxRecursive_CheckBox.Location = new System.Drawing.Point(67, 19);
            this.uxRecursive_CheckBox.Name = "uxRecursive_CheckBox";
            this.uxRecursive_CheckBox.Size = new System.Drawing.Size(76, 17);
            this.uxRecursive_CheckBox.TabIndex = 23;
            this.uxRecursive_CheckBox.Text = "Subfolders";
            this.uxToolTip.SetToolTip(this.uxRecursive_CheckBox, "(Folder only) If selected will use files from all subfolders in directory");
            this.uxRecursive_CheckBox.UseVisualStyleBackColor = true;
            // 
            // uxRapidFire_RadioButton
            // 
            this.uxRapidFire_RadioButton.AutoSize = true;
            this.uxRapidFire_RadioButton.Location = new System.Drawing.Point(6, 65);
            this.uxRapidFire_RadioButton.Name = "uxRapidFire_RadioButton";
            this.uxRapidFire_RadioButton.Size = new System.Drawing.Size(73, 17);
            this.uxRapidFire_RadioButton.TabIndex = 22;
            this.uxRapidFire_RadioButton.Text = "Rapid Fire";
            this.uxToolTip.SetToolTip(this.uxRapidFire_RadioButton, "No physical objects will be used");
            this.uxRapidFire_RadioButton.UseVisualStyleBackColor = true;
            this.uxRapidFire_RadioButton.CheckedChanged += new System.EventHandler(this.uxRapidFire_RadioButton_CheckedChanged);
            // 
            // uxFolder_RadioButton
            // 
            this.uxFolder_RadioButton.AutoSize = true;
            this.uxFolder_RadioButton.Checked = true;
            this.uxFolder_RadioButton.Location = new System.Drawing.Point(6, 19);
            this.uxFolder_RadioButton.Name = "uxFolder_RadioButton";
            this.uxFolder_RadioButton.Size = new System.Drawing.Size(54, 17);
            this.uxFolder_RadioButton.TabIndex = 21;
            this.uxFolder_RadioButton.TabStop = true;
            this.uxFolder_RadioButton.Text = "Folder";
            this.uxToolTip.SetToolTip(this.uxFolder_RadioButton, "Use all files in a directory");
            this.uxFolder_RadioButton.UseVisualStyleBackColor = true;
            this.uxFolder_RadioButton.CheckedChanged += new System.EventHandler(this.uxFolder_RadioButton_CheckedChanged);
            // 
            // uxFile_RadioButton
            // 
            this.uxFile_RadioButton.AutoSize = true;
            this.uxFile_RadioButton.Location = new System.Drawing.Point(6, 42);
            this.uxFile_RadioButton.Name = "uxFile_RadioButton";
            this.uxFile_RadioButton.Size = new System.Drawing.Size(41, 17);
            this.uxFile_RadioButton.TabIndex = 20;
            this.uxFile_RadioButton.Text = "File";
            this.uxToolTip.SetToolTip(this.uxFile_RadioButton, "Use a single file");
            this.uxFile_RadioButton.UseVisualStyleBackColor = true;
            this.uxFile_RadioButton.CheckedChanged += new System.EventHandler(this.uxFile_RadioButton_CheckedChanged);
            // 
            // uxFolder_TextBox
            // 
            this.uxFolder_TextBox.Location = new System.Drawing.Point(58, 115);
            this.uxFolder_TextBox.MaxLength = 500;
            this.uxFolder_TextBox.Name = "uxFolder_TextBox";
            this.uxFolder_TextBox.ReadOnly = true;
            this.uxFolder_TextBox.Size = new System.Drawing.Size(229, 20);
            this.uxFolder_TextBox.TabIndex = 20;
            // 
            // uxFolder_Label
            // 
            this.uxFolder_Label.AutoSize = true;
            this.uxFolder_Label.Location = new System.Drawing.Point(10, 118);
            this.uxFolder_Label.Name = "uxFolder_Label";
            this.uxFolder_Label.Size = new System.Drawing.Size(39, 13);
            this.uxFolder_Label.TabIndex = 19;
            this.uxFolder_Label.Text = "Folder:";
            // 
            // uxFileBrowse_Button
            // 
            this.uxFileBrowse_Button.Location = new System.Drawing.Point(293, 115);
            this.uxFileBrowse_Button.Name = "uxFileBrowse_Button";
            this.uxFileBrowse_Button.Size = new System.Drawing.Size(30, 20);
            this.uxFileBrowse_Button.TabIndex = 21;
            this.uxFileBrowse_Button.Text = "...";
            this.uxFileBrowse_Button.UseVisualStyleBackColor = true;
            this.uxFileBrowse_Button.Click += new System.EventHandler(this.uxFileBrowse_Button_Click);
            // 
            // uxImageNowMulti_GroupBox
            // 
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxAmountMulti_NumUpDown);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxSubmitMulti_Button);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxAmountMulti_Label);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxDocType_TextBox);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxField5_TextBox);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxField4_TextBox);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxField3_TextBox);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxField2_TextBox);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxField1_TextBox);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxDrawer_TextBox);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxDocType_Label);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxField5_Label);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxField4_Label);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxField3_Label);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxField2_Label);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxField1_Label);
            this.uxImageNowMulti_GroupBox.Controls.Add(this.uxDrawer_Label);
            this.uxImageNowMulti_GroupBox.Location = new System.Drawing.Point(12, 180);
            this.uxImageNowMulti_GroupBox.Name = "uxImageNowMulti_GroupBox";
            this.uxImageNowMulti_GroupBox.Size = new System.Drawing.Size(330, 264);
            this.uxImageNowMulti_GroupBox.TabIndex = 22;
            this.uxImageNowMulti_GroupBox.TabStop = false;
            this.uxImageNowMulti_GroupBox.Text = "ImageNow Info";
            // 
            // uxAmountMulti_NumUpDown
            // 
            this.uxAmountMulti_NumUpDown.Location = new System.Drawing.Point(89, 19);
            this.uxAmountMulti_NumUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.uxAmountMulti_NumUpDown.Name = "uxAmountMulti_NumUpDown";
            this.uxAmountMulti_NumUpDown.Size = new System.Drawing.Size(202, 20);
            this.uxAmountMulti_NumUpDown.TabIndex = 29;
            this.uxAmountMulti_NumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxAmountMulti_Label
            // 
            this.uxAmountMulti_Label.AutoSize = true;
            this.uxAmountMulti_Label.Location = new System.Drawing.Point(7, 21);
            this.uxAmountMulti_Label.Name = "uxAmountMulti_Label";
            this.uxAmountMulti_Label.Size = new System.Drawing.Size(76, 13);
            this.uxAmountMulti_Label.TabIndex = 28;
            this.uxAmountMulti_Label.Text = "Times To Add:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.uxDocMode_GroupBox);
            this.groupBox3.Controls.Add(this.uxFileMode_GroupBox);
            this.groupBox3.Controls.Add(this.uxFolder_Label);
            this.groupBox3.Controls.Add(this.uxFileBrowse_Button);
            this.groupBox3.Controls.Add(this.uxFolder_TextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 143);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Setup";
            // 
            // uxImageNowSingle_GroupBox
            // 
            this.uxImageNowSingle_GroupBox.Controls.Add(this.uxAmountSingle_NumUpDown);
            this.uxImageNowSingle_GroupBox.Controls.Add(this.uxSubmitSingle_Button);
            this.uxImageNowSingle_GroupBox.Controls.Add(this.uxDocID_TextBox);
            this.uxImageNowSingle_GroupBox.Controls.Add(this.uxDocID_Label);
            this.uxImageNowSingle_GroupBox.Controls.Add(this.uxAmountSingle_Label);
            this.uxImageNowSingle_GroupBox.Location = new System.Drawing.Point(12, 180);
            this.uxImageNowSingle_GroupBox.Name = "uxImageNowSingle_GroupBox";
            this.uxImageNowSingle_GroupBox.Size = new System.Drawing.Size(330, 104);
            this.uxImageNowSingle_GroupBox.TabIndex = 25;
            this.uxImageNowSingle_GroupBox.TabStop = false;
            this.uxImageNowSingle_GroupBox.Text = "ImageNow Info";
            this.uxImageNowSingle_GroupBox.Visible = false;
            // 
            // uxAmountSingle_NumUpDown
            // 
            this.uxAmountSingle_NumUpDown.Location = new System.Drawing.Point(89, 19);
            this.uxAmountSingle_NumUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.uxAmountSingle_NumUpDown.Name = "uxAmountSingle_NumUpDown";
            this.uxAmountSingle_NumUpDown.Size = new System.Drawing.Size(202, 20);
            this.uxAmountSingle_NumUpDown.TabIndex = 27;
            this.uxAmountSingle_NumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxSubmitSingle_Button
            // 
            this.uxSubmitSingle_Button.Location = new System.Drawing.Point(89, 71);
            this.uxSubmitSingle_Button.Name = "uxSubmitSingle_Button";
            this.uxSubmitSingle_Button.Size = new System.Drawing.Size(202, 23);
            this.uxSubmitSingle_Button.TabIndex = 26;
            this.uxSubmitSingle_Button.Text = "Submit";
            this.uxSubmitSingle_Button.UseVisualStyleBackColor = true;
            this.uxSubmitSingle_Button.Click += new System.EventHandler(this.uxSubmitSingle_Button_Click);
            // 
            // uxDocID_TextBox
            // 
            this.uxDocID_TextBox.Location = new System.Drawing.Point(89, 45);
            this.uxDocID_TextBox.Name = "uxDocID_TextBox";
            this.uxDocID_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxDocID_TextBox.TabIndex = 1;
            // 
            // uxDocID_Label
            // 
            this.uxDocID_Label.AutoSize = true;
            this.uxDocID_Label.Location = new System.Drawing.Point(39, 48);
            this.uxDocID_Label.Name = "uxDocID_Label";
            this.uxDocID_Label.Size = new System.Drawing.Size(44, 13);
            this.uxDocID_Label.TabIndex = 0;
            this.uxDocID_Label.Text = "Doc ID:";
            // 
            // uxAmountSingle_Label
            // 
            this.uxAmountSingle_Label.AutoSize = true;
            this.uxAmountSingle_Label.Location = new System.Drawing.Point(7, 21);
            this.uxAmountSingle_Label.Name = "uxAmountSingle_Label";
            this.uxAmountSingle_Label.Size = new System.Drawing.Size(76, 13);
            this.uxAmountSingle_Label.TabIndex = 26;
            this.uxAmountSingle_Label.Text = "Times To Add:";
            // 
            // uxBackgroundWorker
            // 
            this.uxBackgroundWorker.WorkerReportsProgress = true;
            this.uxBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.uxBackgroundWorker_DoWork);
            this.uxBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.uxBackgroundWorker_ProgressChanged);
            // 
            // uxProgressBar
            // 
            this.uxProgressBar.Location = new System.Drawing.Point(12, 450);
            this.uxProgressBar.Name = "uxProgressBar";
            this.uxProgressBar.Size = new System.Drawing.Size(330, 15);
            this.uxProgressBar.TabIndex = 26;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 476);
            this.Controls.Add(this.uxProgressBar);
            this.Controls.Add(this.uxImageNowSingle_GroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.uxImageNowMulti_GroupBox);
            this.Controls.Add(this.uxMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.uxMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "AddDocs";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
            this.uxDocMode_GroupBox.ResumeLayout(false);
            this.uxDocMode_GroupBox.PerformLayout();
            this.uxFileMode_GroupBox.ResumeLayout(false);
            this.uxFileMode_GroupBox.PerformLayout();
            this.uxImageNowMulti_GroupBox.ResumeLayout(false);
            this.uxImageNowMulti_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxAmountMulti_NumUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.uxImageNowSingle_GroupBox.ResumeLayout(false);
            this.uxImageNowSingle_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxAmountSingle_NumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxDrawer_Label;
        private System.Windows.Forms.Label uxField1_Label;
        private System.Windows.Forms.Label uxField2_Label;
        private System.Windows.Forms.Label uxField3_Label;
        private System.Windows.Forms.Label uxField4_Label;
        private System.Windows.Forms.Label uxField5_Label;
        private System.Windows.Forms.Label uxDocType_Label;
        private System.Windows.Forms.TextBox uxDrawer_TextBox;
        private System.Windows.Forms.TextBox uxField1_TextBox;
        private System.Windows.Forms.TextBox uxField2_TextBox;
        private System.Windows.Forms.TextBox uxField5_TextBox;
        private System.Windows.Forms.TextBox uxField4_TextBox;
        private System.Windows.Forms.TextBox uxField3_TextBox;
        private System.Windows.Forms.TextBox uxDocType_TextBox;
        private System.Windows.Forms.Button uxSubmitMulti_Button;
        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uxFile_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxEdit_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxServerInfo_MenuItem;
        private System.Windows.Forms.GroupBox uxDocMode_GroupBox;
        private System.Windows.Forms.RadioButton uxMulti_RadioButton;
        private System.Windows.Forms.RadioButton uxSingle_RadioButton;
        private System.Windows.Forms.GroupBox uxFileMode_GroupBox;
        private System.Windows.Forms.TextBox uxFolder_TextBox;
        private System.Windows.Forms.Label uxFolder_Label;
        private System.Windows.Forms.Button uxFileBrowse_Button;
        private System.Windows.Forms.RadioButton uxFolder_RadioButton;
        private System.Windows.Forms.RadioButton uxFile_RadioButton;
        private System.Windows.Forms.ToolTip uxToolTip;
        private System.Windows.Forms.RadioButton uxRapidFire_RadioButton;
        private System.Windows.Forms.GroupBox uxImageNowMulti_GroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox uxImageNowSingle_GroupBox;
        private System.Windows.Forms.TextBox uxDocID_TextBox;
        private System.Windows.Forms.Label uxDocID_Label;
        private System.Windows.Forms.Button uxSubmitSingle_Button;
        private System.Windows.Forms.NumericUpDown uxAmountSingle_NumUpDown;
        private System.Windows.Forms.Label uxAmountSingle_Label;
        private System.Windows.Forms.NumericUpDown uxAmountMulti_NumUpDown;
        private System.Windows.Forms.Label uxAmountMulti_Label;
        private System.Windows.Forms.CheckBox uxRecursive_CheckBox;
        private System.ComponentModel.BackgroundWorker uxBackgroundWorker;
        private System.Windows.Forms.ProgressBar uxProgressBar;
    }
}


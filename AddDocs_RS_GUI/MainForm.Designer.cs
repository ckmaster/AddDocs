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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uxDrawer_TextBox = new System.Windows.Forms.TextBox();
            this.uxField1_TextBox = new System.Windows.Forms.TextBox();
            this.uxField2_TextBox = new System.Windows.Forms.TextBox();
            this.uxField5_TextBox = new System.Windows.Forms.TextBox();
            this.uxField4_TextBox = new System.Windows.Forms.TextBox();
            this.uxField3_TextBox = new System.Windows.Forms.TextBox();
            this.uxDocType_TextBox = new System.Windows.Forms.TextBox();
            this.uxSubmit_Button = new System.Windows.Forms.Button();
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.uxFile_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxHelp_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEdit_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxServerInfo_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxDocMode_GroupBox = new System.Windows.Forms.GroupBox();
            this.uxMulti_RadioButton = new System.Windows.Forms.RadioButton();
            this.uxSingle_RadioButton = new System.Windows.Forms.RadioButton();
            this.uxFileMode_GroupBox = new System.Windows.Forms.GroupBox();
            this.uxRapidFire_RadioButton = new System.Windows.Forms.RadioButton();
            this.uxDefault_RadioButton = new System.Windows.Forms.RadioButton();
            this.uxSimple_RadioButton = new System.Windows.Forms.RadioButton();
            this.uxFolder_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.uxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.uxImageNow_GroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uxError_PictureBox = new System.Windows.Forms.PictureBox();
            this.uxHelp_PictureBox = new System.Windows.Forms.PictureBox();
            this.uxMenuStrip.SuspendLayout();
            this.uxDocMode_GroupBox.SuspendLayout();
            this.uxFileMode_GroupBox.SuspendLayout();
            this.uxImageNow_GroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxError_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxHelp_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drawer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Field 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Field 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Field 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Field 4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Field 5:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "DocType:";
            // 
            // uxDrawer_TextBox
            // 
            this.uxDrawer_TextBox.Location = new System.Drawing.Point(85, 19);
            this.uxDrawer_TextBox.MaxLength = 40;
            this.uxDrawer_TextBox.Name = "uxDrawer_TextBox";
            this.uxDrawer_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxDrawer_TextBox.TabIndex = 8;
            this.uxDrawer_TextBox.Text = "Default";
            // 
            // uxField1_TextBox
            // 
            this.uxField1_TextBox.Location = new System.Drawing.Point(85, 45);
            this.uxField1_TextBox.MaxLength = 40;
            this.uxField1_TextBox.Name = "uxField1_TextBox";
            this.uxField1_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxField1_TextBox.TabIndex = 9;
            // 
            // uxField2_TextBox
            // 
            this.uxField2_TextBox.Location = new System.Drawing.Point(85, 71);
            this.uxField2_TextBox.MaxLength = 40;
            this.uxField2_TextBox.Name = "uxField2_TextBox";
            this.uxField2_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxField2_TextBox.TabIndex = 10;
            // 
            // uxField5_TextBox
            // 
            this.uxField5_TextBox.Location = new System.Drawing.Point(85, 149);
            this.uxField5_TextBox.MaxLength = 40;
            this.uxField5_TextBox.Name = "uxField5_TextBox";
            this.uxField5_TextBox.ReadOnly = true;
            this.uxField5_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxField5_TextBox.TabIndex = 13;
            this.uxField5_TextBox.Text = "Unique ID";
            // 
            // uxField4_TextBox
            // 
            this.uxField4_TextBox.Location = new System.Drawing.Point(85, 123);
            this.uxField4_TextBox.MaxLength = 40;
            this.uxField4_TextBox.Name = "uxField4_TextBox";
            this.uxField4_TextBox.ReadOnly = true;
            this.uxField4_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxField4_TextBox.TabIndex = 12;
            this.uxField4_TextBox.Text = "File Name";
            // 
            // uxField3_TextBox
            // 
            this.uxField3_TextBox.Location = new System.Drawing.Point(85, 97);
            this.uxField3_TextBox.MaxLength = 40;
            this.uxField3_TextBox.Name = "uxField3_TextBox";
            this.uxField3_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxField3_TextBox.TabIndex = 11;
            // 
            // uxDocType_TextBox
            // 
            this.uxDocType_TextBox.Location = new System.Drawing.Point(85, 175);
            this.uxDocType_TextBox.MaxLength = 40;
            this.uxDocType_TextBox.Name = "uxDocType_TextBox";
            this.uxDocType_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxDocType_TextBox.TabIndex = 14;
            this.uxDocType_TextBox.Text = "Default";
            // 
            // uxSubmit_Button
            // 
            this.uxSubmit_Button.Location = new System.Drawing.Point(85, 201);
            this.uxSubmit_Button.Name = "uxSubmit_Button";
            this.uxSubmit_Button.Size = new System.Drawing.Size(202, 23);
            this.uxSubmit_Button.TabIndex = 15;
            this.uxSubmit_Button.Text = "Submit";
            this.uxSubmit_Button.UseVisualStyleBackColor = true;
            this.uxSubmit_Button.Click += new System.EventHandler(this.uxSubmit_Button_Click);
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFile_MenuItem,
            this.uxEdit_MenuItem});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(353, 24);
            this.uxMenuStrip.TabIndex = 16;
            this.uxMenuStrip.Text = "exMenuStrip";
            // 
            // uxFile_MenuItem
            // 
            this.uxFile_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxHelp_MenuItem});
            this.uxFile_MenuItem.Name = "uxFile_MenuItem";
            this.uxFile_MenuItem.Size = new System.Drawing.Size(37, 20);
            this.uxFile_MenuItem.Text = "File";
            // 
            // uxHelp_MenuItem
            // 
            this.uxHelp_MenuItem.Name = "uxHelp_MenuItem";
            this.uxHelp_MenuItem.Size = new System.Drawing.Size(99, 22);
            this.uxHelp_MenuItem.Text = "Help";
            this.uxHelp_MenuItem.Click += new System.EventHandler(this.uxHelp_MenuItem_Click);
            // 
            // uxEdit_MenuItem
            // 
            this.uxEdit_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxServerInfo_MenuItem,
            this.fileDirectoryToolStripMenuItem});
            this.uxEdit_MenuItem.Name = "uxEdit_MenuItem";
            this.uxEdit_MenuItem.Size = new System.Drawing.Size(39, 20);
            this.uxEdit_MenuItem.Text = "Edit";
            // 
            // uxServerInfo_MenuItem
            // 
            this.uxServerInfo_MenuItem.Name = "uxServerInfo_MenuItem";
            this.uxServerInfo_MenuItem.Size = new System.Drawing.Size(143, 22);
            this.uxServerInfo_MenuItem.Text = "Server Info";
            this.uxServerInfo_MenuItem.Click += new System.EventHandler(this.uxServerInfo_MenuItem_Click);
            // 
            // fileDirectoryToolStripMenuItem
            // 
            this.fileDirectoryToolStripMenuItem.Name = "fileDirectoryToolStripMenuItem";
            this.fileDirectoryToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.fileDirectoryToolStripMenuItem.Text = "File Directory";
            this.fileDirectoryToolStripMenuItem.Click += new System.EventHandler(this.fileDirectoryToolStripMenuItem_Click);
            // 
            // uxDocMode_GroupBox
            // 
            this.uxDocMode_GroupBox.Controls.Add(this.uxMulti_RadioButton);
            this.uxDocMode_GroupBox.Controls.Add(this.uxSingle_RadioButton);
            this.uxDocMode_GroupBox.Location = new System.Drawing.Point(26, 19);
            this.uxDocMode_GroupBox.Name = "uxDocMode_GroupBox";
            this.uxDocMode_GroupBox.Size = new System.Drawing.Size(125, 90);
            this.uxDocMode_GroupBox.TabIndex = 17;
            this.uxDocMode_GroupBox.TabStop = false;
            this.uxDocMode_GroupBox.Text = "Doc Mode";
            // 
            // uxMulti_RadioButton
            // 
            this.uxMulti_RadioButton.AutoSize = true;
            this.uxMulti_RadioButton.Location = new System.Drawing.Point(6, 27);
            this.uxMulti_RadioButton.Name = "uxMulti_RadioButton";
            this.uxMulti_RadioButton.Size = new System.Drawing.Size(47, 17);
            this.uxMulti_RadioButton.TabIndex = 19;
            this.uxMulti_RadioButton.TabStop = true;
            this.uxMulti_RadioButton.Text = "Multi";
            this.uxToolTip.SetToolTip(this.uxMulti_RadioButton, "Create multiple documents in ImageNow");
            this.uxMulti_RadioButton.UseVisualStyleBackColor = true;
            // 
            // uxSingle_RadioButton
            // 
            this.uxSingle_RadioButton.AutoSize = true;
            this.uxSingle_RadioButton.Location = new System.Drawing.Point(6, 50);
            this.uxSingle_RadioButton.Name = "uxSingle_RadioButton";
            this.uxSingle_RadioButton.Size = new System.Drawing.Size(54, 17);
            this.uxSingle_RadioButton.TabIndex = 18;
            this.uxSingle_RadioButton.TabStop = true;
            this.uxSingle_RadioButton.Text = "Single";
            this.uxToolTip.SetToolTip(this.uxSingle_RadioButton, "Add pages to a document in ImageNow");
            this.uxSingle_RadioButton.UseVisualStyleBackColor = true;
            // 
            // uxFileMode_GroupBox
            // 
            this.uxFileMode_GroupBox.Controls.Add(this.uxRapidFire_RadioButton);
            this.uxFileMode_GroupBox.Controls.Add(this.uxDefault_RadioButton);
            this.uxFileMode_GroupBox.Controls.Add(this.uxSimple_RadioButton);
            this.uxFileMode_GroupBox.Location = new System.Drawing.Point(162, 19);
            this.uxFileMode_GroupBox.Name = "uxFileMode_GroupBox";
            this.uxFileMode_GroupBox.Size = new System.Drawing.Size(125, 90);
            this.uxFileMode_GroupBox.TabIndex = 18;
            this.uxFileMode_GroupBox.TabStop = false;
            this.uxFileMode_GroupBox.Text = "File Mode";
            // 
            // uxRapidFire_RadioButton
            // 
            this.uxRapidFire_RadioButton.AutoSize = true;
            this.uxRapidFire_RadioButton.Location = new System.Drawing.Point(6, 65);
            this.uxRapidFire_RadioButton.Name = "uxRapidFire_RadioButton";
            this.uxRapidFire_RadioButton.Size = new System.Drawing.Size(73, 17);
            this.uxRapidFire_RadioButton.TabIndex = 22;
            this.uxRapidFire_RadioButton.TabStop = true;
            this.uxRapidFire_RadioButton.Text = "Rapid Fire";
            this.uxToolTip.SetToolTip(this.uxRapidFire_RadioButton, "No physical objects will be used, will create 0 byte pages in single mode, or doc" +
        "uments without pages in multi mode");
            this.uxRapidFire_RadioButton.UseVisualStyleBackColor = true;
            // 
            // uxDefault_RadioButton
            // 
            this.uxDefault_RadioButton.AutoSize = true;
            this.uxDefault_RadioButton.Location = new System.Drawing.Point(6, 19);
            this.uxDefault_RadioButton.Name = "uxDefault_RadioButton";
            this.uxDefault_RadioButton.Size = new System.Drawing.Size(59, 17);
            this.uxDefault_RadioButton.TabIndex = 21;
            this.uxDefault_RadioButton.TabStop = true;
            this.uxDefault_RadioButton.Text = "Default";
            this.uxToolTip.SetToolTip(this.uxDefault_RadioButton, "Grab all the files in a directory");
            this.uxDefault_RadioButton.UseVisualStyleBackColor = true;
            // 
            // uxSimple_RadioButton
            // 
            this.uxSimple_RadioButton.AutoSize = true;
            this.uxSimple_RadioButton.Location = new System.Drawing.Point(6, 42);
            this.uxSimple_RadioButton.Name = "uxSimple_RadioButton";
            this.uxSimple_RadioButton.Size = new System.Drawing.Size(56, 17);
            this.uxSimple_RadioButton.TabIndex = 20;
            this.uxSimple_RadioButton.TabStop = true;
            this.uxSimple_RadioButton.Text = "Simple";
            this.uxToolTip.SetToolTip(this.uxSimple_RadioButton, "Use a single file");
            this.uxSimple_RadioButton.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Folder:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 20);
            this.button1.TabIndex = 21;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uxImageNow_GroupBox
            // 
            this.uxImageNow_GroupBox.Controls.Add(this.uxSubmit_Button);
            this.uxImageNow_GroupBox.Controls.Add(this.uxDocType_TextBox);
            this.uxImageNow_GroupBox.Controls.Add(this.uxField5_TextBox);
            this.uxImageNow_GroupBox.Controls.Add(this.uxField4_TextBox);
            this.uxImageNow_GroupBox.Controls.Add(this.uxField3_TextBox);
            this.uxImageNow_GroupBox.Controls.Add(this.uxField2_TextBox);
            this.uxImageNow_GroupBox.Controls.Add(this.uxField1_TextBox);
            this.uxImageNow_GroupBox.Controls.Add(this.uxDrawer_TextBox);
            this.uxImageNow_GroupBox.Controls.Add(this.label8);
            this.uxImageNow_GroupBox.Controls.Add(this.label7);
            this.uxImageNow_GroupBox.Controls.Add(this.label6);
            this.uxImageNow_GroupBox.Controls.Add(this.label5);
            this.uxImageNow_GroupBox.Controls.Add(this.label4);
            this.uxImageNow_GroupBox.Controls.Add(this.label2);
            this.uxImageNow_GroupBox.Controls.Add(this.label1);
            this.uxImageNow_GroupBox.Location = new System.Drawing.Point(12, 180);
            this.uxImageNow_GroupBox.Name = "uxImageNow_GroupBox";
            this.uxImageNow_GroupBox.Size = new System.Drawing.Size(330, 236);
            this.uxImageNow_GroupBox.TabIndex = 22;
            this.uxImageNow_GroupBox.TabStop = false;
            this.uxImageNow_GroupBox.Text = "ImageNow Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.uxError_PictureBox);
            this.groupBox3.Controls.Add(this.uxDocMode_GroupBox);
            this.groupBox3.Controls.Add(this.uxHelp_PictureBox);
            this.groupBox3.Controls.Add(this.uxFileMode_GroupBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.uxFolder_TextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 143);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Setup";
            // 
            // uxError_PictureBox
            // 
            this.uxError_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("uxError_PictureBox.Image")));
            this.uxError_PictureBox.InitialImage = null;
            this.uxError_PictureBox.Location = new System.Drawing.Point(293, 69);
            this.uxError_PictureBox.Name = "uxError_PictureBox";
            this.uxError_PictureBox.Size = new System.Drawing.Size(30, 30);
            this.uxError_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uxError_PictureBox.TabIndex = 24;
            this.uxError_PictureBox.TabStop = false;
            this.uxError_PictureBox.Click += new System.EventHandler(this.uxError_PictureBox_Click);
            // 
            // uxHelp_PictureBox
            // 
            this.uxHelp_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("uxHelp_PictureBox.Image")));
            this.uxHelp_PictureBox.ImageLocation = "";
            this.uxHelp_PictureBox.InitialImage = null;
            this.uxHelp_PictureBox.Location = new System.Drawing.Point(293, 33);
            this.uxHelp_PictureBox.Name = "uxHelp_PictureBox";
            this.uxHelp_PictureBox.Size = new System.Drawing.Size(30, 30);
            this.uxHelp_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uxHelp_PictureBox.TabIndex = 23;
            this.uxHelp_PictureBox.TabStop = false;
            this.uxHelp_PictureBox.Click += new System.EventHandler(this.uxHelp_PictureBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 425);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.uxImageNow_GroupBox);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
            this.Name = "MainForm";
            this.Text = "AddDocs";
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
            this.uxDocMode_GroupBox.ResumeLayout(false);
            this.uxDocMode_GroupBox.PerformLayout();
            this.uxFileMode_GroupBox.ResumeLayout(false);
            this.uxFileMode_GroupBox.PerformLayout();
            this.uxImageNow_GroupBox.ResumeLayout(false);
            this.uxImageNow_GroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxError_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxHelp_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uxDrawer_TextBox;
        private System.Windows.Forms.TextBox uxField1_TextBox;
        private System.Windows.Forms.TextBox uxField2_TextBox;
        private System.Windows.Forms.TextBox uxField5_TextBox;
        private System.Windows.Forms.TextBox uxField4_TextBox;
        private System.Windows.Forms.TextBox uxField3_TextBox;
        private System.Windows.Forms.TextBox uxDocType_TextBox;
        private System.Windows.Forms.Button uxSubmit_Button;
        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uxFile_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxHelp_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxEdit_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxServerInfo_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileDirectoryToolStripMenuItem;
        private System.Windows.Forms.GroupBox uxDocMode_GroupBox;
        private System.Windows.Forms.RadioButton uxMulti_RadioButton;
        private System.Windows.Forms.RadioButton uxSingle_RadioButton;
        private System.Windows.Forms.GroupBox uxFileMode_GroupBox;
        private System.Windows.Forms.TextBox uxFolder_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton uxDefault_RadioButton;
        private System.Windows.Forms.RadioButton uxSimple_RadioButton;
        private System.Windows.Forms.ToolTip uxToolTip;
        private System.Windows.Forms.RadioButton uxRapidFire_RadioButton;
        private System.Windows.Forms.GroupBox uxImageNow_GroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox uxError_PictureBox;
        private System.Windows.Forms.PictureBox uxHelp_PictureBox;
    }
}


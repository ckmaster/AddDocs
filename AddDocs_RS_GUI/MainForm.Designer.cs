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
            this.uxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drawer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Field 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Field 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Field 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Field 4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Field 5:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "DocType:";
            // 
            // uxDrawer_TextBox
            // 
            this.uxDrawer_TextBox.Location = new System.Drawing.Point(67, 27);
            this.uxDrawer_TextBox.MaxLength = 40;
            this.uxDrawer_TextBox.Name = "uxDrawer_TextBox";
            this.uxDrawer_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxDrawer_TextBox.TabIndex = 8;
            this.uxDrawer_TextBox.Text = "Default";
            // 
            // uxField1_TextBox
            // 
            this.uxField1_TextBox.Location = new System.Drawing.Point(67, 53);
            this.uxField1_TextBox.MaxLength = 40;
            this.uxField1_TextBox.Name = "uxField1_TextBox";
            this.uxField1_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxField1_TextBox.TabIndex = 9;
            // 
            // uxField2_TextBox
            // 
            this.uxField2_TextBox.Location = new System.Drawing.Point(67, 79);
            this.uxField2_TextBox.MaxLength = 40;
            this.uxField2_TextBox.Name = "uxField2_TextBox";
            this.uxField2_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxField2_TextBox.TabIndex = 10;
            // 
            // uxField5_TextBox
            // 
            this.uxField5_TextBox.Location = new System.Drawing.Point(67, 157);
            this.uxField5_TextBox.MaxLength = 40;
            this.uxField5_TextBox.Name = "uxField5_TextBox";
            this.uxField5_TextBox.ReadOnly = true;
            this.uxField5_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxField5_TextBox.TabIndex = 13;
            this.uxField5_TextBox.Text = "Unique ID";
            // 
            // uxField4_TextBox
            // 
            this.uxField4_TextBox.Location = new System.Drawing.Point(67, 131);
            this.uxField4_TextBox.MaxLength = 40;
            this.uxField4_TextBox.Name = "uxField4_TextBox";
            this.uxField4_TextBox.ReadOnly = true;
            this.uxField4_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxField4_TextBox.TabIndex = 12;
            this.uxField4_TextBox.Text = "File Name";
            // 
            // uxField3_TextBox
            // 
            this.uxField3_TextBox.Location = new System.Drawing.Point(67, 105);
            this.uxField3_TextBox.MaxLength = 40;
            this.uxField3_TextBox.Name = "uxField3_TextBox";
            this.uxField3_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxField3_TextBox.TabIndex = 11;
            // 
            // uxDocType_TextBox
            // 
            this.uxDocType_TextBox.Location = new System.Drawing.Point(67, 183);
            this.uxDocType_TextBox.MaxLength = 40;
            this.uxDocType_TextBox.Name = "uxDocType_TextBox";
            this.uxDocType_TextBox.Size = new System.Drawing.Size(202, 20);
            this.uxDocType_TextBox.TabIndex = 14;
            this.uxDocType_TextBox.Text = "Default";
            // 
            // uxSubmit_Button
            // 
            this.uxSubmit_Button.Location = new System.Drawing.Point(67, 209);
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
            this.uxMenuStrip.Size = new System.Drawing.Size(281, 24);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 243);
            this.Controls.Add(this.uxSubmit_Button);
            this.Controls.Add(this.uxDocType_TextBox);
            this.Controls.Add(this.uxField5_TextBox);
            this.Controls.Add(this.uxField4_TextBox);
            this.Controls.Add(this.uxField3_TextBox);
            this.Controls.Add(this.uxField2_TextBox);
            this.Controls.Add(this.uxField1_TextBox);
            this.Controls.Add(this.uxDrawer_TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
            this.Name = "MainForm";
            this.Text = "AddDocs";
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
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
    }
}


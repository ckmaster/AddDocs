namespace AddDocs_RS_GUI
{
    partial class ServerInfo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxServer_TextBox = new System.Windows.Forms.TextBox();
            this.uxPort_TextBox = new System.Windows.Forms.TextBox();
            this.uxUsername_TextBox = new System.Windows.Forms.TextBox();
            this.uxPassword_Textbox = new System.Windows.Forms.TextBox();
            this.uxSubmit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // uxServer_TextBox
            // 
            this.uxServer_TextBox.Location = new System.Drawing.Point(73, 12);
            this.uxServer_TextBox.Name = "uxServer_TextBox";
            this.uxServer_TextBox.Size = new System.Drawing.Size(190, 20);
            this.uxServer_TextBox.TabIndex = 4;
            // 
            // uxPort_TextBox
            // 
            this.uxPort_TextBox.Location = new System.Drawing.Point(73, 38);
            this.uxPort_TextBox.Name = "uxPort_TextBox";
            this.uxPort_TextBox.Size = new System.Drawing.Size(190, 20);
            this.uxPort_TextBox.TabIndex = 5;
            // 
            // uxUsername_TextBox
            // 
            this.uxUsername_TextBox.Location = new System.Drawing.Point(73, 64);
            this.uxUsername_TextBox.Name = "uxUsername_TextBox";
            this.uxUsername_TextBox.Size = new System.Drawing.Size(190, 20);
            this.uxUsername_TextBox.TabIndex = 6;
            // 
            // uxPassword_Textbox
            // 
            this.uxPassword_Textbox.Location = new System.Drawing.Point(73, 90);
            this.uxPassword_Textbox.Name = "uxPassword_Textbox";
            this.uxPassword_Textbox.Size = new System.Drawing.Size(190, 20);
            this.uxPassword_Textbox.TabIndex = 7;
            // 
            // uxSubmit_Button
            // 
            this.uxSubmit_Button.Location = new System.Drawing.Point(73, 116);
            this.uxSubmit_Button.Name = "uxSubmit_Button";
            this.uxSubmit_Button.Size = new System.Drawing.Size(190, 23);
            this.uxSubmit_Button.TabIndex = 8;
            this.uxSubmit_Button.Text = "Submit";
            this.uxSubmit_Button.UseVisualStyleBackColor = true;
            this.uxSubmit_Button.Click += new System.EventHandler(this.uxSubmit_Button_Click);
            // 
            // ServerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 146);
            this.Controls.Add(this.uxSubmit_Button);
            this.Controls.Add(this.uxPassword_Textbox);
            this.Controls.Add(this.uxUsername_TextBox);
            this.Controls.Add(this.uxPort_TextBox);
            this.Controls.Add(this.uxServer_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerInfo";
            this.ShowIcon = false;
            this.Text = "ServerInfo";
            this.Load += new System.EventHandler(this.ServerInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uxServer_TextBox;
        private System.Windows.Forms.TextBox uxPort_TextBox;
        private System.Windows.Forms.TextBox uxUsername_TextBox;
        private System.Windows.Forms.TextBox uxPassword_Textbox;
        private System.Windows.Forms.Button uxSubmit_Button;
    }
}
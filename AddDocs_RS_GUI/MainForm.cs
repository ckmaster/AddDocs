using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AddDocs_RS_GUI
{
    public partial class MainForm : Form
    {
        public Controller control = new Controller();

        public MainForm ()
        {
            InitializeComponent();
            control.Initialize();
            uxFolder_TextBox.Text = control.conf.folderPath;
        }

        private void uxSubmit_Button_Click (object sender, EventArgs e)
        {
            string d = uxDrawer_TextBox.Text;
            string f1 = uxField1_TextBox.Text;
            string f2 = uxField2_TextBox.Text;
            string f3 = uxField3_TextBox.Text;
            string f4 = uxField4_TextBox.Text;
            string f5 = uxField5_TextBox.Text;
            string dt = uxDocType_TextBox.Text;
            control.DoWork(d, f1, f2, f3, f4, f5, dt);
            ClearUI();
            MessageBox.Show("Documents created and pages added");
        }

        public void ClearUI ()
        {
            this.uxDrawer_TextBox.Text = "Default";
            this.uxField1_TextBox.Clear();
            this.uxField2_TextBox.Clear();
            this.uxField3_TextBox.Clear();
            //this.uxField4_TextBox.Clear();
            //this.uxField5_TextBox.Clear();
            this.uxDocType_TextBox.Text = "Default";
        }

        private void uxHelp_MenuItem_Click (object sender, EventArgs e)
        {
            MessageBox.Show("corey.kidd@lexmark.com");
        }

        private void uxServerInfo_MenuItem_Click (object sender, EventArgs e)
        {
            ServerInfo form = new ServerInfo(control);
            form.Show();
        }

        private void fileDirectoryToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = control.conf.folderPath;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                control.conf.folderPath = path;
                uxFolder_TextBox.Text = control.conf.folderPath;
                LocalOp local = new LocalOp();
                local.SaveConfig(control.conf);
                MessageBox.Show("Default upload directory has been updated");
            }
        }

        private void uxHelp_PictureBox_Click (object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the button");
        }

        private void uxError_PictureBox_Click (object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the other button");
        }

        private void button1_Click (object sender, EventArgs e)
        {
            if (uxMulti_RadioButton.Checked == true)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.SelectedPath = control.conf.folderPath;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    control.conf.folderPath = fbd.SelectedPath;
                    uxFolder_TextBox.Text = control.conf.folderPath;
                    new LocalOp().SaveConfig(control.conf);
                    MessageBox.Show("Default upload directory has been updated");
                }
            }
            else if (uxSingle_RadioButton.Checked == true)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = control.conf.filePath;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    control.conf.filePath = ofd.FileName;
                    uxFolder_TextBox.Text = control.conf.filePath;
                    new LocalOp().SaveConfig(control.conf);
                    MessageBox.Show("Default upload file has been updated");
                }
            }
            
        }

        private void uxMulti_RadioButton_CheckedChanged (object sender, EventArgs e)
        {
            if (uxMulti_RadioButton.Checked == true)
            {
                this.Height = 464;
                uxImageNowMulti_GroupBox.Visible = true;
                uxImageNowMulti_GroupBox.Enabled = true;
                uxFolder_Label.Text = "Folder:";
                uxImageNowSingle_GroupBox.Visible = false;
                uxImageNowSingle_GroupBox.Enabled = false;
                uxFolder_TextBox.Text = control.conf.folderPath;
            }
        }

        private void uxSingle_RadioButton_CheckedChanged (object sender, EventArgs e)
        {
            if (uxSingle_RadioButton.Checked == true)
            {
                this.Height = 297;
                uxImageNowMulti_GroupBox.Visible = false;
                uxImageNowMulti_GroupBox.Enabled = false;
                uxFolder_Label.Text = "File:";
                uxImageNowSingle_GroupBox.Enabled = true;
                uxImageNowSingle_GroupBox.Visible = true;
                uxFolder_TextBox.Text = control.conf.filePath;
            }
        }

        private void uxFolder_RadioButton_CheckedChanged (object sender, EventArgs e)
        {
            if (uxFolder_RadioButton.Checked == true)
            {

            }
        }

        private void uxFile_RadioButton_CheckedChanged (object sender, EventArgs e)
        {
            if (uxFile_RadioButton.Checked == true)
            {

            }
        }

        private void uxRapidFire_RadioButton_CheckedChanged (object sender, EventArgs e)
        {
            if (uxRapidFire_RadioButton.Checked == true)
            {

            }
        }
    }
}
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
            int repeat = (int)uxAmountMulti_NumUpDown.Value;
            if (uxMulti_RadioButton.Checked == true && uxFolder_RadioButton.Checked == true)
            {
                control.MultiDocMultiFile(d, f1, f2, f3, f4, f5, dt);
                //MessageBox.Show("Documents created and pages added");
            }
            else if (uxMulti_RadioButton.Checked == true && uxFile_RadioButton.Checked == true)
            {
                control.MultiDocSingleFile(d, f1, f2, f3, f4, f5, dt, repeat);
                //MessageBox.Show("Documents created and pages added");
            }
            else if (uxMulti_RadioButton.Checked == true && uxRapidFire_RadioButton.Checked == true)
            {
                control.MultiDocRapidFire(d, f1, f2, f3, f4, f5, dt, repeat);
                //MessageBox.Show("Documents created");
            }
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

        private void uxMulti_RadioButton_CheckedChanged (object sender, EventArgs e)
        {
            if (uxMulti_RadioButton.Checked == true)
            {
                this.Height = 494;
                uxImageNowMulti_GroupBox.Visible = true;
                uxImageNowSingle_GroupBox.Visible = false;
            }
        }

        private void uxSingle_RadioButton_CheckedChanged (object sender, EventArgs e)
        {
            if (uxSingle_RadioButton.Checked == true)
            {
                this.Height = 332;
                uxImageNowMulti_GroupBox.Visible = false;
                uxImageNowSingle_GroupBox.Visible = true;
            }
        }

        private void uxFolder_RadioButton_CheckedChanged (object sender, EventArgs e)
        {
            if (uxFolder_RadioButton.Checked == true)
            {
                uxAmountSingle_NumUpDown.Enabled = false;
                uxAmountMulti_NumUpDown.Enabled = false;
                uxFolder_Label.Text = "Folder:";
                uxFolder_TextBox.Text = control.conf.folderPath;
            }
        }

        private void uxFile_RadioButton_CheckedChanged (object sender, EventArgs e)
        {
            if (uxFile_RadioButton.Checked == true)
            {
                uxAmountSingle_NumUpDown.Enabled = true;
                uxAmountMulti_NumUpDown.Enabled = true;
                uxFolder_Label.Text = "File:";
                uxFolder_TextBox.Text = control.conf.filePath;
            }
        }

        private void uxRapidFire_RadioButton_CheckedChanged (object sender, EventArgs e)
        {
            if (uxRapidFire_RadioButton.Checked == true)
            {
                uxAmountSingle_NumUpDown.Enabled = true;
                uxAmountMulti_NumUpDown.Enabled = true;
                uxFolder_Label.Text = "File:";
                uxFolder_TextBox.Text = "<Rapid Fire: No physical objects used>";
            }
        }

        private void uxSubmitSingle_Button_Click (object sender, EventArgs e)
        {
            int repeat = (int)uxAmountSingle_NumUpDown.Value;
            string docid = uxDocID_TextBox.Text;
            if (uxSingle_RadioButton.Checked == true && uxFile_RadioButton.Checked == true)
            {
                control.SingleDocSingleFile(docid, repeat);
                //MessageBox.Show("Pages added to the document: " + docid);
            }
            else if (uxSingle_RadioButton.Checked == true && uxFolder_RadioButton.Checked == true)
            {
                control.SingleDocMultiFile(docid);
                //MessageBox.Show("Pages added to the document: " + docid);
            }
            else if (uxSingle_RadioButton.Checked == true && uxRapidFire_RadioButton.Checked == true)
            {
                control.SingleDocRapidFire(docid, repeat);
                //MessageBox.Show("Fake pages added to the document: " + docid);
            }
        }

        private void uxFileBrowse_Button_Click (object sender, EventArgs e)
        {
            if (uxFolder_RadioButton.Checked == true)
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
            else if (uxFile_RadioButton.Checked == true || uxRapidFire_RadioButton.Checked == true)
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

        private void MainForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("You clicked the help button");
        }
    }
}
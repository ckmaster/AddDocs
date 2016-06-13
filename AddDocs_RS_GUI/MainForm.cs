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
        public MainForm ()
        {
            InitializeComponent();
        }
        //end MainForm

        public Controller control = new Controller();

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
        //end uxSubmit_Button_Click

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
        //end ClearUI

        private void uxHelp_MenuItem_Click (object sender, EventArgs e)
        {
            MessageBox.Show("corey.kidd@lexmark.com");
        }

        private void uxServerInfo_MenuItem_Click (object sender, EventArgs e)
        {
            ServerInfo form = new ServerInfo();
            form.Show();
        }

        private void fileDirectoryToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                control.fileLocation = path;
                LocalOp local = new LocalOp();
                local.SaveFileConfig(path);
                MessageBox.Show("Default upload directory has been updated");
            }
        }
    }
}
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
            this.uxDrawer_TextBox.Text = "Default";
            this.uxDocType_TextBox.Text = "Default";
        }
        //end MainForm

        private void uxSubmit_Button_Click (object sender, EventArgs e)
        {
            RestCall rest = new RestCall();
            string hash = rest.GetSessionHash();
            string[] files = Directory.GetFiles("C:\\Import");
            foreach (string file in files)
            {
                string n = "";
                string d = uxDrawer_TextBox.Text;
                string f1 = Path.GetFileName(file);
                string f2 = uxField2_TextBox.Text;
                string f3 = uxField3_TextBox.Text;
                string f4 = uxField4_TextBox.Text;
                string f5 = uxField5_TextBox.Text;
                string dt = uxDocType_TextBox.Text;
                INOW_Doc doc = new INOW_Doc(n, d, f1, f2, f3, f4, f5, dt);

                string docid = rest.PostDoc(doc, hash);
                rest.PostDocPage(docid, file, hash);
            }
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
            this.uxField4_TextBox.Clear();
            this.uxField5_TextBox.Clear();
            this.uxDocType_TextBox.Text = "Default";
        }
        //end ClearUI
    }
}
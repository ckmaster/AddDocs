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
    public partial class ServerInfo : Form
    {

        Controller control;
        Config conf;

        public ServerInfo (Controller c)
        {
            InitializeComponent();
            control = c;
            conf = control.conf;
        }

        private void ServerInfo_Load (object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            uxUrl_TextBox.Text = conf.intServer.uri;
            uxUsername_TextBox.Text = conf.intServer.username;
            uxPassword_Textbox.Text = conf.intServer.password;
        }

        private void uxSubmit_Button_Click (object sender, EventArgs e)
        {
            if (!(uxUrl_TextBox.Text.Trim().Equals(conf.intServer.uri)) ||
               !(uxUsername_TextBox.Text.Trim().Equals(conf.intServer.username)) ||
               !(uxPassword_Textbox.Text.Trim().Equals(conf.intServer.password)))
            {
                MessageBox.Show("Change in settings detected, making adjustments now.");
                conf.intServer.uri = uxUrl_TextBox.Text.Trim();
                conf.intServer.username = uxUsername_TextBox.Text.Trim();
                conf.intServer.password = uxPassword_Textbox.Text.Trim();
                LocalOp local = new LocalOp();
                local.SaveConfig(conf); 
            }
            else
            {
                MessageBox.Show("No changes have been made.");
            }
            this.Close();
        }
    }
}
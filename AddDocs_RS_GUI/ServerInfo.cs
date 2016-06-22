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
        public ServerInfo ()
        {
            InitializeComponent();
        }

        IntegrationServer intServer = new IntegrationServer();

        private void ServerInfo_Load (object sender, EventArgs e)
        {
            InputOutput local = new InputOutput();
            intServer = local.LoadServerConfig();
            uxServer_TextBox.Text = intServer.server;
            uxPort_TextBox.Text = intServer.port;
            uxUsername_TextBox.Text = intServer.username;
            uxPassword_Textbox.Text = intServer.password;
        }

        private void uxSubmit_Button_Click (object sender, EventArgs e)
        {
            if (!(uxServer_TextBox.Text.Trim().Equals(intServer.server)) ||
               !(uxPort_TextBox.Text.Trim().Equals(intServer.port)) ||
               !(uxUsername_TextBox.Text.Trim().Equals(intServer.username)) ||
               !(uxPassword_Textbox.Text.Trim().Equals(intServer.password)))
            {
                MessageBox.Show("Change in settings detected, making adjustments now");
                using (StreamWriter sw = new StreamWriter(".\\server.txt", false))
                {
                    sw.WriteLine("SERVER: " + uxServer_TextBox.Text.Trim());
                    sw.WriteLine("PORT: " + uxPort_TextBox.Text.Trim());
                    sw.WriteLine("USERNAME: " + uxUsername_TextBox.Text.Trim());
                    sw.WriteLine("PASSWORD: " + uxPassword_Textbox.Text.Trim());
                }    
            }
            else
            {
                MessageBox.Show("No changes were made to server configuration");
            }
            this.Close();
        }
    }
}
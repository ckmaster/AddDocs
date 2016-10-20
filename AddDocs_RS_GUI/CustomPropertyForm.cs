using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddDocs_RS_GUI
{
    public partial class CustomPropertyForm : Form
    {
        public CustomPropertyForm ()
        {
            InitializeComponent();
        }

        private void CustomPropertyForm_Load (object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            
        }
    }
}

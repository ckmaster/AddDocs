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
        string docTypeID = "";
        public CustomPropertyForm (string d)
        {
            InitializeComponent();
            docTypeID = d;
        }

        private void CustomPropertyForm_Load (object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            Controller control = new Controller();
            CustPropRoot customProps = control.GetCustProps(docTypeID);
            foreach (CustPropInfo c in customProps.properties)
            {
                uxCustomProperty_DataGrid.Rows.Add(c.name);
            }
        }
    }
}

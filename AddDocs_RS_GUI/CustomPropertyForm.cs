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
        public Controller controller;
        CustPropRoot customProps;
        List<List<string>> returnList = new List<List<string>>();

        public CustomPropertyForm (string d, Controller c)
        {
            InitializeComponent();
            docTypeID = d;
            controller = c;
        }

        private void CustomPropertyForm_Load (object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            customProps = controller.GetCustProps(docTypeID);
            foreach (CustPropInfo c in customProps.properties)
            {
                uxCustomProperty_DataGrid.Rows.Add(c.name);
            }
        }

        public List<List<string>> values
        {
            get { return returnList; }
        }

        private void uxSubmit_Button_Click (object sender, EventArgs e)
        {
            for (int i = 0; i < customProps.properties.Count; i++)
            {
                if (uxCustomProperty_DataGrid.Rows[i].Cells[1].Value != null)
                {
                    List<string> temp = new List<string>();
                    temp.Add(uxCustomProperty_DataGrid.Rows[i].Cells[0].Value.ToString());
                    temp.Add(uxCustomProperty_DataGrid.Rows[i].Cells[1].Value.ToString());
                    returnList.Add(temp);
                }
            }
        }
    }
}

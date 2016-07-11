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
    public partial class Help : Form
    {
        public Help ()
        {
            InitializeComponent();
            string readme = 
@"This program works by making POST Document calls to Integration Server.
Your Integration Server and ImageNow Server must be running when you attempt to use this program.  However the ImageNow Client is not a requirement.
The credentials set in the Config menu must be a user that has capture permissions for the Drawer/ Doc Type you intend to use.
If you could not login to ImageNow Client and capture with that user then it will not work with this program.

Regarding the UI:
- Begin by selecting the ImageNow Mode from the top left radio buttons
	        - Multi means a new document will be created for each file/ times to add increment
	        - Single will be used to add pages into a currently existing docment
- Next you select the file mode that fits your needs
            - Folder will use all files in a folder on Windows
		                - If subfolder is selected it will also recursively grab files from subfolder
	        - File will repeatedly add a single file specified by the user
	        - Rapid fire behaves differently depending on the ImageNow mode
		                - Multi: Will create multiple zero page documents
		                - Single: Will add zero kb files to a document (basically corrupt files)
- If using folder or file modes then check the textbox to make sure the program is pointed at the proper location
	        - If not then click  the ""..."" box to browse to the proper location/ file
- Times to add specifies the amount of times an operation should be repeated
            -i.e.If there are 10 files in a directory and times to add = 2 then 20 files will be added
-For Multi Doc ImageNow mode F1, F2, and F3 are currently user entry
            - F4 is filename and F5 is a guid(unique id)
            - There will be further options for indexing in the future
- For Single Doc ImageNow mode all you need to know is the Doc ID you wish to add to
- The progress bar will update each time a file has been posted into ImageNow
            - This means if only one file has been added then the progress bar will fill all at once";
            uxLabel.Text = readme;
        }

    }
}

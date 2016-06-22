using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDocs_RS_GUI
{
    public class ImageNowDoc
    {
        public string name { get; set; }
        public string drawer { get; set; }
        public string field1 { get; set; }
        public string field2 { get; set; }
        public string field3 { get; set; }
        public string field4 { get; set; }
        public string field5 { get; set; }
        public string docType { get; set; }

        public ImageNowDoc(string n, string d, string f1, string f2, string f3, string f4, string f5, string dt)
        {
            name = n;
            drawer = d;
            field1 = f1;
            field2 = f2;
            field3 = f3;
            field4 = f4;
            field5 = f5;
            docType = dt;
        }

        public string CreatePostDocXML()
        {
            string xmlBody = 
            "<document>" +
                "<info>" +
		            "<name>" + name + "</name>" +
		            "<locationId></locationId>" +
		                "<keys>" +
			                "<drawer>" + drawer + "</drawer>" +
			                "<field1>" + field1 + "</field1>" +
			                "<field2>" + field2 + "</field2>" +
			                "<field3>" + field3 + "</field3>" +
			                "<field4>" + field4 + "</field4>" +
			                "<field5>" + field5 + "</field5>" +
			                "<documentType>" + docType + "</documentType>" +
		                 "</keys>" + 
	            "</info>" +
            "</document>";
            return xmlBody;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDocs_RS_GUI
{
    public class DocTypeRoot
    {
        public List<DocTypeInfo> documentTypes { get; set; } = new List<DocTypeInfo>();
    }

    public class DocTypeInfo
    {
        public string name { get; set; }
        public string id { get; set; }
        public string description { get; set; }
    }
}

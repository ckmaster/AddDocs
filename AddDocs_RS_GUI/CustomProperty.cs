using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDocs_RS_GUI
{
    public class CustPropRoot
    {
        public string name { get; set; }
        public string id { get; set; }
        public string description { get; set; }
        public string formId { get; set; }
        public List<CustPropInfo> properties { get; set; } = new List<CustPropInfo>();
    }

    public class CustPropInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string userGroupId { get; set; }
        public string userGroupName { get; set; }
        public string defaultValue { get; set; }
        public string listValueCandidates { get; set; }
        public string userList { get; set; }
        public string children { get; set; }
        public List<string> formats { get; set; }
        public bool required { get; set; }
    }
}

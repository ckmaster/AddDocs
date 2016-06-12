using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDocs_RS_GUI
{
    public class Controller
    {
        public IS_Info intServer = new IS_Info();

        public void Initialize()
        {
            LocalOp local = new LocalOp();
            intServer = local.LoadConfig();
            intServer.sessionHash = new GetConnection().ExecuteCall();
        }

        public void PostDoc(INOW_Doc doc, string file)
        {
            PostDoc postdoc = new PostDoc();
            string docid = postdoc.ExecuteCall(doc, intServer.sessionHash, intServer.server, intServer.port, intServer.username, intServer.password);
            PostDocPage postdocpage = new PostDocPage();
            postdocpage.ExecuteCall(intServer.sessionHash, intServer.server, intServer.port, intServer.username, intServer.password, docid, file);
        }
    }
}

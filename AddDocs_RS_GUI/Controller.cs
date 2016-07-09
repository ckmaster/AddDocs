using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AddDocs_RS_GUI
{
    public class Controller
    {
        public Config conf;

        public void Initialize()
        {
            conf = new LocalOp().LoadConfig();
            if (conf == null)
            {
                MessageBox.Show("Failed to load config file");
            }
        }

        public string GetShortFileName(string filename)
        {
            string tempFilename = Path.GetFileName(filename);
            if (tempFilename.Length > 40)
            {
                tempFilename = tempFilename.Substring(0, 39);
            }
            return tempFilename;
        }

        public void MultiDocMultiFile(string d, string f1, string f2, string f3, string f4, string f5, string dt)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            string[] files = Directory.GetFiles(conf.folderPath);
            foreach(string s in files)
            {
                string shortFilename = GetShortFileName(s);
                string longFilename = Path.GetFileName(s);
                ImageNowDoc doc = new ImageNowDoc("", d, f1, f2, f3, shortFilename, Guid.NewGuid().ToString(), dt);
                string docid = rest.PostDoc(doc);
                if (docid != null)
                {
                    byte[] fileBytes = File.ReadAllBytes(s);
                    rest.PostDocPage(docid, fileBytes, longFilename);
                }
            }
            rest.DeleteConnection();
        }
        
        public void MultiDocSingleFile(string d, string f1, string f2, string f3, string f4, string f5, string dt, int repeat)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            string shortFilename = GetShortFileName(conf.filePath);
            string longFilename = Path.GetFileName(conf.filePath);
            byte[] fileBytes = File.ReadAllBytes(conf.filePath);
            for (int i = 0; i < repeat; i++)
            {   
                ImageNowDoc doc = new ImageNowDoc("", d, f1, f2, f3, shortFilename, Guid.NewGuid().ToString(), dt);
                string docid = rest.PostDoc(doc);
                if (docid != null)
                {
                    rest.PostDocPage(docid, fileBytes, longFilename);
                }
            }
            rest.DeleteConnection();
        }

        public void MultiDocRapidFire (string d, string f1, string f2, string f3, string f4, string f5, string dt, int repeat)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            for (int i = 0; i < repeat; i ++)
            {
                ImageNowDoc doc = new ImageNowDoc("", d, f1, f2, f3, f4, Guid.NewGuid().ToString(), dt);
                rest.PostDoc(doc);
            }
            rest.DeleteConnection();
        }

        public void SingleDocSingleFile (string docid, int repeat)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            string filename = Path.GetFileName(conf.filePath);
            byte[] fileBytes = File.ReadAllBytes(conf.filePath);
            for (int i = 0; i < repeat; i++)
            {
                rest.PostDocPage(docid, fileBytes, filename);
            }
            rest.DeleteConnection();
        }

        public void SingleDocRapidFire (string docid, int repeat)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            for (int i = 0; i < repeat; i++)
            {
                rest.PostDocPage(docid, null, "placeholder.tif");
            }
            rest.DeleteConnection();
        }

        public void SingleDocMultiFile(string docid)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            string[] files = Directory.GetFiles(conf.folderPath);
            foreach(string s in files)
            {
                string filename = Path.GetFileName(s);
                byte[] fileBytes = File.ReadAllBytes(s);
                rest.PostDocPage(docid, fileBytes, filename);
            }
            rest.DeleteConnection();
        }
    }                      
}                       
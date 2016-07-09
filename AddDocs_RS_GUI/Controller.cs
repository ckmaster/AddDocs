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
                MessageBox.Show("Failed to load config file.");
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
            if (conf.intServer.sessionHash.Length != 41)
            {
                MessageBox.Show($"Failed to get connection.\r\n{conf.intServer.sessionHash}");
                return;
            }

            string[] files = Directory.GetFiles(conf.folderPath);
            foreach(string s in files)
            {
                string shortFilename = GetShortFileName(s);
                string longFilename = Path.GetFileName(s);
                ImageNowDoc doc = new ImageNowDoc("", d, f1, f2, f3, shortFilename, Guid.NewGuid().ToString(), dt);
                string docid = rest.PostDoc(doc);
                if (docid.Length != 23)
                {
                    MessageBox.Show($"Failed to create document.\r\n{docid}");
                    return;
                }
                else
                {
                    byte[] fileBytes = File.ReadAllBytes(s);
                    string responseContent1 = rest.PostDocPage(docid, fileBytes, longFilename);
                    if (!responseContent1.Equals("success"))
                    {
                        MessageBox.Show($"Failed to add page to document.\r\n{responseContent1}");
                        return;
                    }
                }
            }
            string responseContent2 = rest.DeleteConnection();
            if (!responseContent2.Equals("success"))
            {
                MessageBox.Show($"Failed to clear sessions.\r\nNo reason to be alarmed, by default they will clear themselves in one hour.\r\n{responseContent2}");
            }
        }
        
        public void MultiDocSingleFile(string d, string f1, string f2, string f3, string f4, string f5, string dt, int repeat)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            if (conf.intServer.sessionHash.Length != 41)
            {
                MessageBox.Show($"Failed to get connection.\r\n{conf.intServer.sessionHash}");
                return;
            }

            string shortFilename = GetShortFileName(conf.filePath);
            string longFilename = Path.GetFileName(conf.filePath);
            byte[] fileBytes = File.ReadAllBytes(conf.filePath);
            for (int i = 0; i < repeat; i++)
            {   
                ImageNowDoc doc = new ImageNowDoc("", d, f1, f2, f3, shortFilename, Guid.NewGuid().ToString(), dt);
                string docid = rest.PostDoc(doc);
                if (docid.Length != 23)
                {
                    MessageBox.Show($"Failed to create document.\r\n{docid}");
                    return;
                }
                else
                {
                    string responseContent1 = rest.PostDocPage(docid, fileBytes, longFilename);
                    if (!responseContent1.Equals("success"))
                    {
                        MessageBox.Show($"Failed to add page to document.\r\n{responseContent1}");
                        return;
                    }
                }
            }
            string responseContent2 = rest.DeleteConnection();
            if (!responseContent2.Equals("success"))
            {
                MessageBox.Show($"Failed to clear sessions.\r\nNo reason to be alarmed, by default the sessions will clear in one hour.\r\n{responseContent2}");
            }
        }

        public void MultiDocRapidFire (string d, string f1, string f2, string f3, string f4, string f5, string dt, int repeat)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            if (conf.intServer.sessionHash.Length != 41)
            {
                MessageBox.Show($"Failed to get connection.\r\n{conf.intServer.sessionHash}");
                return;
            }

            for (int i = 0; i < repeat; i ++)
            {
                ImageNowDoc doc = new ImageNowDoc("", d, f1, f2, f3, f4, Guid.NewGuid().ToString(), dt);
                string docid = rest.PostDoc(doc);
                if (docid.Length != 23)
                {
                    MessageBox.Show($"Failed to create document.\r\n{docid}");
                    return;
                }
            }
            string responseContent2 = rest.DeleteConnection();
            if (!responseContent2.Equals("success"))
            {
                MessageBox.Show($"Failed to clear sessions.\r\nNo reason to be alarmed, by default the sessions will clear in one hour.\r\n{responseContent2}");
            }
        }

        public void SingleDocSingleFile (string docid, int repeat)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            if (conf.intServer.sessionHash.Length != 41)
            {
                MessageBox.Show($"Failed to get connection.\r\n{conf.intServer.sessionHash}");
                return;
            }

            string filename = Path.GetFileName(conf.filePath);
            byte[] fileBytes = File.ReadAllBytes(conf.filePath);
            for (int i = 0; i < repeat; i++)
            {
                string responseContent1 = rest.PostDocPage(docid, fileBytes, filename);
                if (!responseContent1.Equals("success"))
                {
                    MessageBox.Show($"Failed to add page to document.\r\n{responseContent1}");
                    return;
                }
            }
            string responseContent2 = rest.DeleteConnection();
            if (!responseContent2.Equals("success"))
            {
                MessageBox.Show($"Failed to clear sessions.\r\nNo reason to be alarmed, by default the sessions will clear in one hour.\r\n{responseContent2}");
            }
        }

        public void SingleDocRapidFire (string docid, int repeat)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            if (conf.intServer.sessionHash.Length != 41)
            {
                MessageBox.Show($"Failed to get connection.\r\n{conf.intServer.sessionHash}");
                return;
            }

            for (int i = 0; i < repeat; i++)
            {
                string responseContent1 = rest.PostDocPage(docid, null, "placeholder.tif");
                if (!responseContent1.Equals("success"))
                {
                    MessageBox.Show($"Failed to add page to document.\r\n{responseContent1}");
                    return;
                }
            }
            string responseContent2 = rest.DeleteConnection();
            if (!responseContent2.Equals("success"))
            {
                MessageBox.Show($"Failed to clear sessions.\r\nNo reason to be alarmed, by default the sessions will clear in one hour.\r\n{responseContent2}");
            }
        }

        public void SingleDocMultiFile(string docid)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            if (conf.intServer.sessionHash.Length != 41)
            {
                MessageBox.Show($"Failed to get connection.\r\n{conf.intServer.sessionHash}");
                return;
            }

            string[] files = Directory.GetFiles(conf.folderPath);
            foreach(string s in files)
            {
                string filename = Path.GetFileName(s);
                byte[] fileBytes = File.ReadAllBytes(s);
                string responseContent1 = rest.PostDocPage(docid, fileBytes, filename);
                if (!responseContent1.Equals("success"))
                {
                    MessageBox.Show($"Failed to add page to document.\r\n{responseContent1}");
                    return;
                }
            }
            string responseContent2 = rest.DeleteConnection();
            if (!responseContent2.Equals("success"))
            {
                MessageBox.Show($"Failed to clear sessions.\r\nNo reason to be alarmed, by default the sessions will clear in one hour.\r\n{responseContent2}");
            }
        }
    }                      
}                       
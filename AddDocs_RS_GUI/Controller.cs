using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace AddDocs_RS_GUI
{
    public class Controller
    {
        public Config conf;

        public void Initialize()
        {
            LocalOp local = new LocalOp();
            conf = local.LoadConfig();
            if (conf == null)
            {
                MessageBox.Show("New config will now be created.", "Failed to find config file.");
                local.DefaultConfig();
                conf = local.LoadConfig();
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

        public void MultiDocMultiFile(string n, string l, string d, string f1, string f2, string f3, string f4, string f5, string dt, int repeat, bool recursive, string queueid, BackgroundWorker bw)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            if (conf.intServer.sessionHash.Length != 41)
            {
                MessageBox.Show($"Failed to get connection.\r\n{conf.intServer.sessionHash}");
                return;
            }

            string[] files;
            if (recursive)
            {
                files = Directory.GetFiles(conf.folderPath, "*", SearchOption.AllDirectories);
            }
            else
            {
                files = Directory.GetFiles(conf.folderPath);
            }

            decimal total = files.Length * repeat;
            decimal count = 0;
            for (int i = 0; i < repeat; i++)
            {
                foreach(string s in files)
                {
                    string shortFilename = GetShortFileName(s);
                    string longFilename = Path.GetFileName(s);
                    ImageNowDoc doc;
                    if (d.Contains("Folder"))
                    {
                        doc = new ImageNowDoc(Guid.NewGuid().ToString(), l, d, f1, f2, f3, shortFilename, Guid.NewGuid().ToString(), dt);
                    }
                    else
                    {
                        doc = new ImageNowDoc(n, l, d, f1, f2, f3, shortFilename, Guid.NewGuid().ToString(), dt);
                    }
                    
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

                    string queueResponse = "";
                    if (!string.IsNullOrEmpty(queueid))
                    {
                        queueResponse = rest.RouteDoc(docid, queueid);
                    }

                    if (!queueResponse.Equals("success"))
                    {
                        MessageBox.Show($"Failed to route document.\r\n{queueResponse}");
                    }

                    count++;
                    bw.ReportProgress((int)((count/total)*100));
                }
            }
            string responseContent2 = rest.DeleteConnection();
            if (!responseContent2.Equals("success"))
            {
                MessageBox.Show($"Failed to clear sessions.\r\nNo reason to be alarmed, by default they will clear themselves in one hour.\r\n{responseContent2}");
            }
            MessageBox.Show("Documents created and pages added.");
        }
        
        public void MultiDocSingleFile(string n, string l, string d, string f1, string f2, string f3, string f4, string f5, string dt, int repeat, string queueid, BackgroundWorker bw)
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
            
            decimal count = 0;
            for (int i = 0; i < repeat; i++)
            {
                ImageNowDoc doc;
                if (d.Contains("Folder"))
                {
                    doc = new ImageNowDoc(Guid.NewGuid().ToString(), l, d, f1, f2, f3, shortFilename, Guid.NewGuid().ToString(), dt);
                }
                else
                {
                    doc = new ImageNowDoc(n, l, d, f1, f2, f3, shortFilename, Guid.NewGuid().ToString(), dt);
                }

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

                string queueResponse = "";
                if (!string.IsNullOrEmpty(queueid))
                {
                    queueResponse = rest.RouteDoc(docid, queueid);
                }

                if (!queueResponse.Equals("success"))
                {
                    MessageBox.Show($"Failed to route document.\r\n{queueResponse}");
                }

                count++;
                bw.ReportProgress((int)((count / repeat) * 100));
            }
            string responseContent2 = rest.DeleteConnection();
            if (!responseContent2.Equals("success"))
            {
                MessageBox.Show($"Failed to clear sessions.\r\nNo reason to be alarmed, by default the sessions will clear in one hour.\r\n{responseContent2}");
            }
            MessageBox.Show("Documents created and pages added.");
        }

        public void MultiDocRapidFire (string n, string l, string d, string f1, string f2, string f3, string f4, string f5, string dt, int repeat, string queueid, BackgroundWorker bw)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            if (conf.intServer.sessionHash.Length != 41)
            {
                MessageBox.Show($"Failed to get connection.\r\n{conf.intServer.sessionHash}");
                return;
            }

            decimal count = 0;
            for (int i = 0; i < repeat; i ++)
            {
                ImageNowDoc doc;
                if (d.Contains("Folder"))
                {
                    doc = new ImageNowDoc(Guid.NewGuid().ToString(), l, d, f1, f2, f3, f4, Guid.NewGuid().ToString(), dt);
                }
                else
                {
                    doc = new ImageNowDoc(n, l, d, f1, f2, f3, f4, Guid.NewGuid().ToString(), dt);
                }

                string docid = rest.PostDoc(doc);
                if (docid.Length != 23)
                {
                    MessageBox.Show($"Failed to create document.\r\n{docid}");
                    return;
                }

                string queueResponse = "";
                if (!string.IsNullOrEmpty(queueid))
                {
                    queueResponse = rest.RouteDoc(docid, queueid);
                }

                if (!queueResponse.Equals("success"))
                {
                    MessageBox.Show($"Failed to route document.\r\n{queueResponse}");
                }

                count++;
                bw.ReportProgress((int)((count / repeat) * 100));
            }
            string responseContent2 = rest.DeleteConnection();
            if (!responseContent2.Equals("success"))
            {
                MessageBox.Show($"Failed to clear sessions.\r\nNo reason to be alarmed, by default the sessions will clear in one hour.\r\n{responseContent2}");
            }
            MessageBox.Show("Documents created.");
        }

        public void SingleDocSingleFile (string docid, int repeat, BackgroundWorker bw)
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
            decimal count = 0;
            for (int i = 0; i < repeat; i++)
            {
                string responseContent1 = rest.PostDocPage(docid, fileBytes, filename);
                if (!responseContent1.Equals("success"))
                {
                    MessageBox.Show($"Failed to add page to document.\r\n{responseContent1}");
                    return;
                }
                count++;
                bw.ReportProgress((int)((count / repeat) * 100));
            }
            string responseContent2 = rest.DeleteConnection();
            if (!responseContent2.Equals("success"))
            {
                MessageBox.Show($"Failed to clear sessions.\r\nNo reason to be alarmed, by default the sessions will clear in one hour.\r\n{responseContent2}");
            }
            MessageBox.Show($"Pages added to document: {docid}.");
        }

        public void SingleDocRapidFire (string docid, int repeat, BackgroundWorker bw)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            if (conf.intServer.sessionHash.Length != 41)
            {
                MessageBox.Show($"Failed to get connection.\r\n{conf.intServer.sessionHash}");
                return;
            }

            decimal count = 0;
            for (int i = 0; i < repeat; i++)
            {
                string responseContent1 = rest.PostDocPage(docid, null, "placeholder.tif");
                if (!responseContent1.Equals("success"))
                {
                    MessageBox.Show($"Failed to add page to document.\r\n{responseContent1}");
                    return;
                }
                count++;
                bw.ReportProgress((int)((count / repeat) * 100));
            }
            string responseContent2 = rest.DeleteConnection();
            if (!responseContent2.Equals("success"))
            {
                MessageBox.Show($"Failed to clear sessions.\r\nNo reason to be alarmed, by default the sessions will clear in one hour.\r\n{responseContent2}");
            }
            MessageBox.Show($"Fake pages added to document: {docid}.");
        }

        public void SingleDocMultiFile(string docid, int repeat, bool recursive, BackgroundWorker bw)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            if (conf.intServer.sessionHash.Length != 41)
            {
                MessageBox.Show($"Failed to get connection.\r\n{conf.intServer.sessionHash}");
                return;
            }

            string[] files;
            if (recursive)
            {
                files = Directory.GetFiles(conf.folderPath, "*", SearchOption.AllDirectories);
            }
            else
            {
                files = Directory.GetFiles(conf.folderPath);
            }

            decimal total = files.Length * repeat;
            decimal count = 0;
            for (int i = 0; i < repeat; i ++)
            {
                foreach (string s in files)
                {
                    string filename = Path.GetFileName(s);
                    byte[] fileBytes = File.ReadAllBytes(s);
                    string responseContent1 = rest.PostDocPage(docid, fileBytes, filename);
                    if (!responseContent1.Equals("success"))
                    {
                        MessageBox.Show($"Failed to add page to document.\r\n{responseContent1}");
                        return;
                    }
                    count++;
                    bw.ReportProgress((int)((count / total) * 100));
                }
            }
            
            string responseContent2 = rest.DeleteConnection();
            if (!responseContent2.Equals("success"))
            {
                MessageBox.Show($"Failed to clear sessions.\r\nNo reason to be alarmed, by default the sessions will clear in one hour.\r\n{responseContent2}");
            }
            MessageBox.Show($"Pages added to document: {docid}.");
        }

        public DrawerRoot GetDrawers()
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            if (conf.intServer.sessionHash.Length != 41)
            {
                MessageBox.Show($"Failed to get connection.\r\n{conf.intServer.sessionHash}");
                return null;
            }
            DrawerRoot drawers = rest.GetDrawers();
            string responseContent2 = rest.DeleteConnection();
            if (!responseContent2.Equals("success"))
            {
                MessageBox.Show($"Failed to clear sessions.\r\nNo reason to be alarmed, by default the sessions will clear in one hour.\r\n{responseContent2}");
            }
            return drawers;  
        }

        public DocTypeRoot GetDocTypes()
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            if (conf.intServer.sessionHash.Length != 41)
            {
                MessageBox.Show($"Failed to get connection.\r\n{conf.intServer.sessionHash}");
                return null;
            }
            DocTypeRoot docTypes = rest.GetDocType();
            return docTypes;
        }

        public CustPropRoot GetCustProps(string docTypeID)
        {
            RestCall rest = new RestCall(conf);
            conf.intServer.sessionHash = rest.GetConnection();
            if (conf.intServer.sessionHash.Length != 41)
            {
                MessageBox.Show($"Failed to get connection.\r\n{conf.intServer.sessionHash}");
                return null;
            }
            CustPropRoot temp = rest.GetCustProps(docTypeID);
            return temp;
        }
    }
}
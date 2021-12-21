using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace CopyTextContents
{
    class ArgsParser
    {
        public static List<string> lsSelectedFiles = new List<string>();

        public static bool OpenMainAppSelected = false;
        public static bool ParseArgs(string[] args)
        {
            OpenMainAppSelected = false;

            /*
            string sa = "";
            for (int k = 0; k < args.Length; k++)
            {
                sa += args[k] + " ";
            }

            MessageBox.Show(sa);
            */

            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                frmSettings fs = new frmSettings();
                fs.ShowDialog();
                return true;
            }
            else if (args.Length > 0)
            {
                try
                {
                    if (args[0].ToLower().StartsWith("-tempfile:"))
                    {
                        string tempfile = GetParameter(args[0]);

                        //MessageBox.Show(tempfile);

                        using (StreamReader sr = new StreamReader(tempfile, Encoding.Unicode))
                        {
                            string scont = sr.ReadToEnd();

                            //args = scont.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                            args = SplitArguments(scont);
                            Module.args = args;

                            //MessageBox.Show(scont);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Module.ShowError("Error could not parse Arguments !", ex);
                    return false;
                }

                /*
                string sa = "";
                for (int k = 0; k < args.Length; k++)
                {
                    sa += args[k] + "|";
                }

                MessageBox.Show(sa);
                  */

                


                RegistryKey reg = Registry.CurrentUser;

                RegistryKey reg2 = reg.OpenSubKey(@"Software\4dots Software", true);

                if (reg2 == null)
                {
                    reg2 = reg.CreateSubKey(@"Software\4dots Software");
                }

                reg = reg2;
                reg2 = reg.OpenSubKey("CopyTextContents", true);

                if (reg2 == null)
                {
                    reg2 = reg.CreateSubKey("CopyTextContents");
                }

                reg = reg2;

                
                bool bHeader = bool.Parse(reg.GetValue("Add File Header", "False").ToString());
                bool bSubFolders = bool.Parse(reg.GetValue("Copy Subfolder Files", "False").ToString());
                string SelectedEncoding = reg.GetValue("Encoding", "").ToString();

                for (int k = 0; k < args.Length; k++)
                {
                    if (System.IO.File.Exists(args[k]))
                    {
                        lsSelectedFiles.Add(args[k]);
                    }
                    else if (System.IO.Directory.Exists(args[k]))
                    {
                        SearchOption so=SearchOption.TopDirectoryOnly;

                        if (bSubFolders)
                        {
                            so=SearchOption.AllDirectories;
                        }

                        string[] filez = System.IO.Directory.GetFiles(args[k], "*.*", so);

                        for (int m = 0; m < filez.Length; m++)
                        {
                            lsSelectedFiles.Add(filez[m]);
                        }
                    }
                }

                Clipboard.Clear();

                for (int k = 0; k < args.Length; k++)
                {
                    try
                    {
                        string arg = args[k];

                        if (arg == "-CopyTextContents")
                        {
                            string txt = "";                                                                                   

                            for (int m = 0; m < lsSelectedFiles.Count; m++)
                            {

                                string header = "// ---------------------------------------------------\r\n" +
                                    "\r\n" +
                                    "File : " + lsSelectedFiles[m]
                                + "\r\n\r\n" +
                                "// ---------------------------------------------------\r\n";

                                using (StreamReader sr = new StreamReader(lsSelectedFiles[m], Encoding.Default,true))
                                {
                                    string scont = sr.ReadToEnd();

                                    if (m != 0)
                                    {
                                        txt += "\r\n";
                                    }
                                    
                                    if (bHeader)
                                    {
                                        txt += header;
                                    }

                                    
                                    txt += scont;
                                    
                                }
                            }

                            Clipboard.SetText(txt);
                        }
                        else if (arg == "-CopyTextContentsEncoding")
                        {
                            string txt = "";

                            frmEncoding fe = new frmEncoding();
                            fe.SelectedEncoding = SelectedEncoding;

                            System.Text.Encoding enc = Encoding.Default;

                            if (fe.ShowDialog() == DialogResult.OK)
                            {
                                enc=System.Text.Encoding.GetEncoding(fe.SelectedEncoding);
                            }
                            
                            for (int m = 0; m < lsSelectedFiles.Count; m++)
                            {

                                string header = "// ---------------------------------------------------\r\n" +
                                    "\r\n" +
                                    "File : "+lsSelectedFiles[m]
                                +"\r\n\r\n" +
                                "// ---------------------------------------------------\r\n";

                                using (StreamReader sr = new StreamReader(lsSelectedFiles[m], enc, false))
                                {
                                    string scont = sr.ReadToEnd();

                                    if (m != 0)
                                    {
                                        txt += "\r\n";
                                    }

                                    if (bHeader)
                                    {
                                        txt += header;
                                    }


                                    txt += scont;

                                }
                            }

                            Clipboard.SetText(txt);
                        }


                        else if (arg == "-Settings")
                        {
                            frmSettings fs = new frmSettings();
                            fs.ShowDialog();
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Module.ShowError("Error could not parse Arguments !", ex);
                    }
                    finally
                    {

                    }
                }
            }

            return true;
        }

        private static string GetParameter(string arg)
        {
            int spos = arg.IndexOf(":");
            if (spos == arg.Length - 1) return "";
            else
            {
                return arg.Substring(spos + 1);
            }
        }

        private static List<string> GetParameterValues(string arg)
        {
            string str = GetParameter(arg);

            string[] spl = str.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
            List<string> parval = new List<string>();

            for (int k = 0; k < spl.Length; k++)
            {
                parval.Add(spl[k]);
            }

            return parval;
        }               

        public static string[] SplitArguments(string commandLine)
    {
        char[] parmChars = commandLine.ToCharArray();
        bool inSingleQuote = false;
        bool inDoubleQuote = false;
        for (int index = 0; index < parmChars.Length; index++)
        {
            if (parmChars[index] == '"' && !inSingleQuote)
            {
                inDoubleQuote = !inDoubleQuote;
                parmChars[index] = '\n';
            }
            if (parmChars[index] == '\'' && !inDoubleQuote)
            {
                inSingleQuote = !inSingleQuote;
                parmChars[index] = '\n';
            }
            if (!inSingleQuote && !inDoubleQuote && parmChars[index] == ' ')
                parmChars[index] = '\n';
        }
        return (new string(parmChars)).Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
     }
    }
}

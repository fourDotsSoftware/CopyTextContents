using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CopyTextContents
{
    public partial class frmSettings : CopyTextContents.CustomForm
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser;

            RegistryKey reg2 = reg.OpenSubKey(@"Software\4dots Software",true);

            if (reg2 == null)
            {
                reg2=reg.CreateSubKey(@"Software\4dots Software");
            }

            reg=reg2;
            reg2 = reg.OpenSubKey("CopyTextContents", true);

            if (reg2==null)
            {
                reg2 = reg.CreateSubKey("CopyTextContents");
            }

            reg=reg2;

            chkHeader.Checked = bool.Parse(reg.GetValue("Add File Header", "False").ToString());
            chkSubFolders.Checked = bool.Parse(reg.GetValue("Copy Subfolder Files", "False").ToString());                      
            
            reg2 = reg.OpenSubKey("MenuItems", true);

            if (reg2 == null)
            {
                reg2 = reg.CreateSubKey("MenuItems");
            }

            reg = reg2;

            chkCopyTextContents.Checked = bool.Parse(reg.GetValue("Copy File Contents", "True").ToString());
            chkCopyTextContentsEncoding.Checked = bool.Parse(reg.GetValue("Copy File Contents with Encoding", "True").ToString());

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser;

            RegistryKey reg2 = reg.OpenSubKey(@"Software\4dots Software",true);

            if (reg2 == null)
            {
                reg2=reg.CreateSubKey(@"Software\4dots Software");
            }

            reg=reg2;
            reg2 = reg.OpenSubKey("CopyTextContents", true);

            if (reg2==null)
            {
                reg2 = reg.CreateSubKey("CopyTextContents");
            }

            reg=reg2;

            reg.SetValue("Add File Header", chkHeader.Checked.ToString());
            reg.SetValue("Copy Subfolder Files", chkSubFolders.Checked.ToString());

            reg2 = reg.OpenSubKey("MenuItems", true);

            if (reg2 == null)
            {
                reg2 = reg.CreateSubKey("MenuItems");
            }

            reg = reg2;

            reg.SetValue("Copy File Contents", chkCopyTextContents.Checked.ToString());
            reg.SetValue("Copy File Contents with Encoding", chkCopyTextContentsEncoding.Checked.ToString());

            
                        

            this.DialogResult = DialogResult.OK;
        }                

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}


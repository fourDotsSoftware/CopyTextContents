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
    public partial class frmEncoding : CopyTextContents.CustomForm
    {
        public frmEncoding()
        {
            InitializeComponent();
        }

        public string SelectedEncoding = "";
        private EncodingInfo[] encinfo = System.Text.Encoding.GetEncodings();

        private void frmEncoding_Load(object sender, EventArgs e)
        {           
            for (int k = 0; k < encinfo.Length; k++)
            {
                cmbEncoding.Items.Add(encinfo[k].CodePage+ " - "+encinfo[k].DisplayName);

                if (encinfo[k].Name == SelectedEncoding)
                {
                    cmbEncoding.SelectedIndex = k;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedEncoding = encinfo[cmbEncoding.SelectedIndex].Name;

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

            reg.SetValue("Encoding", SelectedEncoding);
            
            this.DialogResult = DialogResult.OK;
        }
    }
}


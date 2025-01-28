using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DirectoryFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] poleTypu = { "*.*", "*.jpg", "*.txt", "*.doc?", "*.xls?", "*.pdf", "*.gif", "*.stl"};
            cmbType.Items.AddRange(poleTypu);
            cmbType.SelectedIndex = 0;
            dlgFolder.SelectedPath = Directory.GetCurrentDirectory();
        }

        private void btnSelDir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgFolder.ShowDialog() == DialogResult.OK)
                {
                    Directory.SetCurrentDirectory(dlgFolder.SelectedPath);
                    lblDir.Text = Directory.GetCurrentDirectory();
                }
                cmbDir.Items.Clear();
                foreach (string item in Directory.EnumerateDirectories(dlgFolder.SelectedPath, "*.*", SearchOption.TopDirectoryOnly))
                {
                    cmbDir.Items.Add(item);
                }
                if (cmbDir.Items.Count > 0)
                {
                    cmbDir.SelectedIndex = 0;
                }
            }
            catch (Exception err)
            {
                lblDir.Text = err.Message;
            }
        }

        private void cmbDir_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

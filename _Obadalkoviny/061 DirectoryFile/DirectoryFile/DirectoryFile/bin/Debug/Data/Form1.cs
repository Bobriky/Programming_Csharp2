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

namespace MakeDir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblCurrentDir.Text = Directory.GetCurrentDirectory();
            readFolder();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Seznam3E.csv";
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    lstZaznam.Items.Clear();
                    StreamReader sbr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                    while (!sbr.EndOfStream)
                    {
                        lstZaznam.Items.Add(sbr.ReadLine().Replace(';', '_'));
                    }
                    sbr.Close();
                    vyberRecord();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message,"Chyba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void vyberRecord()
        {
            for (int i = 0; i < lstZaznam.Items.Count; i++)
            {
                lstZaznam.SetItemChecked(i, true);
            }
            lblItemsCount.Text = lstZaznam.CheckedIndices.Count.ToString() + "/" + lstZaznam.Items.Count.ToString(); 
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                Directory.SetCurrentDirectory(folderBrowserDialog1.SelectedPath);
            }
            lblCurrentDir.Text = Directory.GetCurrentDirectory();
            readFolder();
        }

        private void btnMakeDir_Click(object sender, EventArgs e)
        {
            DirectoryInfo fld = new DirectoryInfo(Directory.GetCurrentDirectory());
            try
            {
                foreach (var item in lstZaznam.CheckedItems)
                {
                    fld.CreateSubdirectory(item.ToString());
                }
                readFolder();
                MessageBox.Show("Vytvořeno " + lstZaznam.CheckedItems.Count.ToString() + " složek.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void readFolder()
        {
            List<string> slozky = new List<string>(Directory.EnumerateDirectories(Directory.GetCurrentDirectory()));
            lstFolder.Items.Clear();
            lstFolder.Items.AddRange(slozky.ToArray());
            lblFolderCount.Text = lstFolder.Items.Count.ToString();
        }

        private void ukončitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Opradu ukončit aplikaci?", "Konec", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                Close();
            }
        }

        private void btnClearDir_Click(object sender, EventArgs e)
        {
            if (lstFolder.SelectedIndices.Count > 0)
            {
                foreach (int item in lstFolder.SelectedIndices)
                {
                    DirectoryInfo fld = new DirectoryInfo(lstFolder.Items[item].ToString());
                    fld.Delete();
                }
            }
            readFolder();
        }

        private void lstZaznam_SelectedValueChanged(object sender, EventArgs e)
        {
            lblItemsCount.Text = lstZaznam.CheckedIndices.Count.ToString() + "/" + lstZaznam.Items.Count.ToString();
        }
    }
}

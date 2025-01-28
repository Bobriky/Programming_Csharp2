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
namespace DirectoryTestFromel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                lstSubfolders.Items.Clear();
                if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    Directory.SetCurrentDirectory(folderBrowserDialog.SelectedPath);
                    txtDirectory.Text = folderBrowserDialog.SelectedPath;

                    foreach (string item in Directory.EnumerateFileSystemEntries(folderBrowserDialog.SelectedPath, "*", SearchOption.TopDirectoryOnly))
                    {
                        FileInfo sqlsoubor = new FileInfo(item);
                        if(sqlsoubor.Extension == ".sql")
                        {
                            lstSubfolders.Items.Add(item);
                        }
                    }
                    statusLblCount.Text = lstSubfolders.Items.Count.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Něco špatně se stalo");
            }
        }

        private void lstSubfolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtInside.Clear();
                DirectoryInfo SQLdata = new DirectoryInfo(lstSubfolders.SelectedItem.ToString());

                StreamReader reader = new StreamReader(SQLdata.Name);
                txtInside.Text = reader.ReadToEnd();
            }
            catch (Exception)
            {

                MessageBox.Show("Něco se pokazilo");
            }
        }
    }
}

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
using System.IO.Ports;

namespace ArduinoSerial
{
    public partial class Form1 : Form
    {
        string myData;
        public Form1()
        {
            InitializeComponent();
            readCOM();
            cmbBaudRate.SelectedIndex = 5;
            cmbCOM.SelectedIndex = 0;
            btnConnect.BackColor = Color.Green;
        }

        private void readCOM()
        {
            cmbCOM.Items.Clear();
            cmbCOM.Items.AddRange(SerialPort.GetPortNames());
        }
        private void btnReadCOM_Click(object sender, EventArgs e)
        {
            readCOM();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.BackColor == Color.Green){
                myPort.PortName = cmbCOM.Text;
                myPort.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
                if (!myPort.IsOpen){
                    myPort.Open();
                    btnConnect.BackColor = Color.Red;
                    btnConnect.Text = "DISCONNECT";
                    cmbBaudRate.Enabled = cmbCOM.Enabled = btnReadCOM.Enabled = false;
                }
            }else if (btnConnect.BackColor == Color.Red){
                myPort.Close();
                btnConnect.BackColor = Color.Green;
                btnConnect.Text = "CONNECT";
                cmbBaudRate.Enabled = cmbCOM.Enabled = btnReadCOM.Enabled = true;
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            myPort.Write(txtSerialCmdInput.Text);
        }

        private void myPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            myData = myPort.ReadExisting().Trim();
            this.Invoke(new EventHandler(myWork));
        }

        private void myWork(object sender, EventArgs e)
        {
            try
            {
                txtSerialCmdOutput.Text = myData;
                txtNumbers.Text = myData;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
    }
}

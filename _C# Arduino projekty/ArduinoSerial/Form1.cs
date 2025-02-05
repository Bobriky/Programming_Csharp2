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
        int repeater = 0;
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
            myPort.Write(nmArduinoInput.Value.ToString());
        }

        private void myPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            myData = myPort.ReadExisting().Trim();
            for(int i = 0; i < repeater; i++) {
                this.Invoke(new EventHandler(myWork));
            }

        }
        private void myWork(object sender, EventArgs e)
        {
            txtArduinoOutputMemory.Text += (" [" + myData + "] ");
            txtNumbers.Text = myData;
            if(nmArduinoInput.Value == 0)
            {
                switch (Convert.ToInt32(myData))
                {
                    case 0: { lblCounter0.Text = (Convert.ToInt32(lblCounter0.Text) + 1).ToString(); break;}
                    case 1: { lblCounter1.Text = (Convert.ToInt32(lblCounter1.Text) + 1).ToString(); break; }
                    case 2: { lblCounter2.Text = (Convert.ToInt32(lblCounter2.Text) + 1).ToString(); break; }
                    case 3: { lblCounter3.Text = (Convert.ToInt32(lblCounter3.Text) + 1).ToString(); break; }
                    case 4: { lblCounter4.Text = (Convert.ToInt32(lblCounter4.Text) + 1).ToString(); break; }
                    case 5: { lblCounter5.Text = (Convert.ToInt32(lblCounter5.Text) + 1).ToString(); break; }
                    case 6: { lblCounter6.Text = (Convert.ToInt32(lblCounter6.Text) + 1).ToString(); break; }
                    case 7: { lblCounter7.Text = (Convert.ToInt32(lblCounter7.Text) + 1).ToString(); break; }
                    case 8: { lblCounter8.Text = (Convert.ToInt32(lblCounter8.Text) + 1).ToString(); break; }
                    case 9: { lblCounter9.Text = (Convert.ToInt32(lblCounter9.Text) + 1).ToString(); break; }
                }
                lblAverageNumber.Text =
                    ((int.Parse(lblCounter0.Text)
                    + int.Parse(lblCounter1.Text)
                    + int.Parse(lblCounter2.Text) 
                    + int.Parse(lblCounter3.Text) 
                    + int.Parse(lblCounter4.Text) 
                    + int.Parse(lblCounter5.Text) 
                    + int.Parse(lblCounter6.Text) 
                    + int.Parse(lblCounter7.Text) 
                    + int.Parse(lblCounter8.Text) 
                    + int.Parse(lblCounter9.Text))/10).ToString();
            }
        }

        private void radRepeat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtArduinoOutputMemory.Text = "Čísla: ";
        }
    }
}

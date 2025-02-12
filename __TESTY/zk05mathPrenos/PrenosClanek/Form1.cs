using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Zadání:
    Ze zadaných parametrů článku vypočítejte a zobrazte: 
        1. časovou konstantu (lblTau)
        2. mezní kmitočet (lblfmez)
        (výpočty a jejich kontrola viz PřenosRCaRL-vzor.xlsx)
  
    Podle mezního kmitočtu nastavte kmitočtový rozsah a přesnost (počet bodů charakteristiky):
        nmfmin .. minimální kmitočet
        nmfmax .. maximální kmitočet (například násobek f mezního)
        nmfstep .. krok zvyšování kmitočtu od min po max (počet výpočtů)

    Výpočet přenosu pro kmitočtový rozsah a zobrazení v tabulce:
        1. Reálná část přenosu (AuRe)
        2. Imaginární část přenosu (AuIm)
        3. Amplituda přenosu
        4. Fáze přenosu
        (výpočty a jejich kontrola viz PřenosRCaRL-vzor.xlsx)
 
    Přepočet všech výpočtů při změně vstupních parametrů (R, C, f, druh článku) 

    Bonus: samostatná dobrovolná práce (opakování procvičování):
    - výpočet a zobrazení přenosu pro mezní kmitočet
    - převod vypočtených jednotek na dílčí (T, G, M, k, m, u, n, p)
    - grafické zobrazení v komplexní rovině a logaritmických souřadnicích
    - rozšířit aplikaci pro výpočet článků RL
    - uložení vypočtených hodnot do souboru
    - zobraní nápovědy výpočtů článku
    - vytvoření aplikace pro výpočet přechodové charakteristiky
 */



namespace PrenosClanek
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            apkInit();
        }
        double kapacita, odpor, tau, omega, mezF;
        double Re, Im, Au, Audb, P;

        private void apkInit()
        {
            nmHodnR.Value = 80;
            cmbJednR.Items.Add("GΩ");
            cmbJednR.Items.Add("MΩ");
            cmbJednR.Items.Add("kΩ");
            cmbJednR.Items.Add("Ω");
            cmbJednR.Items.Add("mΩ");
            cmbJednR.SelectedIndex = 3;

            nmHodnC.Value = 100;
            cmbJednC.Items.Add("F");
            cmbJednC.Items.Add("mF");
            cmbJednC.Items.Add("uF");
            cmbJednC.Items.Add("nF");
            cmbJednC.Items.Add("pF");
            cmbJednC.SelectedIndex = 3;

            int sirka = 90;
            lstView.Columns.Add("f[Hz] ",sirka-20,HorizontalAlignment.Center);
            lstView.Columns.Add("Au Re", sirka, HorizontalAlignment.Center);
            lstView.Columns.Add("Im Re", sirka, HorizontalAlignment.Center);
            lstView.Columns.Add("Au[dB]", sirka, HorizontalAlignment.Center);
            lstView.Columns.Add("Faz[°]", sirka, HorizontalAlignment.Center);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                lstView.Items.Clear();
                switch (cmbJednC.Text){
                    case "F": kapacita = (double)nmHodnC.Value; break;
                    case "mF": kapacita = (double)nmHodnC.Value*Math.Pow(10,-3); break;
                    case "uF": kapacita = (double)nmHodnC.Value * Math.Pow(10, -6); break;
                    case "nF": kapacita = (double)nmHodnC.Value * Math.Pow(10, -9); break;
                    case "pF": kapacita = (double)nmHodnC.Value * Math.Pow(10, -12); break;
                    default: kapacita = 1; MessageBox.Show("SUS"); break;
                }
                switch (cmbJednR.Text){
                    case "Ω": odpor = (double)nmHodnR.Value; break;
                    case "GΩ": odpor = (double)nmHodnR.Value * Math.Pow(10, 9); break;
                    case "MΩ": odpor = (double)nmHodnR.Value * Math.Pow(10, 6); break;
                    case "kΩ": odpor = (double)nmHodnR.Value * Math.Pow(10, 3); break;
                    case "mΩ": odpor = (double)nmHodnR.Value * Math.Pow(10, -3); break;
                    default: odpor = 1; MessageBox.Show("SUS"); break;
                }
                tau = kapacita * odpor;
                mezF = 1 / (2 * Math.PI * tau);

                lblTau.Text = tau.ToString();
                lblfmez.Text = mezF.ToString();

                if (rdBtnInteg.Checked)
                {
                    for (double i = Convert.ToDouble(nmfmin.Value); i < Convert.ToDouble(nmfmax.Value); i += Convert.ToDouble(nmfstep.Value))
                    {
                        omega = 2 * Math.PI * i;
                        Re = 1 / (1 + Math.Pow(omega * tau, 2));
                        Im = -(omega * tau / (1 + Math.Pow(omega * tau, 2)));
                        Au = Math.Abs(Math.Sqrt(Math.Pow(Re, 2) + Math.Pow(Im, 2)));
                        Audb = 20 * Math.Log(Au);
                        P = Math.Atan(Im / Re / (Math.PI * 180));

                        ListViewItem item = new ListViewItem(i.ToString());
                        item.SubItems.Add(Re.ToString());
                        item.SubItems.Add(Im.ToString());
                        item.SubItems.Add(Audb.ToString());
                        item.SubItems.Add(P.ToString());
                        lstView.Items.Add(item);
                    }
                }
                else if (rdBtnDeriv.Checked)
                {
                    for (double i = Convert.ToDouble(nmfmin.Value); i < Convert.ToDouble(nmfmax.Value); i += Convert.ToDouble(nmfstep.Value))
                    {
                        omega = 2 * Math.PI * Convert.ToDouble(i);
                        Re = Math.Pow(omega * tau, 2) / (1 + Math.Pow(omega * tau, 2));
                        Im = omega * tau / (1 + Math.Pow(omega * tau, 2));
                        Au = Math.Abs(Math.Sqrt(Math.Pow(Re, 2) + Math.Pow(Im, 2)));
                        Audb = 20 * Math.Log(Au);
                        P = Math.Atan(Im / Re / (Math.PI * 180));

                        ListViewItem item = new ListViewItem(i.ToString());
                        item.SubItems.Add(Re.ToString());
                        item.SubItems.Add(Im.ToString());
                        item.SubItems.Add(Audb.ToString());
                        item.SubItems.Add(P.ToString());
                        lstView.Items.Add(item);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                throw;
            }
        }
        private void rdBtnInteg_CheckedChanged(object sender, EventArgs e)
        {
            lstView.Items.Clear();
        }
    }
}

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
        double kapacita;
        double odpor;
        double tau;
        double omega;
        double mezF;

        double ReIC;
        double ImIC;
        double AuIC;
        double AudbIC;
        double PIC;

        double ReDC;
        double ImDC;
        double AuDC;
        double AudbDC;
        double PDC;
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
            lblTau.Text = tau.ToString();
            lblfmez.Text = mezF.ToString();
            kapacita = (double)nmHodnC.Value;
            odpor = (double)nmHodnR.Value;
            tau = kapacita * odpor;
            mezF = (1 / 2 * Math.PI * tau);

            if (rdBtnInteg.Checked)
            {
                for (int i = Convert.ToInt32(nmfmin.Value); i < Convert.ToInt32(nmfmax.Value); i += Convert.ToInt32(nmfstep.Value))
                {
                    omega = (2 * Math.PI * Convert.ToDouble(i));
                    ReIC = (1 / (1 + Math.Pow((omega * tau), 2)));
                    ImIC = (omega * tau) / (1 + Math.Pow((omega * tau), 2));
                    AuIC = Math.Abs(Math.Sqrt(Math.Pow(ReIC, 2) + Math.Pow(ImIC, 2)));
                    AudbIC = 20 * Math.Log(AuIC);
                    PIC = Math.Atan((ImIC / ReIC) / (Math.PI * 180));

                    ListViewItem item = new ListViewItem(i.ToString());
                    item.SubItems.Add(ReIC.ToString());
                    item.SubItems.Add(ImIC.ToString());
                    item.SubItems.Add(AudbIC.ToString());
                    item.SubItems.Add(PIC.ToString());
                    lstView.Items.Add(item);
                } 
            }
            else if(rdBtnDeriv.Checked)
            {// dodělat pro DC
                for (int i = Convert.ToInt32(nmfmin.Value); i < Convert.ToInt32(nmfmax.Value); i += Convert.ToInt32(nmfstep.Value))
                {
                    omega = (2 * Math.PI * Convert.ToDouble(i));
                    ReDC = 0;
                    ImDC = 0;
                    AuDC = 0;
                    AudbDC = 0;
                    PDC = 0;

                    ListViewItem item = new ListViewItem(i.ToString());
                    item.SubItems.Add(ReIC.ToString());
                    item.SubItems.Add(ImIC.ToString());
                    item.SubItems.Add(AudbIC.ToString());
                    item.SubItems.Add(PIC.ToString());
                    lstView.Items.Add(item);
                }
            }
        }

        private void rdBtnInteg_CheckedChanged(object sender, EventArgs e)
        {
            lstView.Items.Clear();
        }
    }
}

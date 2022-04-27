using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Odev
{
    public partial class Form1 : Form
    {
        string hava = "";
        int yagmurlu = 0;
        int gunesli = 0;
        int bulutlu = 0;
        
        string sicaklik = "";
        int soguk = 0;
        int ilik = 0;
        int sicak = 0;

        string nem = "";
        int yuksek = 0;
        int normal = 0;

        string ruzgar = "";
        int var = 0;
        int yok = 0;

        int evet = 0;
        int hayir = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbHava.Items.Add("Yağmurlu");
            cmbHava.Items.Add("Bulutlu");
            cmbHava.Items.Add("Güneşli");

            cmbSicaklik.Items.Add("Sıcak");
            cmbSicaklik.Items.Add("Ilık");
            cmbSicaklik.Items.Add("Soğuk");

            cmbNem.Items.Add("Yüksek");
            cmbNem.Items.Add("Normal");

            cmbRuzgar.Items.Add("Var");
            cmbRuzgar.Items.Add("Yok");

            //lblHava.Text = cmbHava.Text;
        }

        private void cmbHava_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Add(cmbHava.SelectedItem.ToString());

            hava = cmbHava.Text;
            if(hava == "Yağmurlu")
            {
                yagmurlu++;
                lblYagmurAdet.Text = yagmurlu.ToString();
            }
            else if(hava == "Güneşli")
            {
                gunesli++;
                lblGunesAdet.Text = gunesli.ToString();

            }
            else if(hava == "Bulutlu")
            {
                bulutlu++;
                lblBulutAdet.Text = bulutlu.ToString();
            }
        }

        private void cmbSicaklik_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Add(cmbSicaklik.SelectedItem.ToString());

            sicaklik = cmbSicaklik.Text;
            if (sicaklik == "Sıcak")
            {
                sicak++;
                lblSicakAdet.Text = sicak.ToString();
            }
            else if (sicaklik == "Ilık")
            {
                ilik++;
                lblIlikAdet.Text = ilik.ToString();

            }
            else if (sicaklik == "Soğuk")
            {
                soguk++;
                lblSogukAdet.Text = soguk.ToString();
            }
        }

        private void cmbNem_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Add(cmbNem.SelectedItem.ToString());

            nem = cmbNem.Text;
            if (nem == "Yüksek")
            {
                yuksek++;
                lblNemYuksekAdet.Text = yuksek.ToString();
            }
            else if (nem == "Normal")
            {
                normal++;
                lblNemNormalAdet.Text = normal.ToString();

            }
        }

        private void cmbRuzgar_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Add(cmbRuzgar.SelectedItem.ToString());

            ruzgar = cmbRuzgar.Text;
            if (ruzgar == "Var")
            {
                var++;
                lblRuzgarVarAdet.Text = var.ToString();
            }
            else if (ruzgar == "Yok")
            {
                yok++;
                lblRuzgarYokAdet.Text = yok.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string havaDurumu = cmbHava.SelectedItem.ToString();
            string sicaklik = cmbSicaklik.SelectedItem.ToString();
            string nem = cmbNem.SelectedItem.ToString();
            string ruzgar = cmbRuzgar.SelectedItem.ToString();
            

            if (havaDurumu == "Yağmurlu" && sicaklik == "Sıcak" && nem == "Yüksek" && ruzgar == "Yok")
            {
                hayir++;
                lblSonuc.Text ="HAYIR";
            }
            else if (havaDurumu == "Yağmurlu" && sicaklik == "Sıcak" && nem == "Yüksek" && ruzgar == "Var")
            {
                hayir++;
                lblSonuc.Text ="HAYIR";
            }
            else if (havaDurumu == "Bulutlu" && sicaklik == "Sıcak" && nem == "Yüksek" && ruzgar == "Yok")
            {
                evet++;
                lblSonuc.Text ="EVET";
            }
            else if (havaDurumu == "Güneşli" && sicaklik == "Ilık" && nem == "Yüksek" && ruzgar == "Yok")
            {
                evet++;
                lblSonuc.Text = "EVET";
            }
            else if (havaDurumu == "Güneşli" && sicaklik == "Soğuk" && nem == "Normal" && ruzgar == "Yok")
            {
                evet++;
                lblSonuc.Text = "EVET";
            }
            else if (havaDurumu == "Güneşli" && sicaklik == "Soğuk" && nem == "Normal" && ruzgar == "Var")
            {
                hayir++;
                lblSonuc.Text = "HAYIR";
            }
            else if (havaDurumu == "Bulutlu" && sicaklik == "Soğuk" && nem == "Normal" && ruzgar == "Var")
            {
                evet++;
                lblSonuc.Text ="EVET";
            }
            else if (havaDurumu == "Yağmurlu" && sicaklik == "Ilık" && nem == "Yüksek" && ruzgar == "Yok")
            {
                hayir++;
                lblSonuc.Text ="HAYIR";
            }
            else if (havaDurumu == "Yağmurlu" && sicaklik == "Soğuk" && nem == "Normal" && ruzgar == "Yok")
            {
                evet++;
                lblSonuc.Text ="EVET";
            }
            else if (havaDurumu == "Güneşli" && sicaklik == "Ilık" && nem == "Normal" && ruzgar == "Yok")
            {
                evet++;
                lblSonuc.Text = "EVET";
            }
            else if (havaDurumu == "Yağmurlu" && sicaklik == "Ilık" && nem == "Normal" && ruzgar == "Yok")
            {
                evet++;
                lblSonuc.Text = "EVET";
            }
            else if (havaDurumu == "Bulutlu" && sicaklik == "Ilık" && nem == "Yüksek" && ruzgar == "Var")
            {
                evet++;
                lblSonuc.Text = "EVET";
            }
            else if (havaDurumu == "Bulutlu" && sicaklik == "Sıcak" && nem == "Normal" && ruzgar == "Yok")
            {
                evet++;
                lblSonuc.Text ="EVET";
            }
            else if (havaDurumu == "Güneşli" && sicaklik == "Ilık" && nem == "Yüksek" && ruzgar == "Var")
            {
                hayir++;
                lblSonuc.Text ="HAYIR";
            }
        }

        private void btnEntropi_Click(object sender, EventArgs e)
        {
            double havaGunesli = Convert.ToDouble(gunesli);
            double havaBulutlu = Convert.ToDouble(bulutlu);
            double havaYagmurlu = Convert.ToDouble(yagmurlu);

            int veriAdet = gunesli+bulutlu+yagmurlu;

            double evetOrani = veriAdet / evet;
            double hayirOrani = veriAdet / hayir;

            lblEvetOrani.Text = evetOrani.ToString();
            lblHayirOrani.Text = hayirOrani.ToString();
        }
    }
}

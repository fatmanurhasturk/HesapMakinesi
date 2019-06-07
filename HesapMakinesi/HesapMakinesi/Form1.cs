using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class hesapmakinesi : Form
    {
        public hesapmakinesi()
        {
            InitializeComponent();
        }

        double sayi = 0;
        double oncekisayi = 0;
        double sonuc = 0;
        string islemİsareti = null;

        private void btnackapa_Click(object sender, EventArgs e)
        {
            txtsonuc.Enabled = true;
            btn1bas.Enabled = true;
            btn2bas.Enabled = true;
            btn3bas.Enabled = true;
            btn4bas.Enabled = true;
            btn5bas.Enabled = true;
            btn6bas.Enabled = true;
            btn7bas.Enabled = true;
            btn8bas.Enabled = true;
            btn9bas.Enabled = true;
            btn0bas.Enabled = true;
            btntopla.Enabled = true;
            btncikar.Enabled = true;
            btncarp.Enabled = true;
            btnbol.Enabled = true;
            btnesittir.Enabled = true;
            btntemizle.Enabled = true;
            btntemizle.ForeColor = Color.White;
            btntemizle.BackColor = Color.Red;


        }
        private void btntemizle_Click(object sender, EventArgs e)
        {
                txtsonuc.Clear();
                islemİsareti = null;
                sayi = 0;
            
        }

        private void btn1bas_Click(object sender, EventArgs e)
        {

            txtsonuc.Text += "1";
            sayi = Convert.ToDouble(txtsonuc.Text);
        }

        private void btn2bas_Click(object sender, EventArgs e)
        {
            txtsonuc.Text += "2";
            sayi = Convert.ToDouble(txtsonuc.Text);

        }

        private void btn3bas_Click(object sender, EventArgs e)
        {
            txtsonuc.Text += "3";
            sayi = Convert.ToDouble(txtsonuc.Text);

        }

        private void btn4bas_Click(object sender, EventArgs e)
        {
            txtsonuc.Text += "4";
            sayi = Convert.ToDouble(txtsonuc.Text);

        }

        private void btn5bas_Click(object sender, EventArgs e)
        {
            txtsonuc.Text += "5";
            sayi = Convert.ToDouble(txtsonuc.Text);

        }

        private void btn6bas_Click(object sender, EventArgs e)
        {
            txtsonuc.Text += "6";
            sayi = Convert.ToDouble(txtsonuc.Text);

        }

        private void btn7bas_Click(object sender, EventArgs e)
        {
            txtsonuc.Text += "7";
            sayi = Convert.ToDouble(txtsonuc.Text);

        }

        private void btn8bas_Click(object sender, EventArgs e)
        {
            txtsonuc.Text += "8";
            sayi = Convert.ToDouble(txtsonuc.Text);

        }

        private void btn9bas_Click(object sender, EventArgs e)
        {
            txtsonuc.Text += "9";
            sayi = Convert.ToDouble(txtsonuc.Text);

        }

        private void btn0bas_Click(object sender, EventArgs e)
        {
            txtsonuc.Text += "0";
            sayi = Convert.ToDouble(txtsonuc.Text);

        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            txtsonuc.Text = "+";
            islemİsareti = "+";
            oncekisayi = sayi;
            txtsonuc.Text = null;

        }

        private void btncikar_Click(object sender, EventArgs e)
        {
            txtsonuc.Text = "-";
            islemİsareti = "-";
            oncekisayi = sayi;
            txtsonuc.Text = null;

        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            txtsonuc.Text = "*";
            islemİsareti = "*";
            oncekisayi = sayi;
            txtsonuc.Text = null;

        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            txtsonuc.Text = "/";
            islemİsareti = "/";
            oncekisayi = sayi;
            txtsonuc.Text = null;
        }


        private void btnesittir_Click(object sender, EventArgs e)
        {
            if (islemİsareti == "+")
            {
                sonuc = oncekisayi + sayi;
                txtsonuc.Text = sonuc.ToString();
            }
            else if (islemİsareti == "-")
            {
                sonuc = oncekisayi - sayi;
                txtsonuc.Text = sonuc.ToString();
            }
            else if (islemİsareti == "*")
            {
                sonuc = oncekisayi * sayi;
                txtsonuc.Text = sonuc.ToString();
            }
            else if (islemİsareti == "/")
            {
                sonuc = oncekisayi / sayi;
                txtsonuc.Text = sonuc.ToString();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinama_Bufe_Satıs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt16(TextMısır.Text);
            bilet = Convert.ToInt16(TextBilet.Text);
            su = Convert.ToInt16(TextSu.Text);
            cay = Convert.ToInt16(TextCay.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            LblToplam.Text = toplam.ToString() + " TL ";

            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString() + "  TL ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextMısır.Text = "";
            TextBilet.Text = "";
            TextSu.Text = "";
            TextCay.Text = "";
            TextMısır.Focus();
        }
    }
}

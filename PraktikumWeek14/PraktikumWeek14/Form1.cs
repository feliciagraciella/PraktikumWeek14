using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("Tolong isi textbox terlebih dahulu");
                labelOutput.Text = "Output";
            }
            else
            {
                string rev = "";
                int jumlah = textBoxInput.Text.Length;
                for (int i = jumlah - 1; i >= 0; i--)
                {
                    rev = rev + textBoxInput.Text[i];
                }
                labelOutput.Text = rev;
            }
        }

        private void buttonUrutkan_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("Tolong isi textbox terlebih dahulu");
                labelOutput.Text = "Output";
            }
            else
            {
                char[] kalimat = textBoxInput.Text.ToArray();
                Array.Sort(kalimat);
                int jumlah = kalimat.Length;
                string angka = "";
                string hurufbesar = "";
                string hurufkecil = "";
                string simbol = "";
                
                for (int i = 0; i < jumlah; i++)
                {
                    if (Char.IsDigit(kalimat[i]) == true)
                    {
                        angka += kalimat[i];
                    }
                    else if (Char.IsUpper(kalimat[i]) == true)
                    {
                        hurufbesar += kalimat[i];
                    }
                    else if (Char.IsLower(kalimat[i]) == true)
                    {
                        hurufkecil += kalimat[i];
                    }
                    else if (Char.IsWhiteSpace(kalimat[i]) == false)
                    {
                        simbol += kalimat[i];
                    }
                }
                labelOutput.Text = hurufkecil + hurufbesar + angka + simbol;
            }
        }
    }
}

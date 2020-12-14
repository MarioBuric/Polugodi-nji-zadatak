using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buricMario_Polugodišnji_Zadatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = textBox1.Text;
            string model = textBox2.Text;
            string Godiste = textBox3.Text;

            if (string.IsNullOrWhiteSpace(marka) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(Godiste)) ;
            {
                MessageBox.Show("Pogrešni podaci");
                return;
                int godiste = Convert.ToInt32(Godiste);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Vozila.Count; i++)
                if (Vozila[i].Godiste == 2020)
                {
                    Vozila[i].Status = "Novo";
                }
                else if (Vozila[i].Godiste > 1990)
                {
                    Vozila[i].Status = "Oldtimer";
                }
                else
                {
                    (Vozila[i].Godiste > 1990);

                    Vozila[i].Status = "Skoro Novo";
                }

                






        }

            private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Marka          Model          Godiste ");
             
            {
                listBox1.Items.Add(Vozila.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
        
    
    



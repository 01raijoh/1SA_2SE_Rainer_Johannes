using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_automation
{
    public partial class Form1 : Form
    {
        string Marke;
        string Ps;
        string Farbe;
        string Verbrauch;
        string gefahreneKm;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             Marke = marke.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Ps = ps.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Farbe = comboBox1.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Verbrauch = verbrauch.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label12.Text = Marke;
            label13.Text = gefahreneKm;
            label14.Text = Farbe;
            label15.Text = Ps;
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = "Marke:";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = "gefahrene km:";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = "Farbe:";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = "Ps:";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label10.Text = "Tankinhalt:";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label11.Text = "Reichweite:";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 

        }


    }
}

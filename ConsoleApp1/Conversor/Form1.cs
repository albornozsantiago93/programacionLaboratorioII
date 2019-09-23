using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejercicio20;

namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Euro monedaEuro = new Euro(double.Parse(this.textBox1.Text), double.Parse(this.textBox4.Text));

            Dolar aux = (Dolar)monedaEuro;
            Peso auxPeso = (Peso)monedaEuro;
            Euro auxEuro = (Euro)monedaEuro;

            textBox8.Text = aux.GetCantidad().ToString();
            textBox9.Text = auxPeso.GetCantidad().ToString();
            textBox7.Text = auxEuro.GetCantidad().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dolar monedaDolar = new Dolar(double.Parse(this.textBox2.Text), double.Parse(this.textBox5.Text));

            Dolar aux = (Dolar)monedaDolar;
            Euro auxEuro = (Euro)monedaDolar;
            Peso auxPeso = (Peso)monedaDolar;

            textBox11.Text = aux.GetCantidad().ToString();
            textBox10.Text = auxEuro.GetCantidad().ToString();
            textBox12.Text = auxPeso.GetCantidad().ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Peso monedaPeso = new Peso(double.Parse(this.textBox3.Text), double.Parse(this.textBox6.Text));

            Dolar aux = (Dolar)monedaPeso;
            Peso auxPeso = (Peso)monedaPeso;
            Euro auxEuro = (Euro)monedaPeso;

            textBox14.Text = aux.GetCantidad().ToString();
            textBox13.Text = auxEuro.GetCantidad().ToString();
            textBox15.Text = auxPeso.GetCantidad().ToString();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //string auxiliarNumero= "";
            //auxiliarNumero +=this.textBox4.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

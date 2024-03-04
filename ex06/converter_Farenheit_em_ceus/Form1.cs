using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f, c;
            f = Convert.ToDouble(textFarenheit.Text.Replace('.', ','));

            c = (f - 32) * 5 / 9;

            lblSaida.Text = f + " Farenheit é igual a " + c.ToString("#0.00") + " Graus celsius";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

        
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Calcularbtn_Click(object sender, EventArgs e)
        {
            Double N = Convert.ToDouble(Ntxt.Text);
            Double dx = Convert.ToDouble(dxtxt.Text);
            Double Total = 0;
            Double X = -N;
            while (X <= N)
            {
                double agnesi = 1 / (Math.Pow(X, 2) + 1);
                Total += agnesi * dx;
                X += dx ;
            }
            Console.WriteLine("Area : " + Total);
            Areatxt.Text = Convert.ToString(Total);
            PItxt.Text = Convert.ToString(Math.PI);


        }

        private void Borrarbtn_Click(object sender, EventArgs e)
        {
            Ntxt.Clear();
            dxtxt.Clear();
            Areatxt.Clear();
            PItxt.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

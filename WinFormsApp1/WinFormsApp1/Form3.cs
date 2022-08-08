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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void calculartbtn_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(atxt.Text);
            double b = Convert.ToDouble(btxt.Text);
            double c = Convert.ToDouble(ctxt.Text);
            double x1 = 0;
            double x2 = 0;
            double operacion = Math.Sqrt(((Math.Pow(b,2)) - ((4)*(a)*(c))));
            x1 = (-b + operacion) / (2*a);
            x2 = (-b - operacion) /(2*a);
            respuestap.Text = Convert.ToString(x1);
            respuestan.Text = Convert.ToString(x2);
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            atxt.Clear();
            btxt.Clear();
            ctxt.Clear();
            respuestap.Clear();
            respuestan.Clear();
        }
    }
}

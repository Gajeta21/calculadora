namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //variables
        double valor1 = 0;
        double valor2 = 0;
        double respuesta = 0;
        private int Op = 0;
        public Form1()
        {
            InitializeComponent();
        }
      //Funciones

        private void escribir(string numero)
        {
            pantalla.Text += numero;
        }


        //Elementos

        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void cero_Click(object sender, EventArgs e)
        {
            escribir("0");
        }

        private void uno_Click(object sender, EventArgs e)
        {
            escribir("1");
        }

        private void dos_Click(object sender, EventArgs e)
        {
            escribir("2");
        }

        private void tres_Click(object sender, EventArgs e)
        {
            escribir("3");
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            escribir("4");
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            escribir("5");
        }

        private void seis_Click(object sender, EventArgs e)
        {
            escribir("6");
        }

        private void siete_Click(object sender, EventArgs e)
        {
            escribir("7");
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            escribir("8");
        }

        private void Nueve_Click(object sender, EventArgs e)
        {
            escribir("9");
        }

        private void punto_Click(object sender, EventArgs e)
        {
            escribir(".");
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(pantalla.Text);

            switch (Op)
            {
                case 1:
                    respuesta = valor1 + valor2;
                    break;

                case 2:
                    respuesta = valor1 - valor2;
                    break;

                case 3:
                    respuesta = valor1 * valor2;
                    break;

                case 4:
                    respuesta = valor1 / valor2;
                    break;
            }
            pantalla.Clear();
            pantalla.Text = Convert.ToString(respuesta);
            
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void Sumar_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(pantalla.Text);
            pantalla.Clear();
            Op = 1;
        }

        private void Restar_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(pantalla.Text);
            pantalla.Clear();
            Op = 2;
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(pantalla.Text);
            pantalla.Clear();
            Op = 3;
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(pantalla.Text);
            pantalla.Clear();
            Op = 4;
        }

        private void Raiz_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(pantalla.Text);
            pantalla.Clear();
            double raiz = Math.Sqrt(valor1);
            pantalla.Text = Convert.ToString(raiz);
        }

        private void euler_Click(object sender, EventArgs e)
        {
            pantalla.Text = Convert.ToString(Math.E);
            valor1 = Convert.ToDouble(pantalla.Text);
        }

        private void pi_Click(object sender, EventArgs e)
        {
            pantalla.Text = Convert.ToString(Math.PI);
            valor1 = Convert.ToDouble(pantalla.Text);
        }

        private void Seno_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(pantalla.Text);
            pantalla.Text = Convert.ToString(Math.Sin(valor1));
        }

        private void senohiper_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(pantalla.Text);
            pantalla.Text = Convert.ToString(Math.Sinh(valor1));
        }

        private void arcoseno_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(pantalla.Text);
            pantalla.Text = Convert.ToString(Math.Asin(valor1));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(pantalla.Text);
            pantalla.Text = Convert.ToString(Math.Cos(valor1));
        }

        private void cosenohiper_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(pantalla.Text);
            pantalla.Text = Convert.ToString(Math.Cosh(valor1));
        }

        private void arcocoseno_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(pantalla.Text);
            pantalla.Text = Convert.ToString(Math.Acos(valor1));
        }

        private void Tangente_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(pantalla.Text);
            pantalla.Text = Convert.ToString(Math.Tan(valor1));
        }

        private void tangentehiper_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(pantalla.Text);
            pantalla.Text = Convert.ToString(Math.Tanh(valor1));
        }

        private void Arcotangente_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(pantalla.Text);
            pantalla.Text = Convert.ToString(Math.Atan(valor1));
        }

        private void logaritmo_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(pantalla.Text);
            pantalla.Text = Convert.ToString(Math.Log(valor1));
            
        }
    }
}
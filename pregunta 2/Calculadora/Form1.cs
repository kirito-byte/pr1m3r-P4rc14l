namespace Calculadora
{
    public partial class Form1 : Form
    {
        double resultado;
        double auxiliar;
        double decimales;
        double decimales2;
        double baux;
        int coma;
        bool entero;
        string signos;
        string reinicio;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entero = false;
            decimales = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nro1_Click(object sender, EventArgs e)
        {
            int digito;
            digito = Convert.ToInt32(((Button)sender).Text);
            Console.WriteLine(digito);
            if (entero == true)
            {   
                auxiliar = auxiliar * 10+digito;
                textbox1.Text = auxiliar.ToString();
            }
            else
            {
                coma = coma * 10;
                decimales = decimales * 10+digito;
                textbox1.Text = (auxiliar.ToString()+"."+decimales.ToString());
            }
            textBox3.Text = decimales.ToString();
            textBox2.Text = coma.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            entero = true;
            resultado = 0;
            auxiliar = 0;
            coma = 1;
            textbox1.Text = resultado.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void borra_digito_Click(object sender, EventArgs e)
        {
            if (entero)
            {
                baux = auxiliar % 10;
                auxiliar = auxiliar - baux;
                auxiliar=auxiliar / 10;
                textbox1.Text = auxiliar.ToString();
            }
            else
            {
                baux = decimales % 10;
                coma = coma / 10;
                decimales = decimales - baux;
                decimales = decimales / 10;
                textbox1.Text = (auxiliar.ToString() + "." + decimales.ToString());
                if (decimales == 0)
                {
                    entero = true;
                    textbox1.Text = auxiliar.ToString();
                }
            }
            textBox3.Text = decimales.ToString();
            textBox2.Text = baux.ToString();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            signos = ((Button)sender).Text;
            if(resultado==0 || decimales2 == 0)
            {
                resultado = auxiliar;
                decimales2 = decimales;

                entero = true;
                auxiliar = 0;
                decimales = 0;
                coma = 1;
                textbox1.Text = auxiliar.ToString();
                textBox2.Text = resultado.ToString();
                //textBox3.Text = auxiliar.ToString();
            }

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            bool ent = true;
            resultado = Convert.ToDouble(Convert.ToString(resultado)+"," + Convert.ToString(decimales2));
            auxiliar= Convert.ToDouble(Convert.ToString(auxiliar) + "," + Convert.ToString(decimales));
            textBox2.Text = resultado.ToString();
            textBox3.Text = auxiliar.ToString();
            switch (signos)
            {
                case "+":
                    resultado = resultado + auxiliar;
                    break;
                case "-":
                    resultado = resultado - auxiliar;
                    break;
                case "/":
                    resultado = resultado / auxiliar;
                    break;
                case "×":
                    resultado = resultado * auxiliar;
                    break;
                default:
                    // code block
                    break;
            }
            textbox1.Text = resultado.ToString();
            auxiliar = 0;
            decimales = 0;
            resultado = 0;
            decimales2 = 0;
            /*
            
            
            foreach (char w in reinicio)
            {
                if(w.Equals(".")|| w.Equals(","))
                {
                    ent = false;
                }
                if (ent)
                {
                    resultado = resultado*10 + Convert.ToInt32(w.ToString());
                }
                else
                {
                    decimales2 = decimales*10 + Convert.ToInt32(w.ToString());
                }
            }
            textBox2.Text = resultado.ToString();
            textBox3.Text = decimales2.ToString();
            */
        }
    }
}
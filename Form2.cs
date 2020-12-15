using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAxel
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        double num1;
        
         private void MiMetodo_Clic(object sender, EventArgs e )
        {
            double resultado;
            string textoboton=((Button)sender).Text;
            switch (textoboton)
            {
                case "Bugs Bunny":
                    if (lblPuntos.Text == "")
                    {
                        return;
                    }
                    num1 = -100;
                    resultado = num1;
                    lblPuntos.Text = resultado + "";
                    MessageBox.Show("INCORRECTO");
                    Form3 f3= new Form3();
                    f3.Show();
                    break;
                case "Drake Parker":
                    if (lblPuntos.Text == "")
                    {
                        return;
                    }
                    num1 = -100;
                    resultado = num1;
                    lblPuntos.Text = resultado + "";
                    MessageBox.Show("INCORRECTO");
                    Form3 f4 = new Form3();
                    f4.Show();
                    break;
                case "Bart Simpson":
                    if (lblPuntos.Text == "")
                    {
                        return;
                    }
                    num1 = 100;
                    resultado = num1;
                    lblPuntos.Text = resultado + "";
                    MessageBox.Show("CORRECTO");
                    Form3 f5 = new Form3();
                    f5.Show();
                    break;
                default:
                    lblPuntos.Text += textoboton;
                    break;
            }
        }
        private void btnBugs_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.RespuestaBugs = "IMCORRECTO";
            MessageBox.Show(p.ToString());
            Form3 f3 = new Form3();
            f3.Show();           
        }

        private void btnDrake_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.RespuestaDrake = "CORRECTO";
            MessageBox.Show(p.ToString());
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void btnBart_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.RespuestaBart = "IMCORRECTO  ";
            MessageBox.Show(p.ToString());
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void btnOmitir_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void lblPuntos_Click(object sender, EventArgs e)
        {
            
        }
    }
}

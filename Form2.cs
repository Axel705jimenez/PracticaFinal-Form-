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

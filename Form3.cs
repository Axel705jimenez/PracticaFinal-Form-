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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void btnGary_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.RespuestaGary = "CORRECTO";
            MessageBox.Show(p.ToString());
            Form4 f4 = new Form4();
            f4.Show();
        }
        private void btnPatricio_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.RespuestaPatricio = "INCORRECTO";
            MessageBox.Show(p.ToString());
            Form4 f4 = new Form4();
            f4.Show();
        }
        private void btnTiro_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.RespuestaTiro = "INCORRECTO";
            MessageBox.Show(p.ToString());
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void btnOmitir_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
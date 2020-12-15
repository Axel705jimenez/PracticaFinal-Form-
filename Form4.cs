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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnVegetta_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.RespuestaVegetta= "INCORRECTO";
            MessageBox.Show(p.ToString());
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void btnOmitir_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void btnGoku_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.RespuestaPicollo = "INCORRECTO";
            MessageBox.Show(p.ToString());
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void btnPicollo_Click(object sender, EventArgs e)
        {
            Preguntas p = new Preguntas();
            p.RespuestaGoku = "CORRECTO";
            MessageBox.Show(p.ToString());
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}
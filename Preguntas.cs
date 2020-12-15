using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAxel
{
    class Preguntas
    {
        private string respuestaBugs;

        public string RespuestaBugs
        {
            get { return respuestaBugs; }
            set { respuestaBugs = value; }
        }
        private string respuestaDrake;

        public string RespuestaDrake
        {
            get { return respuestaDrake; }
            set { respuestaDrake = value; }
        }
        private string respuestaBart;

        public string RespuestaBart
        {
            get { return respuestaBart; }
            set { respuestaBart = value; }
        }
        private  string respuestaGary;

        public string RespuestaGary
        {
            get { return respuestaGary; }
            set { respuestaGary = value; }
        }
        private string respuestaTiro;

        public string RespuestaTiro
        {
            get { return respuestaTiro; }
            set { respuestaTiro = value; }
        }
        private string respuestaPatricio;

        public string RespuestaPatricio
        {
            get { return respuestaPatricio; }
            set { respuestaPatricio = value; }
        }
        private string respuestaVegetta;

        public string RespuestaVegetta
        {
            get { return respuestaVegetta; }
            set { respuestaVegetta = value; }
        }
        private string respuestaPicollo;

        public string RespuestaPicollo
        {
            get { return respuestaPicollo; }
            set { respuestaPicollo = value; }
        }
        private string respuestaGoku;

        public string RespuestaGoku
        {
            get { return respuestaGoku; }
            set { respuestaGoku = value; }
        }

        public Preguntas()
        {
            respuestaBart = "";
            respuestaBugs = "";
            respuestaDrake = "";
            respuestaGary = "";
            respuestaPatricio = "";
            respuestaTiro = "";
            respuestaGoku = "";
            respuestaVegetta = "";
            respuestaPicollo = "";
        }
        public override string ToString()
        {
            return respuestaBart + " " + respuestaDrake + " " + respuestaBugs + " " + respuestaTiro + " " +
                RespuestaGary + " " + respuestaPatricio + " " + respuestaPicollo + " " + respuestaGoku +" " + 
                respuestaVegetta + " " + base.ToString();
        }
    }
}

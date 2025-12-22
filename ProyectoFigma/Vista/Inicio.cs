using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFigma.Vista
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            label1.Text = "Tú librería \n En \n Vitoria-Gasteiz";
        }
        private static Inicio formulario;
        public static Inicio GetInstance()
        {
            if (formulario == null)
            {
                formulario = new Inicio();
            }
            return formulario;
        }
    }
}

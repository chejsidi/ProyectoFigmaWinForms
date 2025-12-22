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
    public partial class GestorBiblioteca : Form
    {
        public GestorBiblioteca()
        {
            InitializeComponent();
            var form = Inicio.GetInstance();
            InsertarFormulario(form);
        }

        private void InsertarFormulario(Form formulario)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }

            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }
    }
}

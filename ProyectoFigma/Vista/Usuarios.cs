using ProyectoFigma.Controlador;
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
    public partial class Usuarios : Form
    {
        private static Usuarios formulario;
        UsuarioController controller = new UsuarioController();
        public Usuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        public static Usuarios GetInstance()
        {
            if (formulario == null)
            {
                formulario = new Usuarios();
            }
            return formulario;
        }

        private void CargarUsuarios()
        {
            dGridUsuarios.DataSource = null;
            dGridUsuarios.DataSource = controller.ObtenerUsuarios();

            dGridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //ModalUsuario modal = new ModalUsuario();
            //modal.ShowDialog();
            //CargarUsuarios();
        }

    }
}

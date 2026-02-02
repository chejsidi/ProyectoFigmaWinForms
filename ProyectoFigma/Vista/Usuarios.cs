using ProyectoFigma.Controlador;
using ProyectoFigma.Modelo;
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
            ModalUsuario modal = new ModalUsuario(ModalUsuario.ModoModal.Añadir);

            if (modal.ShowDialog() == DialogResult.OK)
            {
                // Crear el nuevo usuario con los datos del modal
                Usuario nuevoUsuario = new Usuario
                {
                    Nombre = modal.Nombre,
                    Apellido_1 = modal.PrimerApellido,
                    Apellido_2 = modal.SegundoApellido,
                    Telefono = int.TryParse(modal.Telefono, out int tel) ? tel : 0
                };

                // Agregar el usuario a la base de datos
                controller.AgregarUsuario(nuevoUsuario);

                // Recargar la lista de usuarios
                CargarUsuarios();

                MessageBox.Show("Usuario añadido correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dGridUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario");
                return;
            }

            int id = (int)dGridUsuarios.SelectedRows[0].Cells["Id"].Value;

            var confirm = MessageBox.Show(
                "¿Seguro que quieres borrar este usuario?",
                "Confirmar",
                MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                controller.BorrarUsuario(id);
                CargarUsuarios();
            }
        }

    }
}

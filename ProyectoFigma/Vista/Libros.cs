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
    public partial class Libros : Form
    {
        private static Libros formulario;
        LibroController controller = new LibroController();
        public Libros()
        {
            InitializeComponent();
            CargarLibros();
        }

        public static Libros GetInstance()
        {
            if (formulario == null)
            {
                formulario = new Libros();
            }
            return formulario;
        }

        private void CargarLibros()
        {
            dGridLibros.DataSource = null;
            dGridLibros.DataSource = controller.ObtenerLibros();

            dGridLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGridLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            ModalLibro modal = new ModalLibro(ModalLibro.ModoModal.Añadir);

            if (modal.ShowDialog() == DialogResult.OK)
            {
                // Crear el nuevo Libro con los datos del modal
                Libro nuevoLibro = new Libro
                {
                    Titulo = modal.Titulo,
                    Escritor = modal.Escritor,
                    Apellido_2 = modal.SegundoApellido,
                    Telefono = int.TryParse(modal.Telefono, out int tel) ? tel : 0
                };

                // Agregar el Libro a la base de datos
                controller.AgregarLibro(nuevoLibro);

                // Recargar la lista de Libros
                CargarLibros();

                MessageBox.Show("Libro añadido correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dGridLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un Libro");
                return;
            }

            int id = (int)dGridLibros.SelectedRows[0].Cells["Id"].Value;

            var confirm = MessageBox.Show(
                "¿Seguro que quieres borrar este Libro?",
                "Confirmar",
                MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                controller.BorrarLibro(id);
                CargarLibros();
            }
        }

    }
}

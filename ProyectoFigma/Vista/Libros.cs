using ProyectoFigma.Controlador;
using ProyectoFigma.Modelo;
using ProyectoFigma.Vista.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFigma.Vista
{
    public partial class Libros : Form
    {
        private static Libros formulario;
        private LibroController controller = new LibroController();

        public Libros()
        {
            InitializeComponent();
            CrearPanelDeLibros();
            CargarLibros();
        }

        public static Libros GetInstance()
        {
            if (formulario == null) formulario = new Libros();
            return formulario;
        }

        private void CrearPanelDeLibros()
        {
            // Crear FlowLayoutPanel para las cards
            var flowLibros = new FlowLayoutPanel
            {
                Name = "flowLibros",
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Padding = new Padding(10)
            };

            tableLayoutPanel1.Controls.Add(flowLibros, 1, 1);
            tableLayoutPanel1.SetColumnSpan(flowLibros, 4);
        }

        private void CargarLibros()
        {
            var flowLibros = tableLayoutPanel1.Controls["flowLibros"] as FlowLayoutPanel;
            if (flowLibros == null) return;

            flowLibros.Controls.Clear();

            List<Libro> libros = controller.ObtenerLibros();

            foreach (var libro in libros)
            {
                var libroControl = new LibroControl(libro);
                libroControl.Margin = new Padding(5);
                libroControl.LibroBorrado += LibroControl_LibroBorrado;
                libroControl.LibroEditado += LibroControl_LibroEditado;

                flowLibros.Controls.Add(libroControl);
            }
        }

        private void LibroControl_LibroBorrado(object sender, int libroId)
        {
            var confirm = MessageBox.Show("¿Seguro que quieres borrar este Libro?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                controller.BorrarLibro(libroId);
                CargarLibros();
            }
        }

        private void LibroControl_LibroEditado(object sender, int libroId)
        {
            var libro = controller.ObtenerLibros().FirstOrDefault(l => l.ID == libroId);
            if (libro == null) return;

            var modal = new ModalLibro(
                ModalLibro.ModoModal.Editar,
                libro.Titulo,
                libro.Escritor,
                libro.Ano_Edicion,
                libro.Sinopsis,
                libro.Disponible
            );

            if (modal.ShowDialog() == DialogResult.OK)
            {
                libro.Titulo = modal.Titulo;
                libro.Escritor = modal.Escritor;
                libro.Ano_Edicion = modal.Ano_Edicion;
                libro.Sinopsis = modal.Sinopsis;
                libro.Disponible = modal.Disponible;

                controller.ActualizarLibro(libro);
                CargarLibros();
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            var modal = new ModalLibro(ModalLibro.ModoModal.Añadir);
            if (modal.ShowDialog() == DialogResult.OK)
            {
                var nuevoLibro = new Libro
                {
                    Titulo = modal.Titulo,
                    Escritor = modal.Escritor,
                    Ano_Edicion = modal.Ano_Edicion,
                    Sinopsis = modal.Sinopsis,
                    Disponible = modal.Disponible
                };
                controller.AgregarLibro(nuevoLibro);
                CargarLibros();
                MessageBox.Show("Libro añadido correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblLibros_Click(object sender, EventArgs e)
        {
            var form = Inicio.GetInstance();
            if (this.MdiParent != null && this.MdiParent.ActiveMdiChild != null)
                this.MdiParent.ActiveMdiChild.Hide();

            form.MdiParent = this.MdiParent;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}

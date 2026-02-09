using ProyectoFigma.Controlador;
using ProyectoFigma.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFigma.Vista
{
    public partial class Prestamos : Form
    {
        private static Prestamos formulario;
        PrestamoController controller = new PrestamoController();

        public Prestamos()
        {
            InitializeComponent();
            CargarPrestamos();
        }

        public static Prestamos GetInstance()
        {
            if (formulario == null)
            {
                formulario = new Prestamos();
            }
            return formulario;
        }

        private void CargarPrestamos()
        {
            dGridPrestamos.DataSource = null;
            dGridPrestamos.AutoGenerateColumns = true;
            dGridPrestamos.DataSource = controller.ObtenerPrestamos();

            dGridPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGridPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Ocultar IDs en visualización
            if (dGridPrestamos.Columns["ID_Libro"] != null)
                dGridPrestamos.Columns["ID_Libro"].Visible = false;
            if (dGridPrestamos.Columns["ID_Usuario"] != null)
                dGridPrestamos.Columns["ID_Usuario"].Visible = false;

            // Renombrar encabezados para mejor lectura
            if (dGridPrestamos.Columns["UsuarioNombre"] != null)
                dGridPrestamos.Columns["UsuarioNombre"].HeaderText = "Usuario";
            if (dGridPrestamos.Columns["LibroTitulo"] != null)
                dGridPrestamos.Columns["LibroTitulo"].HeaderText = "Libro";
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            ModalPrestamo modal = new ModalPrestamo(ModalPrestamo.ModoModal.Añadir);

            if (modal.ShowDialog() == DialogResult.OK)
            {
                Prestamo nuevoPrestamo = new Prestamo
                {
                    ID_Libro = modal.ID_Libro,
                    ID_Usuario = modal.ID_Usuario,
                    Fecha_Inicio = modal.Fecha_Inicio,
                    Fecha_Fin = modal.Fecha_Fin
                };

                controller.AgregarPrestamo(nuevoPrestamo);
                CargarPrestamos();

                MessageBox.Show("Préstamo añadido correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dGridPrestamos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un préstamo");
                return;
            }

            int id = (int)dGridPrestamos.SelectedRows[0].Cells["Id"].Value;

            var confirm = MessageBox.Show(
                "¿Seguro que quieres borrar este préstamo?",
                "Confirmar",
                MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                controller.BorrarPrestamo(id);
                CargarPrestamos();
            }
        }

        private void lblPrestamos_Click(object sender, EventArgs e)
        {
            var form = Inicio.GetInstance();

            if (this.MdiParent != null && this.MdiParent.ActiveMdiChild != null)
            {
                this.MdiParent.ActiveMdiChild.Hide();
            }

            form.MdiParent = this.MdiParent;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}

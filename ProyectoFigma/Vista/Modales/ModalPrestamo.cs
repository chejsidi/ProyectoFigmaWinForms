using ProyectoFigma.Controlador;
using System;
using System.Windows.Forms;

namespace ProyectoFigma.Vista
{
    public partial class ModalPrestamo : Form
    {
        public enum ModoModal
        {
            Añadir,
            Editar
        }

        private ModoModal modo;

        public int ID_Usuario { get; set; }
        public int ID_Libro { get; set; }
        public string Fecha_Inicio { get; set; }
        public string Fecha_Fin { get; set; }
        UsuarioController usuarioController = new UsuarioController();
        LibroController libroController = new LibroController();

        public ModalPrestamo(ModoModal modo)
        {
            InitializeComponent();
            this.modo = modo;
            CargarCombos();
            ConfigurarModal();
        }
        public ModalPrestamo(
            ModoModal modo,
            int idUsuario,
            int idLibro,
            string fechaInicio,
            string fechaFin) : this(modo)
        {
            ID_Usuario = idUsuario;
            ID_Libro = idLibro;
            dtpFechaPrestamo.Value = DateTime.Parse(fechaInicio);
            dtpFechaDevolucion.Value = DateTime.Parse(fechaFin);
        }

        private void ConfigurarModal()
        {
            if (modo == ModoModal.Añadir)
            {
                this.Text = "Añadir Préstamo";
                lblTitulo.Text = "Añadir Préstamo";
                dtpFechaPrestamo.Value = DateTime.Now;
                dtpFechaDevolucion.Value = DateTime.Now.AddDays(14);
            }
            else
            {
                this.Text = "Editar Préstamo";
                lblTitulo.Text = "Editar Préstamo";
            }
        }
        private void CargarCombos()
        {
            cmbUsuario.DataSource = usuarioController.ObtenerUsuarios();
            cmbUsuario.DisplayMember = "Nombre";  
            cmbUsuario.ValueMember = "Id";   
            cmbUsuario.SelectedIndex = -1;

            cmbLibro.DataSource = libroController.ObtenerLibros();
            cmbLibro.DisplayMember = "Titulo";
            cmbLibro.ValueMember = "ID";
            cmbLibro.SelectedIndex = -1;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ID_Usuario = (int)cmbUsuario.SelectedValue;
                ID_Libro = (int)cmbLibro.SelectedValue;

                Fecha_Inicio = dtpFechaPrestamo.Value.ToString("yyyy-MM-dd");
                Fecha_Fin = dtpFechaDevolucion.Value.ToString("yyyy-MM-dd");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidarCampos()
        {
            if (cmbUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un usuario");
                return false;
            }

            if (cmbLibro.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un libro");
                return false;
            }

            if (dtpFechaDevolucion.Value < dtpFechaPrestamo.Value)
            {
                MessageBox.Show("La fecha de devolución no puede ser anterior");
                return false;
            }

            return true;
        }
    }
}

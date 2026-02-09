using System;
using System.Windows.Forms;

namespace ProyectoFigma.Vista
{
    public partial class ModalLibro : Form
    {
        public enum ModoModal
        {
            Añadir,
            Editar
        }

        private ModoModal modo;

        public string Titulo { get; set; }
        public string Escritor { get; set; }
        public int Ano_Edicion { get; set; }
        public string Sinopsis { get; set; }
        public int Disponible { get; set; }

        public ModalLibro(ModoModal modo)
        {
            InitializeComponent();
            this.modo = modo;
            ConfigurarModal();

            // Configurar rango del NumericUpDown para año
            numAno.Minimum = 1500;
            numAno.Maximum = DateTime.Now.Year;
            numAno.Value = DateTime.Now.Year;

            numDisp.Minimum = 0;
            numDisp.Maximum = 1;
            numDisp.Value = 1;
        }

        // Constructor para editar un libro
        public ModalLibro(ModoModal modo, string titulo, string escritor, int ano_Edicion, string sinopsis, int disponible)
            : this(modo)
        {
            txtTitulo.Text = titulo;
            txtAutor.Text = escritor;
            txtSinopsis.Text = sinopsis;

            // Aseguramos que el año esté dentro del rango
            numAno.Value = Math.Min(Math.Max(ano_Edicion, (int)numAno.Minimum), (int)numAno.Maximum);

            // Aseguramos que la disponibilidad esté dentro del rango
            numDisp.Value = Math.Min(Math.Max(disponible, (int)numDisp.Minimum), (int)numDisp.Maximum);
        }

        private void ConfigurarModal()
        {
            if (modo == ModoModal.Añadir)
            {
                this.Text = "Añadir Libro";
                lblTitulo.Text = "Añadir Libro";
            }
            else
            {
                this.Text = "Editar Libro";
                lblTitulo.Text = "Editar Libro";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Titulo = txtTitulo.Text.Trim();
                Escritor = txtAutor.Text.Trim();
                Ano_Edicion = (int)numAno.Value;  // ? CORREGIDO
                Sinopsis = txtSinopsis.Text.Trim();
                Disponible = (int)numDisp.Value;

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
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El título es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("El autor es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAutor.Focus();
                return false;
            }

            if (numAno.Value < 1500 || numAno.Value > DateTime.Now.Year)
            {
                MessageBox.Show($"El año debe estar entre 1500 y {DateTime.Now.Year}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}

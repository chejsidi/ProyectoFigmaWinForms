using System;
using System.Drawing;
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
        public string Autor { get; set; }
        public string Escritor { get; set; }
        public int Ano_Edicion { get; set; }
        public string Sinopsis { get; set; }
        public int Disponible { get; set; }

        public ModalLibro(ModoModal modo)
        {
            InitializeComponent();
            this.modo = modo;
            ConfigurarModal();
        }

        public ModalLibro(ModoModal modo, string titulo, string escritor, int ano_Edicion, string sinopsis, int disponible) : this(modo)
        {
            txtTitulo.Text = titulo;
            txtAutor.Text = escritor;
            numDisp.Value = ano_Edicion;
            txtSinopsis.Text = sinopsis;
            numDisp.Value = disponible;
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
                Ano_Edicion = (int)numDisp.Value;
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

            if (numAno.Value == 0)
            {
                MessageBox.Show("El año de publicación es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }
    }
}

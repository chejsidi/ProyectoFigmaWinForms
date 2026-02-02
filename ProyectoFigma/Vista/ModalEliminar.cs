using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFigma.Vista
{
    public partial class ModalEliminar : Form
    {
        public enum TipoEntidad
        {
            Usuario,
            Libro,
            Prestamo
        }

        private TipoEntidad tipoEntidad;
        private string nombreEntidad;

        public ModalEliminar(TipoEntidad tipo, string nombre = "")
        {
            InitializeComponent();
            this.tipoEntidad = tipo;
            this.nombreEntidad = nombre;
            ConfigurarModal();
        }

        private void ConfigurarModal()
        {
            string mensaje = "";

            switch (tipoEntidad)
            {
                case TipoEntidad.Usuario:
                    this.Text = "Eliminar Usuario";
                    mensaje = "�Est�s seguro que deseas borrar el usuario?";
                    break;
                case TipoEntidad.Libro:
                    this.Text = "Eliminar Libro";
                    mensaje = "�Est�s seguro que deseas borrar el libro?";
                    break;
                case TipoEntidad.Prestamo:
                    this.Text = "Eliminar Pr�stamo";
                    mensaje = "�Est�s seguro que deseas borrar el pr�stamo?";
                    break;
            }

            // Si se proporciona un nombre espec�fico, mostrarlo
            if (!string.IsNullOrEmpty(nombreEntidad))
            {
                mensaje = mensaje.Replace("el usuario?", $"el usuario '{nombreEntidad}'?");
                mensaje = mensaje.Replace("el libro?", $"el libro '{nombreEntidad}'?");
                mensaje = mensaje.Replace("el pr�stamo?", $"el pr�stamo #{nombreEntidad}?");
            }

            lblMensaje.Text = mensaje;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

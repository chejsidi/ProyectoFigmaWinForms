using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFigma.Vista
{
    public partial class ModalUsuario : Form
    {
     public enum ModoModal
        {
     Añadir,
      Editar
     }

     private ModoModal modo;

        // Propiedades para acceder a los datos del formulario
  public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
 public string Telefono { get; set; }

   public ModalUsuario(ModoModal modo)
     {
         InitializeComponent();
 this.modo = modo;
       ConfigurarModal();
     }

        // Constructor sobrecargado para edición con datos existentes
        public ModalUsuario(ModoModal modo, string nombre, string primerApellido, string segundoApellido, string telefono) : this(modo)
        {
            txtNombre.Text = nombre;
   txtPrimerApellido.Text = primerApellido;
       txtSegundoApellido.Text = segundoApellido;
            txtTelefono.Text = telefono;
        }

        private void ConfigurarModal()
        {
     if (modo == ModoModal.Añadir)
            {
    this.Text = "Añadir Usuario";
          lblTitulo.Text = "Añadir Usuario";
    }
       else
          {
     this.Text = "Editar Usuario";
    lblTitulo.Text = "Editar Usuario";
      }
  }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
   {
    // Guardar los valores en las propiedades
          Nombre = txtNombre.Text.Trim();
        PrimerApellido = txtPrimerApellido.Text.Trim();
     SegundoApellido = txtSegundoApellido.Text.Trim();
             Telefono = txtTelefono.Text.Trim();

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
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
       {
    MessageBox.Show("El nombre es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         txtNombre.Focus();
     return false;
        }

  if (string.IsNullOrWhiteSpace(txtPrimerApellido.Text))
        {
     MessageBox.Show("El primer apellido es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         txtPrimerApellido.Focus();
        return false;
            }

         if (string.IsNullOrWhiteSpace(txtTelefono.Text))
    {
       MessageBox.Show("El teléfono es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTelefono.Focus();
    return false;
      }

      // Validar que el teléfono sea numérico
     if (!int.TryParse(txtTelefono.Text.Trim(), out _))
    {
        MessageBox.Show("El teléfono debe ser un número válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      txtTelefono.Focus();
         return false;
         }

       return true;
   }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

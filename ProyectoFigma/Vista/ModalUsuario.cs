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
        public string DNI { get; set; }
  public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public ModalUsuario(ModoModal modo)
        {
        InitializeComponent();
     this.modo = modo;
            ConfigurarModal();
        }

     // Constructor sobrecargado para edición con datos existentes
        public ModalUsuario(ModoModal modo, string nombre, string primerApellido, string segundoApellido, 
         string dni, string email, string telefono, string direccion) : this(modo)
        {
            txtNombre.Text = nombre;
       txtPrimerApellido.Text = primerApellido;
txtSegundoApellido.Text = segundoApellido;
     txtDNI.Text = dni;
      txtEmail.Text = email;
        txtTelefono.Text = telefono;
txtDireccion.Text = direccion;
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
 DNI = txtDNI.Text.Trim();
          Email = txtEmail.Text.Trim();
           Telefono = txtTelefono.Text.Trim();
       Direccion = txtDireccion.Text.Trim();

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

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
    MessageBox.Show("El DNI es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           txtDNI.Focus();
       return false;
       }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
              MessageBox.Show("El email es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
        return false;
            }

            return true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Drawing;
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

        // Propiedades para acceder a los datos del formulario
    public int UsuarioId { get; set; }
        public int LibroId { get; set; }
        public DateTime FechaPrestamo { get; set; }
  public DateTime FechaDevolucion { get; set; }
        public string Estado { get; set; }

        public ModalPrestamo(ModoModal modo)
        {
      InitializeComponent();
      this.modo = modo;
   ConfigurarModal();
      InicializarComboEstado();
 }

        // Constructor sobrecargado para edición con datos existentes
  public ModalPrestamo(ModoModal modo, int usuarioId, int libroId, 
    DateTime fechaPrestamo, DateTime fechaDevolucion, string estado) : this(modo)
 {
  // Aquí deberías cargar el usuario y libro seleccionados en los ComboBox
            // Por ahora solo guardamos los IDs
   UsuarioId = usuarioId;
       LibroId = libroId;
    dtpFechaPrestamo.Value = fechaPrestamo;
       dtpFechaDevolucion.Value = fechaDevolucion;
       cmbEstado.SelectedItem = estado;
  }

   private void ConfigurarModal()
        {
        if (modo == ModoModal.Añadir)
 {
   this.Text = "Añadir Préstamo";
        lblTitulo.Text = "Añadir Préstamo";
      dtpFechaPrestamo.Value = DateTime.Now;
        dtpFechaDevolucion.Value = DateTime.Now.AddDays(14); // 14 días por defecto
          }
            else
      {
     this.Text = "Editar Préstamo";
        lblTitulo.Text = "Editar Préstamo";
     }
        }

        private void InicializarComboEstado()
  {
         cmbEstado.Items.Clear();
cmbEstado.Items.Add("Activo");
     cmbEstado.Items.Add("Devuelto");
  cmbEstado.Items.Add("Retrasado");
       cmbEstado.SelectedIndex = 0;
        }

    private void btnGuardar_Click(object sender, EventArgs e)
        {
          if (ValidarCampos())
     {
   // Guardar los valores en las propiedades
            // Aquí deberías obtener los IDs de los ComboBox cuando tu compañero los implemente
          // Por ahora asumimos valores temporales
             FechaPrestamo = dtpFechaPrestamo.Value;
          FechaDevolucion = dtpFechaDevolucion.Value;
     Estado = cmbEstado.SelectedItem.ToString();

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
            // Aquí validarías que se haya seleccionado un usuario y un libro
    // cuando tu compañero implemente los ComboBox

   if (dtpFechaDevolucion.Value < dtpFechaPrestamo.Value)
   {
    MessageBox.Show("La fecha de devolución no puede ser anterior a la fecha de préstamo", 
        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    dtpFechaDevolucion.Focus();
  return false;
       }

  if (cmbEstado.SelectedIndex == -1)
        {
                MessageBox.Show("Debe seleccionar un estado", "Validación", 
         MessageBoxButtons.OK, MessageBoxIcon.Warning);
     cmbEstado.Focus();
     return false;
     }

  return true;
        }
    }
}

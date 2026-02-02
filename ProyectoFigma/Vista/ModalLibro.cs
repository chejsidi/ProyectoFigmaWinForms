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

        // Propiedades para acceder a los datos del formulario
   public string Titulo { get; set; }
        public string Autor { get; set; }
  public string ISBN { get; set; }
        public string Editorial { get; set; }
 public int AnioPublicacion { get; set; }
      public string Genero { get; set; }
    public int Cantidad { get; set; }

     public ModalLibro(ModoModal modo)
        {
        InitializeComponent();
            this.modo = modo;
            ConfigurarModal();
        }

        // Constructor sobrecargado para edición con datos existentes
        public ModalLibro(ModoModal modo, string titulo, string autor, string isbn, 
    string editorial, int anioPublicacion, string genero, int cantidad) : this(modo)
        {
            txtTitulo.Text = titulo;
            txtAutor.Text = autor;
            txtISBN.Text = isbn;
            txtEditorial.Text = editorial;
            numAnio.Value = anioPublicacion;
      txtGenero.Text = genero;
            numCantidad.Value = cantidad;
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
        // Guardar los valores en las propiedades
           Titulo = txtTitulo.Text.Trim();
     Autor = txtAutor.Text.Trim();
                ISBN = txtISBN.Text.Trim();
        Editorial = txtEditorial.Text.Trim();
             AnioPublicacion = (int)numAnio.Value;
 Genero = txtGenero.Text.Trim();
     Cantidad = (int)numCantidad.Value;

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

  if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
          MessageBox.Show("El ISBN es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          txtISBN.Focus();
          return false;
            }

    if (numAnio.Value == 0)
            {
     MessageBox.Show("El año de publicación es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        numAnio.Focus();
return false;
            }

         return true;
   }
    }
}

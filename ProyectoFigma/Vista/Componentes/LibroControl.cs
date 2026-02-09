using ProyectoFigma.Modelo;
using System;
using System.Windows.Forms;

namespace ProyectoFigma.Vista.Controles
{
    public partial class LibroControl : UserControl
    {
        public event EventHandler<int> LibroBorrado;
        public event EventHandler<int> LibroEditado;

        public Libro Libro { get; private set; }

        public LibroControl(Libro libro)
        {
            InitializeComponent();
            Libro = libro;
            CargarDatos();
        }

        private void CargarDatos()
        {
            lblTitulo.Text = Libro.Titulo;
            lblAutor.Text = "Autor: " + Libro.Escritor;
            lblAno.Text = "Año: " + Libro.Ano_Edicion;
            lblDisponible.Text = "Disponible: " + (Libro.Disponible == 1 ? "Sí" : "No"); ;
            lblSinopsis.Text = "Sinopsis: " + Libro.Sinopsis;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LibroBorrado?.Invoke(this, Libro.ID);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LibroEditado?.Invoke(this, Libro.ID);
        }
    }
}

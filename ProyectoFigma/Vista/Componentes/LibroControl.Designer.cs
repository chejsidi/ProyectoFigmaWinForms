using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFigma.Vista.Controles
{
    partial class LibroControl
    {
        private Label lblTitulo;
        private Label lblAutor;
        private Label lblAno;
        private Label lblSinopsis;
        private Label lblDisponible;
        private Button btnBorrar;
        private Button btnEditar;

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.lblAutor = new Label();
            this.lblAno = new Label();
            this.lblSinopsis = new Label();
            this.lblDisponible = new Label();
            this.btnBorrar = new Button();
            this.btnEditar = new Button();

            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitulo.Location = new Point(10, 10);
            this.lblTitulo.Size = new Size(300, 25);

            // lblAutor
            this.lblAutor.Location = new Point(10, 40);
            this.lblAutor.Size = new Size(300, 20);

            // lblAno
            this.lblAno.Location = new Point(10, 60);
            this.lblAno.Size = new Size(300, 20);

            // lblDisponible
            this.lblDisponible.Location = new Point(10, 80);
            this.lblDisponible.Size = new Size(300, 20);

            // lblSinopsis
            this.lblSinopsis.Location = new Point(10, 105);
            this.lblSinopsis.Size = new Size(300, 60);

            // btnBorrar
            this.btnBorrar.BackColor = Color.FromArgb(200, 80, 80);
            this.btnBorrar.FlatStyle = FlatStyle.Popup;
            this.btnBorrar.ForeColor = Color.White;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Location = new Point(320, 10);
            this.btnBorrar.Size = new Size(70, 30);
            this.btnBorrar.Click += btnBorrar_Click;

            // btnEditar
            this.btnEditar.BackColor = Color.FromArgb(80, 80, 200);
            this.btnEditar.FlatStyle = FlatStyle.Popup;
            this.btnEditar.ForeColor = Color.White;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Location = new Point(320, 50);
            this.btnEditar.Size = new Size(70, 30);
            this.btnEditar.Click += btnEditar_Click;

            // LibroControl
            this.Controls.AddRange(new Control[] {
                lblTitulo, lblAutor, lblAno, lblDisponible, lblSinopsis, btnBorrar, btnEditar
            });

            this.BorderStyle = BorderStyle.FixedSingle;
            this.Size = new Size(400, 180);

            this.ResumeLayout(false);
        }
    }
}

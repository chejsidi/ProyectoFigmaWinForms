namespace ProyectoFigma.Vista
{
    partial class ModalLibro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.numAnio = new System.Windows.Forms.NumericUpDown();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTituloLibro = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 50);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Añadir Libro";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
     | System.Windows.Forms.AnchorStyles.Left)
       | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numCantidad);
            this.panel1.Controls.Add(this.lblCantidad);
            this.panel1.Controls.Add(this.txtGenero);
            this.panel1.Controls.Add(this.lblGenero);
            this.panel1.Controls.Add(this.numAnio);
            this.panel1.Controls.Add(this.lblAnio);
            this.panel1.Controls.Add(this.txtEditorial);
            this.panel1.Controls.Add(this.lblEditorial);
            this.panel1.Controls.Add(this.txtISBN);
            this.panel1.Controls.Add(this.lblISBN);
            this.panel1.Controls.Add(this.txtAutor);
            this.panel1.Controls.Add(this.lblAutor);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.lblTituloLibro);
            this.panel1.Location = new System.Drawing.Point(30, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 320);
            this.panel1.TabIndex = 1;
            // 
            // numCantidad
            // 
            this.numCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numCantidad.Location = new System.Drawing.Point(130, 267);
            this.numCantidad.Maximum = new decimal(new int[] {
            1000,
      0,
       0,
   0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(190, 23);
            this.numCantidad.TabIndex = 13;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCantidad.Location = new System.Drawing.Point(15, 270);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(58, 15);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGenero
            // 
            this.txtGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
  | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenero.BackColor = System.Drawing.Color.White;
            this.txtGenero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGenero.Location = new System.Drawing.Point(130, 222);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(190, 23);
            this.txtGenero.TabIndex = 11;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGenero.Location = new System.Drawing.Point(15, 225);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(48, 15);
            this.lblGenero.TabIndex = 10;
            this.lblGenero.Text = "Género:";
            this.lblGenero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numAnio
            // 
            this.numAnio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
         | System.Windows.Forms.AnchorStyles.Right)));
            this.numAnio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numAnio.Location = new System.Drawing.Point(130, 177);
            this.numAnio.Maximum = new decimal(new int[] {
     2100,
    0,
  0,
            0});
            this.numAnio.Minimum = new decimal(new int[] {
  1000,
 0,
       0,
      0});
            this.numAnio.Name = "numAnio";
            this.numAnio.Size = new System.Drawing.Size(190, 23);
            this.numAnio.TabIndex = 9;
            this.numAnio.Value = new decimal(new int[] {
            2024,
            0,
      0,
0});
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAnio.Location = new System.Drawing.Point(15, 180);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(102, 15);
            this.lblAnio.TabIndex = 8;
            this.lblAnio.Text = "Año publicación:";
            this.lblAnio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditorial.BackColor = System.Drawing.Color.White;
            this.txtEditorial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEditorial.Location = new System.Drawing.Point(130, 132);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(190, 23);
            this.txtEditorial.TabIndex = 7;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEditorial.Location = new System.Drawing.Point(15, 135);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(53, 15);
            this.lblEditorial.TabIndex = 6;
            this.lblEditorial.Text = "Editorial:";
            this.lblEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtISBN
            // 
            this.txtISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtISBN.BackColor = System.Drawing.Color.White;
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtISBN.Location = new System.Drawing.Point(130, 87);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(190, 23);
            this.txtISBN.TabIndex = 5;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblISBN.Location = new System.Drawing.Point(15, 90);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 15);
            this.lblISBN.TabIndex = 4;
            this.lblISBN.Text = "ISBN:";
            this.lblISBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
          | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutor.BackColor = System.Drawing.Color.White;
            this.txtAutor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAutor.Location = new System.Drawing.Point(130, 42);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(190, 23);
            this.txtAutor.TabIndex = 3;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAutor.Location = new System.Drawing.Point(15, 45);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(40, 15);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor:";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
          | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitulo.Location = new System.Drawing.Point(130, 12);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(190, 23);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblTituloLibro
            // 
            this.lblTituloLibro.AutoSize = true;
            this.lblTituloLibro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloLibro.Location = new System.Drawing.Point(15, 15);
            this.lblTituloLibro.Name = "lblTituloLibro";
            this.lblTituloLibro.Size = new System.Drawing.Size(40, 15);
            this.lblTituloLibro.TabIndex = 0;
            this.lblTituloLibro.Text = "Título:";
            this.lblTituloLibro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(80, 410);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(220, 410);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ModalLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 470);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "ModalLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Libro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloLibro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.NumericUpDown numAnio;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

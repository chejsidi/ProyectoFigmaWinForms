namespace ProyectoFigma.Vista
{
    partial class ModalPrestamo
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
this.cmbEstado = new System.Windows.Forms.ComboBox();
   this.lblEstado = new System.Windows.Forms.Label();
   this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
 this.lblFechaDevolucion = new System.Windows.Forms.Label();
     this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
     this.lblFechaPrestamo = new System.Windows.Forms.Label();
   this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.lblLibro = new System.Windows.Forms.Label();
  this.cmbUsuario = new System.Windows.Forms.ComboBox();
 this.lblUsuario = new System.Windows.Forms.Label();
    this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
  this.panel1.SuspendLayout();
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
            this.lblTitulo.Text = "Añadir Préstamo";
  this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
 // 
       // panel1
 // 
    this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
          this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
  this.panel1.Controls.Add(this.cmbEstado);
    this.panel1.Controls.Add(this.lblEstado);
         this.panel1.Controls.Add(this.dtpFechaDevolucion);
  this.panel1.Controls.Add(this.lblFechaDevolucion);
            this.panel1.Controls.Add(this.dtpFechaPrestamo);
     this.panel1.Controls.Add(this.lblFechaPrestamo);
       this.panel1.Controls.Add(this.cmbLibro);
this.panel1.Controls.Add(this.lblLibro);
      this.panel1.Controls.Add(this.cmbUsuario);
      this.panel1.Controls.Add(this.lblUsuario);
this.panel1.Location = new System.Drawing.Point(30, 70);
  this.panel1.Name = "panel1";
     this.panel1.Size = new System.Drawing.Size(340, 250);
  this.panel1.TabIndex = 1;
// 
     // cmbEstado
       // 
       this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
    this.cmbEstado.FormattingEnabled = true;
 this.cmbEstado.Location = new System.Drawing.Point(150, 197);
            this.cmbEstado.Name = "cmbEstado";
 this.cmbEstado.Size = new System.Drawing.Size(170, 23);
    this.cmbEstado.TabIndex = 9;
    // 
        // lblEstado
     // 
        this.lblEstado.AutoSize = true;
     this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEstado.Location = new System.Drawing.Point(15, 200);
     this.lblEstado.Name = "lblEstado";
 this.lblEstado.Size = new System.Drawing.Size(45, 15);
   this.lblEstado.TabIndex = 8;
     this.lblEstado.Text = "Estado:";
       this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
            // dtpFechaDevolucion
          // 
  this.dtpFechaDevolucion.Font = new System.Drawing.Font("Segoe UI", 9F);
       this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
       this.dtpFechaDevolucion.Location = new System.Drawing.Point(150, 152);
      this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
 this.dtpFechaDevolucion.Size = new System.Drawing.Size(170, 23);
    this.dtpFechaDevolucion.TabIndex = 7;
       // 
    // lblFechaDevolucion
  // 
            this.lblFechaDevolucion.AutoSize = true;
       this.lblFechaDevolucion.Font = new System.Drawing.Font("Segoe UI", 9F);
       this.lblFechaDevolucion.Location = new System.Drawing.Point(15, 155);
  this.lblFechaDevolucion.Name = "lblFechaDevolucion";
    this.lblFechaDevolucion.Size = new System.Drawing.Size(109, 15);
         this.lblFechaDevolucion.TabIndex = 6;
    this.lblFechaDevolucion.Text = "Fecha devolución:";
this.lblFechaDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
       // dtpFechaPrestamo
       // 
 this.dtpFechaPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
       this.dtpFechaPrestamo.Location = new System.Drawing.Point(150, 107);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
  this.dtpFechaPrestamo.Size = new System.Drawing.Size(170, 23);
         this.dtpFechaPrestamo.TabIndex = 5;
     // 
     // lblFechaPrestamo
      // 
     this.lblFechaPrestamo.AutoSize = true;
         this.lblFechaPrestamo.Font = new System.Drawing.Font("Segoe UI", 9F);
  this.lblFechaPrestamo.Location = new System.Drawing.Point(15, 110);
  this.lblFechaPrestamo.Name = "lblFechaPrestamo";
 this.lblFechaPrestamo.Size = new System.Drawing.Size(98, 15);
     this.lblFechaPrestamo.TabIndex = 4;
 this.lblFechaPrestamo.Text = "Fecha préstamo:";
            this.lblFechaPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   // 
            // cmbLibro
    // 
  this.cmbLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
     this.cmbLibro.Font = new System.Drawing.Font("Segoe UI", 9F);
   this.cmbLibro.FormattingEnabled = true;
     this.cmbLibro.Location = new System.Drawing.Point(150, 62);
     this.cmbLibro.Name = "cmbLibro";
       this.cmbLibro.Size = new System.Drawing.Size(170, 23);
 this.cmbLibro.TabIndex = 3;
          // 
     // lblLibro
  // 
this.lblLibro.AutoSize = true;
 this.lblLibro.Font = new System.Drawing.Font("Segoe UI", 9F);
       this.lblLibro.Location = new System.Drawing.Point(15, 65);
          this.lblLibro.Name = "lblLibro";
       this.lblLibro.Size = new System.Drawing.Size(36, 15);
 this.lblLibro.TabIndex = 2;
        this.lblLibro.Text = "Libro:";
            this.lblLibro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
     // 
       // cmbUsuario
          // 
        this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
 this.cmbUsuario.FormattingEnabled = true;
    this.cmbUsuario.Location = new System.Drawing.Point(150, 17);
this.cmbUsuario.Name = "cmbUsuario";
     this.cmbUsuario.Size = new System.Drawing.Size(170, 23);
            this.cmbUsuario.TabIndex = 1;
     // 
// lblUsuario
     // 
            this.lblUsuario.AutoSize = true;
       this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
 this.lblUsuario.Location = new System.Drawing.Point(15, 20);
   this.lblUsuario.Name = "lblUsuario";
       this.lblUsuario.Size = new System.Drawing.Size(50, 15);
       this.lblUsuario.TabIndex = 0;
      this.lblUsuario.Text = "Usuario:";
     this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
     // 
            // btnGuardar
 // 
       this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
  this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
       this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(80, 340);
     this.btnGuardar.Name = "btnGuardar";
       this.btnGuardar.Size = new System.Drawing.Size(100, 35);
     this.btnGuardar.TabIndex = 2;
this.btnGuardar.Text = "GUARDAR";
this.btnGuardar.UseVisualStyleBackColor = false;
  this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
       // 
     // btnCancelar
       // 
       this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
       this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
  this.btnCancelar.ForeColor = System.Drawing.Color.White;
 this.btnCancelar.Location = new System.Drawing.Point(220, 340);
     this.btnCancelar.Name = "btnCancelar";
    this.btnCancelar.Size = new System.Drawing.Size(100, 35);
          this.btnCancelar.TabIndex = 3;
   this.btnCancelar.Text = "CANCELAR";
       this.btnCancelar.UseVisualStyleBackColor = false;
    this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
    // ModalPrestamo
    // 
       this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
     this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(400, 400);
      this.Controls.Add(this.btnCancelar);
  this.Controls.Add(this.btnGuardar);
  this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
  this.Name = "ModalPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Préstamo";
  this.panel1.ResumeLayout(false);
  this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

  private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.ComboBox cmbLibro;
private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

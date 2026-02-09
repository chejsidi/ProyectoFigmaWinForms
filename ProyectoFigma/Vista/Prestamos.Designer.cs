namespace ProyectoFigma.Vista
{
    partial class Prestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bBorrar = new System.Windows.Forms.Button();
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.bAnadir = new System.Windows.Forms.Button();
            this.dGridPrestamos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.392991F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.14268F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.53567F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.53567F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.39299F));
            this.tableLayoutPanel1.Controls.Add(this.bBorrar, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrestamos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bAnadir, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dGridPrestamos, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bBorrar
            // 
            this.bBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bBorrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bBorrar.ForeColor = System.Drawing.Color.White;
            this.bBorrar.Location = new System.Drawing.Point(684, 3);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(89, 25);
            this.bBorrar.TabIndex = 6;
            this.bBorrar.Text = "BORRAR";
            this.bBorrar.UseVisualStyleBackColor = false;
            this.bBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.AutoSize = true;
            this.lblPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamos.Location = new System.Drawing.Point(23, 0);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(178, 31);
            this.lblPrestamos.TabIndex = 2;
            this.lblPrestamos.Text = "< Prestamos";
            this.lblPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrestamos.Click += new System.EventHandler(this.lblPrestamos_Click);
            // 
            // bAnadir
            // 
            this.bAnadir.BackColor = System.Drawing.Color.Transparent;
            this.bAnadir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAnadir.ForeColor = System.Drawing.Color.Black;
            this.bAnadir.Location = new System.Drawing.Point(589, 3);
            this.bAnadir.Name = "bAnadir";
            this.bAnadir.Size = new System.Drawing.Size(89, 25);
            this.bAnadir.TabIndex = 3;
            this.bAnadir.Text = "AÑADIR";
            this.bAnadir.UseVisualStyleBackColor = false;
            this.bAnadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // dGridPrestamos
            // 
            this.dGridPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dGridPrestamos, 4);
            this.dGridPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridPrestamos.Location = new System.Drawing.Point(23, 34);
            this.dGridPrestamos.Name = "dGridPrestamos";
            this.dGridPrestamos.Size = new System.Drawing.Size(750, 413);
            this.dGridPrestamos.TabIndex = 7;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prestamos";
            this.Text = "Prestamos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPrestamos;
        private System.Windows.Forms.Button bAnadir;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.DataGridView dGridPrestamos;
    }
}
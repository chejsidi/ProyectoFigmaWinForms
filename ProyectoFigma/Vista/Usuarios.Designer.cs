namespace ProyectoFigma.Vista
{
    partial class Usuarios
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
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.bAnadir = new System.Windows.Forms.Button();
            this.dGridUsuarios = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridUsuarios)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.lblUsuarios, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bAnadir, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dGridUsuarios, 1, 1);
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
            this.bBorrar.Location = new System.Drawing.Point(681, 3);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(93, 25);
            this.bBorrar.TabIndex = 6;
            this.bBorrar.Text = "BORRAR";
            this.bBorrar.UseVisualStyleBackColor = false;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(24, 0);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(155, 31);
            this.lblUsuarios.TabIndex = 2;
            this.lblUsuarios.Text = "< Usuarios";
            this.lblUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bAnadir
            // 
            this.bAnadir.BackColor = System.Drawing.Color.Transparent;
            this.bAnadir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAnadir.ForeColor = System.Drawing.Color.Black;
            this.bAnadir.Location = new System.Drawing.Point(582, 3);
            this.bAnadir.Name = "bAnadir";
            this.bAnadir.Size = new System.Drawing.Size(93, 25);
            this.bAnadir.TabIndex = 3;
            this.bAnadir.Text = "AÑADIR";
            this.bAnadir.UseVisualStyleBackColor = false;
            // 
            // dGridUsuarios
            // 
            this.dGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dGridUsuarios, 4);
            this.dGridUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridUsuarios.Location = new System.Drawing.Point(24, 34);
            this.dGridUsuarios.Name = "dGridUsuarios";
            this.dGridUsuarios.Size = new System.Drawing.Size(750, 413);
            this.dGridUsuarios.TabIndex = 7;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Button bAnadir;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.DataGridView dGridUsuarios;
    }
}
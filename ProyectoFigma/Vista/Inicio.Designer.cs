namespace ProyectoFigma.Vista
{
    partial class Inicio
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
            this.tableLayoutPanelInicio = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLogoInicio = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelInicio
            // 
            this.tableLayoutPanelInicio.ColumnCount = 2;
            this.tableLayoutPanelInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInicio.Controls.Add(this.pictureBoxLogoInicio, 0, 0);
            this.tableLayoutPanelInicio.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInicio.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelInicio.Name = "tableLayoutPanelInicio";
            this.tableLayoutPanelInicio.RowCount = 1;
            this.tableLayoutPanelInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInicio.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelInicio.TabIndex = 0;
            // 
            // pictureBoxLogoInicio
            // 
            this.pictureBoxLogoInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogoInicio.Image = global::ProyectoFigma.Properties.Resources.logoPantallaInicio;
            this.pictureBoxLogoInicio.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogoInicio.Name = "pictureBoxLogoInicio";
            this.pictureBoxLogoInicio.Size = new System.Drawing.Size(394, 444);
            this.pictureBoxLogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogoInicio.TabIndex = 0;
            this.pictureBoxLogoInicio.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(403, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 450);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tú librería En Vitoria-Gasteiz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.tableLayoutPanelInicio.ResumeLayout(false);
            this.tableLayoutPanelInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInicio;
        private System.Windows.Forms.PictureBox pictureBoxLogoInicio;
        private System.Windows.Forms.Label label1;
    }
}
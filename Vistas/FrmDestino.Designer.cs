namespace Vistas
{
    partial class FrmDestino
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesCodigo = new System.Windows.Forms.TextBox();
            this.txtDesDescripcion = new System.Windows.Forms.TextBox();
            this.btnDesGuardar = new System.Windows.Forms.Button();
            this.dgvDestino = new System.Windows.Forms.DataGridView();
            this.btnModificarDestino = new System.Windows.Forms.Button();
            this.btnEliminarDestino = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // txtDesCodigo
            // 
            this.txtDesCodigo.Location = new System.Drawing.Point(226, 125);
            this.txtDesCodigo.Name = "txtDesCodigo";
            this.txtDesCodigo.ReadOnly = true;
            this.txtDesCodigo.Size = new System.Drawing.Size(158, 22);
            this.txtDesCodigo.TabIndex = 2;
            this.txtDesCodigo.Visible = false;
            // 
            // txtDesDescripcion
            // 
            this.txtDesDescripcion.Location = new System.Drawing.Point(226, 175);
            this.txtDesDescripcion.Name = "txtDesDescripcion";
            this.txtDesDescripcion.Size = new System.Drawing.Size(158, 22);
            this.txtDesDescripcion.TabIndex = 3;
            // 
            // btnDesGuardar
            // 
            this.btnDesGuardar.Location = new System.Drawing.Point(90, 300);
            this.btnDesGuardar.Name = "btnDesGuardar";
            this.btnDesGuardar.Size = new System.Drawing.Size(82, 30);
            this.btnDesGuardar.TabIndex = 4;
            this.btnDesGuardar.Text = "Guardar";
            this.btnDesGuardar.UseVisualStyleBackColor = true;
            this.btnDesGuardar.Click += new System.EventHandler(this.btnDesGuardar_Click);
            // 
            // dgvDestino
            // 
            this.dgvDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestino.Location = new System.Drawing.Point(420, 87);
            this.dgvDestino.Name = "dgvDestino";
            this.dgvDestino.RowTemplate.Height = 24;
            this.dgvDestino.Size = new System.Drawing.Size(561, 344);
            this.dgvDestino.TabIndex = 5;
            this.dgvDestino.CurrentCellChanged += new System.EventHandler(this.dgvDestino_CurrentCellChanged);
            // 
            // btnModificarDestino
            // 
            this.btnModificarDestino.Location = new System.Drawing.Point(195, 300);
            this.btnModificarDestino.Name = "btnModificarDestino";
            this.btnModificarDestino.Size = new System.Drawing.Size(85, 30);
            this.btnModificarDestino.TabIndex = 6;
            this.btnModificarDestino.Text = "Modificar";
            this.btnModificarDestino.UseVisualStyleBackColor = true;
            this.btnModificarDestino.Click += new System.EventHandler(this.btnModificarDestino_Click);
            // 
            // btnEliminarDestino
            // 
            this.btnEliminarDestino.Location = new System.Drawing.Point(306, 300);
            this.btnEliminarDestino.Name = "btnEliminarDestino";
            this.btnEliminarDestino.Size = new System.Drawing.Size(92, 27);
            this.btnEliminarDestino.TabIndex = 7;
            this.btnEliminarDestino.Text = "Eliminar";
            this.btnEliminarDestino.UseVisualStyleBackColor = true;
            this.btnEliminarDestino.Click += new System.EventHandler(this.btnEliminarDestino_Click);
            // 
            // FrmDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 528);
            this.Controls.Add(this.btnEliminarDestino);
            this.Controls.Add(this.btnModificarDestino);
            this.Controls.Add(this.dgvDestino);
            this.Controls.Add(this.btnDesGuardar);
            this.Controls.Add(this.txtDesDescripcion);
            this.Controls.Add(this.txtDesCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDestino";
            this.Text = "Alta de Destino";
            this.Load += new System.EventHandler(this.FrmDestino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesCodigo;
        private System.Windows.Forms.TextBox txtDesDescripcion;
        private System.Windows.Forms.Button btnDesGuardar;
        private System.Windows.Forms.DataGridView dgvDestino;
        private System.Windows.Forms.Button btnModificarDestino;
        private System.Windows.Forms.Button btnEliminarDestino;
    }
}
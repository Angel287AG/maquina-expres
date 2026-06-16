namespace maquna_expres
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstproductos = new System.Windows.Forms.ListBox();
            this.btmcomprar = new System.Windows.Forms.Button();
            this.nudcantidad = new System.Windows.Forms.NumericUpDown();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblinventario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lstproductos
            // 
            this.lstproductos.FormattingEnabled = true;
            this.lstproductos.ItemHeight = 16;
            this.lstproductos.Location = new System.Drawing.Point(176, 350);
            this.lstproductos.Name = "lstproductos";
            this.lstproductos.Size = new System.Drawing.Size(120, 84);
            this.lstproductos.TabIndex = 16;
            // 
            // btmcomprar
            // 
            this.btmcomprar.Location = new System.Drawing.Point(428, 296);
            this.btmcomprar.Name = "btmcomprar";
            this.btmcomprar.Size = new System.Drawing.Size(199, 59);
            this.btmcomprar.TabIndex = 15;
            this.btmcomprar.Text = "COMPRAR";
            this.btmcomprar.UseVisualStyleBackColor = true;
            // 
            // nudcantidad
            // 
            this.nudcantidad.Location = new System.Drawing.Point(176, 231);
            this.nudcantidad.Name = "nudcantidad";
            this.nudcantidad.Size = new System.Drawing.Size(120, 22);
            this.nudcantidad.TabIndex = 14;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(173, 141);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(57, 16);
            this.lblprecio.TabIndex = 13;
            this.lblprecio.Text = "PRECIO";
            // 
            // lblinventario
            // 
            this.lblinventario.AutoSize = true;
            this.lblinventario.Location = new System.Drawing.Point(173, 167);
            this.lblinventario.Name = "lblinventario";
            this.lblinventario.Size = new System.Drawing.Size(89, 16);
            this.lblinventario.TabIndex = 12;
            this.lblinventario.Text = "INVENTARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "PRODUCTOS";
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(176, 97);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(297, 24);
            this.cmbProductos.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "MAQUNA EXPRES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstproductos);
            this.Controls.Add(this.btmcomprar);
            this.Controls.Add(this.nudcantidad);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblinventario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstproductos;
        private System.Windows.Forms.Button btmcomprar;
        private System.Windows.Forms.NumericUpDown nudcantidad;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblinventario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label label1;
    }
}


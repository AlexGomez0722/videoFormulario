namespace videoformulario
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
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.Txtedad = new System.Windows.Forms.TextBox();
            this.Btnguardar = new System.Windows.Forms.Button();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.Grilla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(40, 28);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad:";
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(100, 25);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(322, 20);
            this.Txtnombre.TabIndex = 2;
            // 
            // Txtedad
            // 
            this.Txtedad.Location = new System.Drawing.Point(100, 64);
            this.Txtedad.Name = "Txtedad";
            this.Txtedad.Size = new System.Drawing.Size(182, 20);
            this.Txtedad.TabIndex = 3;
            // 
            // Btnguardar
            // 
            this.Btnguardar.Location = new System.Drawing.Point(474, 25);
            this.Btnguardar.Name = "Btnguardar";
            this.Btnguardar.Size = new System.Drawing.Size(128, 59);
            this.Btnguardar.TabIndex = 4;
            this.Btnguardar.Text = "Guardar";
            this.Btnguardar.UseVisualStyleBackColor = true;
            this.Btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.Location = new System.Drawing.Point(618, 25);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(128, 59);
            this.Btnlimpiar.TabIndex = 5;
            this.Btnlimpiar.Text = "Limpiar";
            this.Btnlimpiar.UseVisualStyleBackColor = true;
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(43, 129);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(558, 256);
            this.Grilla.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.Btnlimpiar);
            this.Controls.Add(this.Btnguardar);
            this.Controls.Add(this.Txtedad);
            this.Controls.Add(this.Txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.TextBox Txtedad;
        private System.Windows.Forms.Button Btnguardar;
        private System.Windows.Forms.Button Btnlimpiar;
        private System.Windows.Forms.DataGridView Grilla;
    }
}


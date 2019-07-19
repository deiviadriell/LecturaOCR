namespace OCRPlantas
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
            this.btnCargarImagenes = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbImagenesSeleccionadas = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbOpcion1 = new System.Windows.Forms.RadioButton();
            this.rdbOpcion2 = new System.Windows.Forms.RadioButton();
            this.rdbOpcion4 = new System.Windows.Forms.RadioButton();
            this.rdbOpcion3 = new System.Windows.Forms.RadioButton();
            this.btnResultado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargarImagenes
            // 
            this.btnCargarImagenes.Location = new System.Drawing.Point(349, 453);
            this.btnCargarImagenes.Name = "btnCargarImagenes";
            this.btnCargarImagenes.Size = new System.Drawing.Size(109, 23);
            this.btnCargarImagenes.TabIndex = 1;
            this.btnCargarImagenes.Text = "Cargar Imágenes";
            this.btnCargarImagenes.UseVisualStyleBackColor = true;
            this.btnCargarImagenes.Click += new System.EventHandler(this.btnCargarImagenes_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbImagenesSeleccionadas
            // 
            this.lbImagenesSeleccionadas.FormattingEnabled = true;
            this.lbImagenesSeleccionadas.Location = new System.Drawing.Point(10, 105);
            this.lbImagenesSeleccionadas.Name = "lbImagenesSeleccionadas";
            this.lbImagenesSeleccionadas.Size = new System.Drawing.Size(448, 342);
            this.lbImagenesSeleccionadas.TabIndex = 2;
            this.lbImagenesSeleccionadas.SelectedIndexChanged += new System.EventHandler(this.lbImagenesSeleccionadas_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 458);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbOpcion4);
            this.groupBox1.Controls.Add(this.rdbOpcion3);
            this.groupBox1.Controls.Add(this.rdbOpcion2);
            this.groupBox1.Controls.Add(this.rdbOpcion1);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección OCR";
            // 
            // rdbOpcion1
            // 
            this.rdbOpcion1.AutoSize = true;
            this.rdbOpcion1.Checked = true;
            this.rdbOpcion1.Location = new System.Drawing.Point(18, 19);
            this.rdbOpcion1.Name = "rdbOpcion1";
            this.rdbOpcion1.Size = new System.Drawing.Size(68, 17);
            this.rdbOpcion1.TabIndex = 0;
            this.rdbOpcion1.TabStop = true;
            this.rdbOpcion1.Text = "Opción 1";
            this.rdbOpcion1.UseVisualStyleBackColor = true;
            // 
            // rdbOpcion2
            // 
            this.rdbOpcion2.AutoSize = true;
            this.rdbOpcion2.Location = new System.Drawing.Point(162, 19);
            this.rdbOpcion2.Name = "rdbOpcion2";
            this.rdbOpcion2.Size = new System.Drawing.Size(68, 17);
            this.rdbOpcion2.TabIndex = 1;
            this.rdbOpcion2.Text = "Opción 2";
            this.rdbOpcion2.UseVisualStyleBackColor = true;
            // 
            // rdbOpcion4
            // 
            this.rdbOpcion4.AutoSize = true;
            this.rdbOpcion4.Location = new System.Drawing.Point(165, 51);
            this.rdbOpcion4.Name = "rdbOpcion4";
            this.rdbOpcion4.Size = new System.Drawing.Size(68, 17);
            this.rdbOpcion4.TabIndex = 3;
            this.rdbOpcion4.Text = "Opción 4";
            this.rdbOpcion4.UseVisualStyleBackColor = true;
            // 
            // rdbOpcion3
            // 
            this.rdbOpcion3.AutoSize = true;
            this.rdbOpcion3.Location = new System.Drawing.Point(21, 51);
            this.rdbOpcion3.Name = "rdbOpcion3";
            this.rdbOpcion3.Size = new System.Drawing.Size(68, 17);
            this.rdbOpcion3.TabIndex = 2;
            this.rdbOpcion3.Text = "Opción 3";
            this.rdbOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(270, 453);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(73, 23);
            this.btnResultado.TabIndex = 5;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 484);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbImagenesSeleccionadas);
            this.Controls.Add(this.btnCargarImagenes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "OCR Plantas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarImagenes;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbImagenesSeleccionadas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbOpcion4;
        private System.Windows.Forms.RadioButton rdbOpcion3;
        private System.Windows.Forms.RadioButton rdbOpcion2;
        private System.Windows.Forms.RadioButton rdbOpcion1;
        private System.Windows.Forms.Button btnResultado;
    }
}


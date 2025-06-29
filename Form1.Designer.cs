namespace ProyectoGrafica_3D
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRotateX = new System.Windows.Forms.Button();
            this.btnRotateY = new System.Windows.Forms.Button();
            this.btnRotateZ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(12, 101);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(776, 337);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(28, 42);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRotateX
            // 
            this.btnRotateX.Location = new System.Drawing.Point(617, 12);
            this.btnRotateX.Name = "btnRotateX";
            this.btnRotateX.Size = new System.Drawing.Size(117, 23);
            this.btnRotateX.TabIndex = 2;
            this.btnRotateX.Text = "Rotar X";
            this.btnRotateX.UseVisualStyleBackColor = true;
            this.btnRotateX.Click += new System.EventHandler(this.btnRotateX_Click);
            // 
            // btnRotateY
            // 
            this.btnRotateY.Location = new System.Drawing.Point(617, 41);
            this.btnRotateY.Name = "btnRotateY";
            this.btnRotateY.Size = new System.Drawing.Size(117, 23);
            this.btnRotateY.TabIndex = 3;
            this.btnRotateY.Text = "Rotar Y";
            this.btnRotateY.UseVisualStyleBackColor = true;
            this.btnRotateY.Click += new System.EventHandler(this.btnRotateY_Click);
            // 
            // btnRotateZ
            // 
            this.btnRotateZ.Location = new System.Drawing.Point(617, 70);
            this.btnRotateZ.Name = "btnRotateZ";
            this.btnRotateZ.Size = new System.Drawing.Size(117, 23);
            this.btnRotateZ.TabIndex = 4;
            this.btnRotateZ.Text = "Rotar Z";
            this.btnRotateZ.UseVisualStyleBackColor = true;
            this.btnRotateZ.Click += new System.EventHandler(this.btnRotateZ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRotateZ);
            this.Controls.Add(this.btnRotateY);
            this.Controls.Add(this.btnRotateX);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.picCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRotateX;
        private System.Windows.Forms.Button btnRotateY;
        private System.Windows.Forms.Button btnRotateZ;
    }
}


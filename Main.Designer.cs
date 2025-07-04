namespace ProyectoGrafica_3D
{
    partial class Main
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
            this.picCanvas.Location = new System.Drawing.Point(14, 126);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(873, 421);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(32, 52);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(126, 29);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRotateX
            // 
            this.btnRotateX.Location = new System.Drawing.Point(694, 15);
            this.btnRotateX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRotateX.Name = "btnRotateX";
            this.btnRotateX.Size = new System.Drawing.Size(132, 29);
            this.btnRotateX.TabIndex = 2;
            this.btnRotateX.Text = "Rotar X";
            this.btnRotateX.UseVisualStyleBackColor = true;
            this.btnRotateX.Click += new System.EventHandler(this.btnRotateX_Click);
            // 
            // btnRotateY
            // 
            this.btnRotateY.Location = new System.Drawing.Point(694, 51);
            this.btnRotateY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRotateY.Name = "btnRotateY";
            this.btnRotateY.Size = new System.Drawing.Size(132, 29);
            this.btnRotateY.TabIndex = 3;
            this.btnRotateY.Text = "Rotar Y";
            this.btnRotateY.UseVisualStyleBackColor = true;
            this.btnRotateY.Click += new System.EventHandler(this.btnRotateY_Click);
            // 
            // btnRotateZ
            // 
            this.btnRotateZ.Location = new System.Drawing.Point(694, 88);
            this.btnRotateZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRotateZ.Name = "btnRotateZ";
            this.btnRotateZ.Size = new System.Drawing.Size(132, 29);
            this.btnRotateZ.TabIndex = 4;
            this.btnRotateZ.Text = "Rotar Z";
            this.btnRotateZ.UseVisualStyleBackColor = true;
            this.btnRotateZ.Click += new System.EventHandler(this.btnRotateZ_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnRotateZ);
            this.Controls.Add(this.btnRotateY);
            this.Controls.Add(this.btnRotateX);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.picCanvas);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Figuras Tridimensionales";
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
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


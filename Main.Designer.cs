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
            this.btnTranslateX = new System.Windows.Forms.Button();
            this.btnTranslateY = new System.Windows.Forms.Button();
            this.btnTranslateZ = new System.Windows.Forms.Button();
            this.btnScaleZ = new System.Windows.Forms.Button();
            this.btnScaleY = new System.Windows.Forms.Button();
            this.btnScaleX = new System.Windows.Forms.Button();
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
            // btnTranslateX
            // 
            this.btnTranslateX.Location = new System.Drawing.Point(473, 12);
            this.btnTranslateX.Name = "btnTranslateX";
            this.btnTranslateX.Size = new System.Drawing.Size(117, 23);
            this.btnTranslateX.TabIndex = 5;
            this.btnTranslateX.Text = "Desplazar X";
            this.btnTranslateX.UseVisualStyleBackColor = true;
            this.btnTranslateX.Click += new System.EventHandler(this.btnTranslateX_Click);
            // 
            // btnTranslateY
            // 
            this.btnTranslateY.Location = new System.Drawing.Point(473, 42);
            this.btnTranslateY.Name = "btnTranslateY";
            this.btnTranslateY.Size = new System.Drawing.Size(117, 23);
            this.btnTranslateY.TabIndex = 6;
            this.btnTranslateY.Text = "Desplazar Y";
            this.btnTranslateY.UseVisualStyleBackColor = true;
            this.btnTranslateY.Click += new System.EventHandler(this.btnTranslateY_Click);
            // 
            // btnTranslateZ
            // 
            this.btnTranslateZ.Location = new System.Drawing.Point(473, 72);
            this.btnTranslateZ.Name = "btnTranslateZ";
            this.btnTranslateZ.Size = new System.Drawing.Size(117, 23);
            this.btnTranslateZ.TabIndex = 7;
            this.btnTranslateZ.Text = "Desplazar Z";
            this.btnTranslateZ.UseVisualStyleBackColor = true;
            this.btnTranslateZ.Click += new System.EventHandler(this.btnTranslateZ_Click);
            // 
            // btnScaleZ
            // 
            this.btnScaleZ.Location = new System.Drawing.Point(324, 72);
            this.btnScaleZ.Name = "btnScaleZ";
            this.btnScaleZ.Size = new System.Drawing.Size(117, 23);
            this.btnScaleZ.TabIndex = 10;
            this.btnScaleZ.Text = "Escalar Z";
            this.btnScaleZ.UseVisualStyleBackColor = true;
            this.btnScaleZ.Click += new System.EventHandler(this.btnScaleZ_Click);
            // 
            // btnScaleY
            // 
            this.btnScaleY.Location = new System.Drawing.Point(324, 42);
            this.btnScaleY.Name = "btnScaleY";
            this.btnScaleY.Size = new System.Drawing.Size(117, 23);
            this.btnScaleY.TabIndex = 9;
            this.btnScaleY.Text = "Escalar Y";
            this.btnScaleY.UseVisualStyleBackColor = true;
            this.btnScaleY.Click += new System.EventHandler(this.btnScaleY_Click);
            // 
            // btnScaleX
            // 
            this.btnScaleX.Location = new System.Drawing.Point(324, 12);
            this.btnScaleX.Name = "btnScaleX";
            this.btnScaleX.Size = new System.Drawing.Size(117, 23);
            this.btnScaleX.TabIndex = 8;
            this.btnScaleX.Text = "Escalar X";
            this.btnScaleX.UseVisualStyleBackColor = true;
            this.btnScaleX.Click += new System.EventHandler(this.btnScaleX_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnScaleZ);
            this.Controls.Add(this.btnScaleY);
            this.Controls.Add(this.btnScaleX);
            this.Controls.Add(this.btnTranslateZ);
            this.Controls.Add(this.btnTranslateY);
            this.Controls.Add(this.btnTranslateX);
            this.Controls.Add(this.btnRotateZ);
            this.Controls.Add(this.btnRotateY);
            this.Controls.Add(this.btnRotateX);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.picCanvas);
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
        private System.Windows.Forms.Button btnTranslateX;
        private System.Windows.Forms.Button btnTranslateY;
        private System.Windows.Forms.Button btnTranslateZ;
        private System.Windows.Forms.Button btnScaleZ;
        private System.Windows.Forms.Button btnScaleY;
        private System.Windows.Forms.Button btnScaleX;
    }
}


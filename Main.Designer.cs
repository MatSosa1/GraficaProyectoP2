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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnTranslateX = new System.Windows.Forms.Button();
            this.btnTranslateY = new System.Windows.Forms.Button();
            this.btnTranslateZ = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.parrotGradientPanel2 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.nightHeaderLabel1 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnLeftArrow = new System.Windows.Forms.PictureBox();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.btnRightArrow = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trScaleX = new ReaLTaiizor.Controls.TrackBar();
            this.trScaleY = new ReaLTaiizor.Controls.TrackBar();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.trScaleZ = new ReaLTaiizor.Controls.TrackBar();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.btnColorOutline = new System.Windows.Forms.PictureBox();
            this.btnColorInline = new System.Windows.Forms.PictureBox();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            this.parrotGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.menuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColorOutline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColorInline)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(22, 250);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(959, 524);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btnTranslateX
            // 
            this.btnTranslateX.Location = new System.Drawing.Point(32, 258);
            this.btnTranslateX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTranslateX.Name = "btnTranslateX";
            this.btnTranslateX.Size = new System.Drawing.Size(132, 29);
            this.btnTranslateX.TabIndex = 5;
            this.btnTranslateX.Text = "Desplazar X";
            this.btnTranslateX.UseVisualStyleBackColor = true;
            this.btnTranslateX.Click += new System.EventHandler(this.btnTranslateX_Click);
            // 
            // btnTranslateY
            // 
            this.btnTranslateY.Location = new System.Drawing.Point(32, 295);
            this.btnTranslateY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTranslateY.Name = "btnTranslateY";
            this.btnTranslateY.Size = new System.Drawing.Size(132, 29);
            this.btnTranslateY.TabIndex = 6;
            this.btnTranslateY.Text = "Desplazar Y";
            this.btnTranslateY.UseVisualStyleBackColor = true;
            this.btnTranslateY.Click += new System.EventHandler(this.btnTranslateY_Click);
            // 
            // btnTranslateZ
            // 
            this.btnTranslateZ.Location = new System.Drawing.Point(32, 333);
            this.btnTranslateZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTranslateZ.Name = "btnTranslateZ";
            this.btnTranslateZ.Size = new System.Drawing.Size(132, 29);
            this.btnTranslateZ.TabIndex = 7;
            this.btnTranslateZ.Text = "Desplazar Z";
            this.btnTranslateZ.UseVisualStyleBackColor = true;
            this.btnTranslateZ.Click += new System.EventHandler(this.btnTranslateZ_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(72)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.parrotGradientPanel2);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 124);
            this.panel1.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(927, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 60);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 21;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(868, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(60, 60);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximize.TabIndex = 20;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // parrotGradientPanel2
            // 
            this.parrotGradientPanel2.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(72)))), ((int)(((byte)(121)))));
            this.parrotGradientPanel2.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.parrotGradientPanel2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel2.Controls.Add(this.nightHeaderLabel1);
            this.parrotGradientPanel2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel2.Location = new System.Drawing.Point(22, 21);
            this.parrotGradientPanel2.Name = "parrotGradientPanel2";
            this.parrotGradientPanel2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel2.PrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(79)))), ((int)(((byte)(108)))));
            this.parrotGradientPanel2.Size = new System.Drawing.Size(488, 54);
            this.parrotGradientPanel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel2.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel2.TabIndex = 12;
            this.parrotGradientPanel2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel2.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(72)))), ((int)(((byte)(121)))));
            this.parrotGradientPanel2.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            // 
            // nightHeaderLabel1
            // 
            this.nightHeaderLabel1.AutoSize = true;
            this.nightHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel1.Font = new System.Drawing.Font("ROG Fonts STRIX SCAR", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel1.ForeColor = System.Drawing.Color.Black;
            this.nightHeaderLabel1.LeftSideForeColor = System.Drawing.Color.Black;
            this.nightHeaderLabel1.Location = new System.Drawing.Point(10, 7);
            this.nightHeaderLabel1.Name = "nightHeaderLabel1";
            this.nightHeaderLabel1.RightSideForeColor = System.Drawing.Color.White;
            this.nightHeaderLabel1.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel1.Size = new System.Drawing.Size(472, 46);
            this.nightHeaderLabel1.TabIndex = 12;
            this.nightHeaderLabel1.Text = "3D Figures Project";
            this.nightHeaderLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel1.UseCompatibleTextRendering = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(809, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(60, 60);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(71, 65);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 13;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.Controls.Add(this.btnMenu);
            this.menuContainer.Controls.Add(this.pictureBox2);
            this.menuContainer.Controls.Add(this.pictureBox3);
            this.menuContainer.Controls.Add(this.pictureBox4);
            this.menuContainer.Controls.Add(this.pictureBox5);
            this.menuContainer.Controls.Add(this.btnLeftArrow);
            this.menuContainer.Location = new System.Drawing.Point(3, 129);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(79, 66);
            this.menuContainer.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 145);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 216);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 287);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(71, 65);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLeftArrow
            // 
            this.btnLeftArrow.Image = ((System.Drawing.Image)(resources.GetObject("btnLeftArrow.Image")));
            this.btnLeftArrow.Location = new System.Drawing.Point(3, 358);
            this.btnLeftArrow.Name = "btnLeftArrow";
            this.btnLeftArrow.Size = new System.Drawing.Size(71, 65);
            this.btnLeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLeftArrow.TabIndex = 18;
            this.btnLeftArrow.TabStop = false;
            this.btnLeftArrow.Click += new System.EventHandler(this.btnLeftArrow_Click);
            // 
            // menuTimer
            // 
            this.menuTimer.Interval = 10;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // btnRightArrow
            // 
            this.btnRightArrow.Image = ((System.Drawing.Image)(resources.GetObject("btnRightArrow.Image")));
            this.btnRightArrow.Location = new System.Drawing.Point(88, 129);
            this.btnRightArrow.Name = "btnRightArrow";
            this.btnRightArrow.Size = new System.Drawing.Size(37, 65);
            this.btnRightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRightArrow.TabIndex = 19;
            this.btnRightArrow.TabStop = false;
            this.btnRightArrow.Click += new System.EventHandler(this.btnRightArrow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // trScaleX
            // 
            this.trScaleX.JumpToMouse = false;
            this.trScaleX.Location = new System.Drawing.Point(68, 212);
            this.trScaleX.Maximum = 10;
            this.trScaleX.Minimum = 0;
            this.trScaleX.MinimumSize = new System.Drawing.Size(47, 22);
            this.trScaleX.Name = "trScaleX";
            this.trScaleX.Size = new System.Drawing.Size(100, 22);
            this.trScaleX.TabIndex = 24;
            this.trScaleX.Text = "trackBar1";
            this.trScaleX.Value = 0;
            this.trScaleX.ValueDivison = ReaLTaiizor.Controls.TrackBar.ValueDivisor.By1;
            this.trScaleX.ValueToSet = 0F;
            this.trScaleX.ValueChanged += new ReaLTaiizor.Controls.TrackBar.ValueChangedEventHandler(this.trScaleX_ValueChanged);
            // 
            // trScaleY
            // 
            this.trScaleY.JumpToMouse = false;
            this.trScaleY.Location = new System.Drawing.Point(220, 212);
            this.trScaleY.Maximum = 10;
            this.trScaleY.Minimum = 0;
            this.trScaleY.MinimumSize = new System.Drawing.Size(47, 22);
            this.trScaleY.Name = "trScaleY";
            this.trScaleY.Size = new System.Drawing.Size(100, 22);
            this.trScaleY.TabIndex = 26;
            this.trScaleY.Text = "trackBar2";
            this.trScaleY.Value = 0;
            this.trScaleY.ValueDivison = ReaLTaiizor.Controls.TrackBar.ValueDivisor.By1;
            this.trScaleY.ValueToSet = 0F;
            this.trScaleY.ValueChanged += new ReaLTaiizor.Controls.TrackBar.ValueChangedEventHandler(this.trScaleY_ValueChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(174, 203);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // trScaleZ
            // 
            this.trScaleZ.JumpToMouse = false;
            this.trScaleZ.Location = new System.Drawing.Point(372, 212);
            this.trScaleZ.Maximum = 10;
            this.trScaleZ.Minimum = 0;
            this.trScaleZ.MinimumSize = new System.Drawing.Size(47, 22);
            this.trScaleZ.Name = "trScaleZ";
            this.trScaleZ.Size = new System.Drawing.Size(100, 22);
            this.trScaleZ.TabIndex = 28;
            this.trScaleZ.Text = "trackBar3";
            this.trScaleZ.Value = 0;
            this.trScaleZ.ValueDivison = ReaLTaiizor.Controls.TrackBar.ValueDivisor.By1;
            this.trScaleZ.ValueToSet = 0F;
            this.trScaleZ.ValueChanged += new ReaLTaiizor.Controls.TrackBar.ValueChangedEventHandler(this.trScaleZ_ValueChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(326, 203);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 27;
            this.pictureBox7.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(522, 142);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(131, 24);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "Rotate Figures";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(548, 188);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 30;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.btnRotateY_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(600, 188);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(50, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 31;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.btnRotateZ_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(652, 188);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(50, 50);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 32;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.btnRotateX_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(803, 142);
            this.materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(107, 24);
            this.materialLabel2.TabIndex = 33;
            this.materialLabel2.Text = "Color picker";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(747, 127);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(55, 55);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 19;
            this.pictureBox11.TabStop = false;
            // 
            // btnColorOutline
            // 
            this.btnColorOutline.Image = ((System.Drawing.Image)(resources.GetObject("btnColorOutline.Image")));
            this.btnColorOutline.Location = new System.Drawing.Point(808, 185);
            this.btnColorOutline.Name = "btnColorOutline";
            this.btnColorOutline.Size = new System.Drawing.Size(55, 55);
            this.btnColorOutline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnColorOutline.TabIndex = 34;
            this.btnColorOutline.TabStop = false;
            this.btnColorOutline.Click += new System.EventHandler(this.btnColorOutline_Click);
            // 
            // btnColorInline
            // 
            this.btnColorInline.Image = ((System.Drawing.Image)(resources.GetObject("btnColorInline.Image")));
            this.btnColorInline.Location = new System.Drawing.Point(875, 185);
            this.btnColorInline.Name = "btnColorInline";
            this.btnColorInline.Size = new System.Drawing.Size(55, 55);
            this.btnColorInline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnColorInline.TabIndex = 35;
            this.btnColorInline.TabStop = false;
            this.btnColorInline.Click += new System.EventHandler(this.btnColorInline_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.btnColorInline);
            this.Controls.Add(this.btnColorOutline);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.trScaleZ);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.trScaleY);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.trScaleX);
            this.Controls.Add(this.menuContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTranslateZ);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRightArrow);
            this.Controls.Add(this.btnTranslateY);
            this.Controls.Add(this.btnTranslateX);
            this.Controls.Add(this.picCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "Main";
            this.Text = "dungeonForm1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            this.parrotGradientPanel2.ResumeLayout(false);
            this.parrotGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.menuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColorOutline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColorInline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnTranslateX;
        private System.Windows.Forms.Button btnTranslateY;
        private System.Windows.Forms.Button btnTranslateZ;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel2;
        private ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox btnLeftArrow;
        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.PictureBox btnRightArrow;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.TrackBar trScaleX;
        private ReaLTaiizor.Controls.TrackBar trScaleY;
        private System.Windows.Forms.PictureBox pictureBox6;
        private ReaLTaiizor.Controls.TrackBar trScaleZ;
        private System.Windows.Forms.PictureBox pictureBox7;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox btnColorOutline;
        private System.Windows.Forms.PictureBox btnColorInline;
        private System.Windows.Forms.ColorDialog colorPicker;
    }
}


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
            this.materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.btnColorOutline = new System.Windows.Forms.PictureBox();
            this.btnColorInline = new System.Windows.Forms.PictureBox();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.btnRotateAxisZ = new System.Windows.Forms.Button();
            this.btnRotateAxisY = new System.Windows.Forms.Button();
            this.btnRotateAxisX = new System.Windows.Forms.Button();
            this.btnForwardRight = new System.Windows.Forms.Button();
            this.btnForwardLeft = new System.Windows.Forms.Button();
            this.btnForwardUp = new System.Windows.Forms.Button();
            this.btnForwardDown = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnDiagLeft = new System.Windows.Forms.Button();
            this.btnDiagRight = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColorOutline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColorInline)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(15, 162);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(639, 341);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 81);
            this.panel1.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(618, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 39);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 21;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(579, 8);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 39);
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
            this.parrotGradientPanel2.Location = new System.Drawing.Point(15, 14);
            this.parrotGradientPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.parrotGradientPanel2.Name = "parrotGradientPanel2";
            this.parrotGradientPanel2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel2.PrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(79)))), ((int)(((byte)(108)))));
            this.parrotGradientPanel2.Size = new System.Drawing.Size(325, 35);
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
            this.nightHeaderLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel1.ForeColor = System.Drawing.Color.Black;
            this.nightHeaderLabel1.LeftSideForeColor = System.Drawing.Color.Black;
            this.nightHeaderLabel1.Location = new System.Drawing.Point(7, 5);
            this.nightHeaderLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nightHeaderLabel1.Name = "nightHeaderLabel1";
            this.nightHeaderLabel1.RightSideForeColor = System.Drawing.Color.White;
            this.nightHeaderLabel1.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel1.Size = new System.Drawing.Size(196, 30);
            this.nightHeaderLabel1.TabIndex = 12;
            this.nightHeaderLabel1.Text = "3D Figures Project";
            this.nightHeaderLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel1.UseCompatibleTextRendering = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(539, 8);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 39);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(2, 2);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(47, 42);
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
            this.menuContainer.Location = new System.Drawing.Point(2, 84);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(2);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(53, 43);
            this.menuContainer.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 48);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 94);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(2, 140);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(2, 186);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLeftArrow
            // 
            this.btnLeftArrow.Image = ((System.Drawing.Image)(resources.GetObject("btnLeftArrow.Image")));
            this.btnLeftArrow.Location = new System.Drawing.Point(2, 232);
            this.btnLeftArrow.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeftArrow.Name = "btnLeftArrow";
            this.btnLeftArrow.Size = new System.Drawing.Size(47, 42);
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
            this.btnRightArrow.Location = new System.Drawing.Point(59, 84);
            this.btnRightArrow.Margin = new System.Windows.Forms.Padding(2);
            this.btnRightArrow.Name = "btnRightArrow";
            this.btnRightArrow.Size = new System.Drawing.Size(25, 42);
            this.btnRightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRightArrow.TabIndex = 19;
            this.btnRightArrow.TabStop = false;
            this.btnRightArrow.Click += new System.EventHandler(this.btnRightArrow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // trScaleX
            // 
            this.trScaleX.JumpToMouse = false;
            this.trScaleX.Location = new System.Drawing.Point(45, 138);
            this.trScaleX.Margin = new System.Windows.Forms.Padding(2);
            this.trScaleX.Maximum = 20;
            this.trScaleX.Minimum = 1;
            this.trScaleX.MinimumSize = new System.Drawing.Size(31, 14);
            this.trScaleX.Name = "trScaleX";
            this.trScaleX.Size = new System.Drawing.Size(67, 22);
            this.trScaleX.TabIndex = 24;
            this.trScaleX.Text = "trackBar1";
            this.trScaleX.Value = 1;
            this.trScaleX.ValueDivison = ReaLTaiizor.Controls.TrackBar.ValueDivisor.By1;
            this.trScaleX.ValueToSet = 1F;
            this.trScaleX.ValueChanged += new ReaLTaiizor.Controls.TrackBar.ValueChangedEventHandler(this.trScaleX_ValueChanged);
            // 
            // trScaleY
            // 
            this.trScaleY.JumpToMouse = false;
            this.trScaleY.Location = new System.Drawing.Point(147, 138);
            this.trScaleY.Margin = new System.Windows.Forms.Padding(2);
            this.trScaleY.Maximum = 20;
            this.trScaleY.Minimum = 1;
            this.trScaleY.MinimumSize = new System.Drawing.Size(31, 14);
            this.trScaleY.Name = "trScaleY";
            this.trScaleY.Size = new System.Drawing.Size(67, 22);
            this.trScaleY.TabIndex = 26;
            this.trScaleY.Text = "trackBar2";
            this.trScaleY.Value = 1;
            this.trScaleY.ValueDivison = ReaLTaiizor.Controls.TrackBar.ValueDivisor.By1;
            this.trScaleY.ValueToSet = 1F;
            this.trScaleY.ValueChanged += new ReaLTaiizor.Controls.TrackBar.ValueChangedEventHandler(this.trScaleY_ValueChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(116, 132);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // trScaleZ
            // 
            this.trScaleZ.JumpToMouse = false;
            this.trScaleZ.Location = new System.Drawing.Point(248, 138);
            this.trScaleZ.Margin = new System.Windows.Forms.Padding(2);
            this.trScaleZ.Maximum = 20;
            this.trScaleZ.Minimum = 1;
            this.trScaleZ.MinimumSize = new System.Drawing.Size(31, 14);
            this.trScaleZ.Name = "trScaleZ";
            this.trScaleZ.Size = new System.Drawing.Size(67, 22);
            this.trScaleZ.TabIndex = 28;
            this.trScaleZ.Text = "trackBar3";
            this.trScaleZ.Value = 1;
            this.trScaleZ.ValueDivison = ReaLTaiizor.Controls.TrackBar.ValueDivisor.By1;
            this.trScaleZ.ValueToSet = 1F;
            this.trScaleZ.ValueChanged += new ReaLTaiizor.Controls.TrackBar.ValueChangedEventHandler(this.trScaleZ_ValueChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(217, 132);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(27, 26);
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
            this.materialLabel1.Location = new System.Drawing.Point(348, 92);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(131, 24);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "Rotate Figures";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(535, 92);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(107, 24);
            this.materialLabel2.TabIndex = 33;
            this.materialLabel2.Text = "Color picker";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(498, 83);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(37, 36);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 19;
            this.pictureBox11.TabStop = false;
            // 
            // btnColorOutline
            // 
            this.btnColorOutline.Image = ((System.Drawing.Image)(resources.GetObject("btnColorOutline.Image")));
            this.btnColorOutline.Location = new System.Drawing.Point(539, 120);
            this.btnColorOutline.Margin = new System.Windows.Forms.Padding(2);
            this.btnColorOutline.Name = "btnColorOutline";
            this.btnColorOutline.Size = new System.Drawing.Size(37, 36);
            this.btnColorOutline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnColorOutline.TabIndex = 34;
            this.btnColorOutline.TabStop = false;
            this.btnColorOutline.Click += new System.EventHandler(this.btnColorOutline_Click);
            // 
            // btnColorInline
            // 
            this.btnColorInline.Image = ((System.Drawing.Image)(resources.GetObject("btnColorInline.Image")));
            this.btnColorInline.Location = new System.Drawing.Point(583, 120);
            this.btnColorInline.Margin = new System.Windows.Forms.Padding(2);
            this.btnColorInline.Name = "btnColorInline";
            this.btnColorInline.Size = new System.Drawing.Size(37, 36);
            this.btnColorInline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnColorInline.TabIndex = 35;
            this.btnColorInline.TabStop = false;
            this.btnColorInline.Click += new System.EventHandler(this.btnColorInline_Click);
            // 
            // btnRotateAxisZ
            // 
            this.btnRotateAxisZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.btnRotateAxisZ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRotateAxisZ.BackgroundImage")));
            this.btnRotateAxisZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRotateAxisZ.Location = new System.Drawing.Point(399, 124);
            this.btnRotateAxisZ.Name = "btnRotateAxisZ";
            this.btnRotateAxisZ.Size = new System.Drawing.Size(38, 36);
            this.btnRotateAxisZ.TabIndex = 42;
            this.btnRotateAxisZ.UseVisualStyleBackColor = false;
            this.btnRotateAxisZ.Click += new System.EventHandler(this.btnRotateZ_Click);
            // 
            // btnRotateAxisY
            // 
            this.btnRotateAxisY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.btnRotateAxisY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRotateAxisY.BackgroundImage")));
            this.btnRotateAxisY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRotateAxisY.Location = new System.Drawing.Point(362, 124);
            this.btnRotateAxisY.Margin = new System.Windows.Forms.Padding(0);
            this.btnRotateAxisY.Name = "btnRotateAxisY";
            this.btnRotateAxisY.Size = new System.Drawing.Size(38, 36);
            this.btnRotateAxisY.TabIndex = 41;
            this.btnRotateAxisY.UseVisualStyleBackColor = false;
            this.btnRotateAxisY.Click += new System.EventHandler(this.btnRotateY_Click);
            // 
            // btnRotateAxisX
            // 
            this.btnRotateAxisX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.btnRotateAxisX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRotateAxisX.BackgroundImage")));
            this.btnRotateAxisX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRotateAxisX.Location = new System.Drawing.Point(436, 124);
            this.btnRotateAxisX.Name = "btnRotateAxisX";
            this.btnRotateAxisX.Size = new System.Drawing.Size(38, 36);
            this.btnRotateAxisX.TabIndex = 40;
            this.btnRotateAxisX.UseVisualStyleBackColor = false;
            this.btnRotateAxisX.Click += new System.EventHandler(this.btnRotateX_Click);
            // 
            // btnForwardRight
            // 
            this.btnForwardRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.btnForwardRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForwardRight.BackgroundImage")));
            this.btnForwardRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForwardRight.Location = new System.Drawing.Point(95, 198);
            this.btnForwardRight.Name = "btnForwardRight";
            this.btnForwardRight.Size = new System.Drawing.Size(38, 36);
            this.btnForwardRight.TabIndex = 43;
            this.btnForwardRight.UseVisualStyleBackColor = false;
            this.btnForwardRight.Click += new System.EventHandler(this.btnTranslateX_Click);
            // 
            // btnForwardLeft
            // 
            this.btnForwardLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.btnForwardLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForwardLeft.BackgroundImage")));
            this.btnForwardLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForwardLeft.Location = new System.Drawing.Point(22, 198);
            this.btnForwardLeft.Name = "btnForwardLeft";
            this.btnForwardLeft.Size = new System.Drawing.Size(38, 36);
            this.btnForwardLeft.TabIndex = 44;
            this.btnForwardLeft.UseVisualStyleBackColor = false;
            this.btnForwardLeft.Click += new System.EventHandler(this.btnForwardLeft_Click);
            // 
            // btnForwardUp
            // 
            this.btnForwardUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.btnForwardUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForwardUp.BackgroundImage")));
            this.btnForwardUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForwardUp.Location = new System.Drawing.Point(59, 165);
            this.btnForwardUp.Name = "btnForwardUp";
            this.btnForwardUp.Size = new System.Drawing.Size(38, 36);
            this.btnForwardUp.TabIndex = 45;
            this.btnForwardUp.UseVisualStyleBackColor = false;
            this.btnForwardUp.Click += new System.EventHandler(this.btnTranslateY_Click);
            // 
            // btnForwardDown
            // 
            this.btnForwardDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.btnForwardDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnForwardDown.BackgroundImage")));
            this.btnForwardDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForwardDown.Location = new System.Drawing.Point(59, 230);
            this.btnForwardDown.Name = "btnForwardDown";
            this.btnForwardDown.Size = new System.Drawing.Size(38, 36);
            this.btnForwardDown.TabIndex = 46;
            this.btnForwardDown.UseVisualStyleBackColor = false;
            this.btnForwardDown.Click += new System.EventHandler(this.btnForwardDown_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.btnCollapse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCollapse.BackgroundImage")));
            this.btnCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCollapse.Location = new System.Drawing.Point(59, 198);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(38, 36);
            this.btnCollapse.TabIndex = 47;
            this.btnCollapse.UseVisualStyleBackColor = false;
            // 
            // btnDiagLeft
            // 
            this.btnDiagLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.btnDiagLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiagLeft.BackgroundImage")));
            this.btnDiagLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiagLeft.Location = new System.Drawing.Point(139, 198);
            this.btnDiagLeft.Name = "btnDiagLeft";
            this.btnDiagLeft.Size = new System.Drawing.Size(38, 36);
            this.btnDiagLeft.TabIndex = 48;
            this.btnDiagLeft.UseVisualStyleBackColor = false;
            this.btnDiagLeft.Click += new System.EventHandler(this.btnDiagLeft_Click);
            // 
            // btnDiagRight
            // 
            this.btnDiagRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.btnDiagRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiagRight.BackgroundImage")));
            this.btnDiagRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiagRight.Location = new System.Drawing.Point(176, 165);
            this.btnDiagRight.Name = "btnDiagRight";
            this.btnDiagRight.Size = new System.Drawing.Size(38, 36);
            this.btnDiagRight.TabIndex = 49;
            this.btnDiagRight.UseVisualStyleBackColor = false;
            this.btnDiagRight.Click += new System.EventHandler(this.btnDiagRight_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(667, 520);
            this.Controls.Add(this.btnDiagRight);
            this.Controls.Add(this.btnDiagLeft);
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(this.btnForwardDown);
            this.Controls.Add(this.btnForwardUp);
            this.Controls.Add(this.btnForwardLeft);
            this.Controls.Add(this.btnForwardRight);
            this.Controls.Add(this.btnRotateAxisZ);
            this.Controls.Add(this.btnRotateAxisY);
            this.Controls.Add(this.btnRotateAxisX);
            this.Controls.Add(this.btnColorInline);
            this.Controls.Add(this.btnColorOutline);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.trScaleZ);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.trScaleY);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.trScaleX);
            this.Controls.Add(this.menuContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRightArrow);
            this.Controls.Add(this.picCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(174, 42);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColorOutline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColorInline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
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
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox btnColorOutline;
        private System.Windows.Forms.PictureBox btnColorInline;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button btnRotateAxisZ;
        private System.Windows.Forms.Button btnRotateAxisY;
        private System.Windows.Forms.Button btnRotateAxisX;
        private System.Windows.Forms.Button btnForwardRight;
        private System.Windows.Forms.Button btnForwardLeft;
        private System.Windows.Forms.Button btnForwardUp;
        private System.Windows.Forms.Button btnForwardDown;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnDiagLeft;
        private System.Windows.Forms.Button btnDiagRight;
    }
}


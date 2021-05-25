
namespace Paint
{
    partial class Form1
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
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.radioEraser = new System.Windows.Forms.RadioButton();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.radioCircle = new System.Windows.Forms.RadioButton();
            this.radioRectangle = new System.Windows.Forms.RadioButton();
            this.radioPen = new System.Windows.Forms.RadioButton();
            this.lblDraw = new System.Windows.Forms.Label();
            this.lblPenWidth = new System.Windows.Forms.Label();
            this.numPenWidth = new System.Windows.Forms.NumericUpDown();
            this.btnPenColor = new System.Windows.Forms.Button();
            this.picBoxPenColor = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.colorDialogPenColor = new System.Windows.Forms.ColorDialog();
            this.colorDialogBackgroundColor = new System.Windows.Forms.ColorDialog();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPenColor)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelHome.Controls.Add(this.btnClear);
            this.panelHome.Controls.Add(this.radioEraser);
            this.panelHome.Controls.Add(this.btnBackgroundColor);
            this.panelHome.Controls.Add(this.radioCircle);
            this.panelHome.Controls.Add(this.radioRectangle);
            this.panelHome.Controls.Add(this.radioPen);
            this.panelHome.Controls.Add(this.lblDraw);
            this.panelHome.Controls.Add(this.lblPenWidth);
            this.panelHome.Controls.Add(this.numPenWidth);
            this.panelHome.Controls.Add(this.btnPenColor);
            this.panelHome.Controls.Add(this.picBoxPenColor);
            this.panelHome.Controls.Add(this.menuPanel);
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1098, 85);
            this.panelHome.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 42);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 30);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // radioEraser
            // 
            this.radioEraser.AutoSize = true;
            this.radioEraser.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEraser.Location = new System.Drawing.Point(437, 44);
            this.radioEraser.Name = "radioEraser";
            this.radioEraser.Size = new System.Drawing.Size(80, 19);
            this.radioEraser.TabIndex = 11;
            this.radioEraser.Text = "Use eraser";
            this.radioEraser.UseVisualStyleBackColor = true;
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.BackColor = System.Drawing.Color.White;
            this.btnBackgroundColor.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackgroundColor.Location = new System.Drawing.Point(115, 41);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(174, 30);
            this.btnBackgroundColor.TabIndex = 9;
            this.btnBackgroundColor.Text = "Change background color";
            this.btnBackgroundColor.UseVisualStyleBackColor = false;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // radioCircle
            // 
            this.radioCircle.AutoSize = true;
            this.radioCircle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCircle.Location = new System.Drawing.Point(632, 44);
            this.radioCircle.Name = "radioCircle";
            this.radioCircle.Size = new System.Drawing.Size(85, 19);
            this.radioCircle.TabIndex = 8;
            this.radioCircle.Text = "Draw circle";
            this.radioCircle.UseVisualStyleBackColor = true;
            // 
            // radioRectangle
            // 
            this.radioRectangle.AutoSize = true;
            this.radioRectangle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRectangle.Location = new System.Drawing.Point(523, 44);
            this.radioRectangle.Name = "radioRectangle";
            this.radioRectangle.Size = new System.Drawing.Size(103, 19);
            this.radioRectangle.TabIndex = 7;
            this.radioRectangle.Text = "Draw rectangle";
            this.radioRectangle.UseVisualStyleBackColor = true;
            // 
            // radioPen
            // 
            this.radioPen.AutoSize = true;
            this.radioPen.Checked = true;
            this.radioPen.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPen.Location = new System.Drawing.Point(366, 45);
            this.radioPen.Name = "radioPen";
            this.radioPen.Size = new System.Drawing.Size(65, 19);
            this.radioPen.TabIndex = 6;
            this.radioPen.TabStop = true;
            this.radioPen.Text = "Use pen";
            this.radioPen.UseVisualStyleBackColor = true;
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraw.ForeColor = System.Drawing.Color.Black;
            this.lblDraw.Location = new System.Drawing.Point(308, 42);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(52, 22);
            this.lblDraw.TabIndex = 5;
            this.lblDraw.Text = "Draw:";
            // 
            // lblPenWidth
            // 
            this.lblPenWidth.AutoSize = true;
            this.lblPenWidth.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenWidth.ForeColor = System.Drawing.Color.Black;
            this.lblPenWidth.Location = new System.Drawing.Point(736, 44);
            this.lblPenWidth.Name = "lblPenWidth";
            this.lblPenWidth.Size = new System.Drawing.Size(82, 22);
            this.lblPenWidth.TabIndex = 4;
            this.lblPenWidth.Text = "Pen width:";
            // 
            // numPenWidth
            // 
            this.numPenWidth.Location = new System.Drawing.Point(832, 45);
            this.numPenWidth.Name = "numPenWidth";
            this.numPenWidth.Size = new System.Drawing.Size(120, 20);
            this.numPenWidth.TabIndex = 3;
            this.numPenWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPenWidth.ValueChanged += new System.EventHandler(this.numPenWidth_ValueChanged);
            // 
            // btnPenColor
            // 
            this.btnPenColor.BackColor = System.Drawing.Color.White;
            this.btnPenColor.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenColor.Location = new System.Drawing.Point(973, 38);
            this.btnPenColor.Name = "btnPenColor";
            this.btnPenColor.Size = new System.Drawing.Size(76, 30);
            this.btnPenColor.TabIndex = 2;
            this.btnPenColor.Text = "Pen color:";
            this.btnPenColor.UseVisualStyleBackColor = false;
            this.btnPenColor.Click += new System.EventHandler(this.btnPenColor_Click);
            // 
            // picBoxPenColor
            // 
            this.picBoxPenColor.BackColor = System.Drawing.Color.Black;
            this.picBoxPenColor.Location = new System.Drawing.Point(1055, 38);
            this.picBoxPenColor.Name = "picBoxPenColor";
            this.picBoxPenColor.Size = new System.Drawing.Size(31, 30);
            this.picBoxPenColor.TabIndex = 1;
            this.picBoxPenColor.TabStop = false;
            // 
            // menuPanel
            // 
            this.menuPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.homeToolStripMenuItem});
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1098, 24);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // panelCanvas
            // 
            this.panelCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCanvas.BackColor = System.Drawing.Color.White;
            this.panelCanvas.Location = new System.Drawing.Point(0, 84);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(1098, 403);
            this.panelCanvas.TabIndex = 1;
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            this.panelCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseMove);
            this.panelCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseUp);
            // 
            // colorDialogBackgroundColor
            // 
            this.colorDialogBackgroundColor.Color = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 486);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuPanel;
            this.Name = "Form1";
            this.Text = "Paint";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPenColor)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.MenuStrip menuPanel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.PictureBox picBoxPenColor;
        private System.Windows.Forms.ColorDialog colorDialogPenColor;
        private System.Windows.Forms.Button btnPenColor;
        private System.Windows.Forms.NumericUpDown numPenWidth;
        private System.Windows.Forms.RadioButton radioCircle;
        private System.Windows.Forms.RadioButton radioRectangle;
        private System.Windows.Forms.RadioButton radioPen;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.Label lblPenWidth;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.ColorDialog colorDialogBackgroundColor;
        private System.Windows.Forms.RadioButton radioEraser;
        private System.Windows.Forms.Button btnClear;
    }
}


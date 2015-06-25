namespace LittlePaint
{
    partial class MainForm
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
            this.pictArea = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbBrushSize = new System.Windows.Forms.Label();
            this.bnPencil = new System.Windows.Forms.Button();
            this.bnLine = new System.Windows.Forms.Button();
            this.bnElipse = new System.Windows.Forms.Button();
            this.bnRectangle = new System.Windows.Forms.Button();
            this.bnEraser = new System.Windows.Forms.Button();
            this.lbFontColor = new System.Windows.Forms.Label();
            this.lbPaintColor = new System.Windows.Forms.Label();
            this.bnRotate90 = new System.Windows.Forms.Button();
            this.bnRotate180 = new System.Windows.Forms.Button();
            this.tbBrushSize = new System.Windows.Forms.TrackBar();
            this.lbColor1 = new System.Windows.Forms.Label();
            this.lbColor2 = new System.Windows.Forms.Label();
            this.bnInverse = new System.Windows.Forms.Button();
            this.pbInvertation = new System.Windows.Forms.ProgressBar();
            this.bWork = new System.ComponentModel.BackgroundWorker();
            this.lbProgress = new System.Windows.Forms.Label();
            this.ToolBox = new System.Windows.Forms.GroupBox();
            this.bnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictArea)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrushSize)).BeginInit();
            this.ToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictArea
            // 
            this.pictArea.BackColor = System.Drawing.Color.White;
            this.pictArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictArea.Location = new System.Drawing.Point(12, 107);
            this.pictArea.Name = "pictArea";
            this.pictArea.Size = new System.Drawing.Size(258, 376);
            this.pictArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictArea.TabIndex = 0;
            this.pictArea.TabStop = false;
            this.pictArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictArea_MouseDown);
            this.pictArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictArea_MouseMove);
            this.pictArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictArea_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lbBrushSize
            // 
            this.lbBrushSize.AutoSize = true;
            this.lbBrushSize.Location = new System.Drawing.Point(165, 34);
            this.lbBrushSize.Name = "lbBrushSize";
            this.lbBrushSize.Size = new System.Drawing.Size(60, 13);
            this.lbBrushSize.TabIndex = 2;
            this.lbBrushSize.Text = "Brush Size:";
            // 
            // bnPencil
            // 
            this.bnPencil.Image = global::LittlePaint.Properties.Resources._88b7c2b6_18ae_4e6a_a98d_34f175f162dd_14;
            this.bnPencil.Location = new System.Drawing.Point(6, 19);
            this.bnPencil.Name = "bnPencil";
            this.bnPencil.Size = new System.Drawing.Size(47, 43);
            this.bnPencil.TabIndex = 8;
            this.bnPencil.UseVisualStyleBackColor = true;
            this.bnPencil.Click += new System.EventHandler(this.bnPencil_Click);
            // 
            // bnLine
            // 
            this.bnLine.Image = global::LittlePaint.Properties.Resources._6f9beb15_5600_44cb_9535_7b6b4ae8478a_14;
            this.bnLine.Location = new System.Drawing.Point(59, 19);
            this.bnLine.Name = "bnLine";
            this.bnLine.Size = new System.Drawing.Size(47, 43);
            this.bnLine.TabIndex = 9;
            this.bnLine.UseVisualStyleBackColor = true;
            this.bnLine.Click += new System.EventHandler(this.bnLine_Click);
            // 
            // bnElipse
            // 
            this.bnElipse.Image = global::LittlePaint.Properties.Resources._1b989022_f1f1_46e1_b81d_5ff68d6a4925_14;
            this.bnElipse.Location = new System.Drawing.Point(485, 20);
            this.bnElipse.Name = "bnElipse";
            this.bnElipse.Size = new System.Drawing.Size(40, 40);
            this.bnElipse.TabIndex = 12;
            this.bnElipse.UseVisualStyleBackColor = true;
            this.bnElipse.Click += new System.EventHandler(this.bnElipse_Click);
            // 
            // bnRectangle
            // 
            this.bnRectangle.Image = global::LittlePaint.Properties.Resources._46bf7404_dc82_44a4_b540_9625ac9beeef_14;
            this.bnRectangle.Location = new System.Drawing.Point(439, 20);
            this.bnRectangle.Name = "bnRectangle";
            this.bnRectangle.Size = new System.Drawing.Size(40, 40);
            this.bnRectangle.TabIndex = 11;
            this.bnRectangle.UseVisualStyleBackColor = true;
            this.bnRectangle.Click += new System.EventHandler(this.bnRectangle_Click);
            // 
            // bnEraser
            // 
            this.bnEraser.Image = global::LittlePaint.Properties.Resources.b8d867cf_e02a_4d1d_947b_604741f79d23_14;
            this.bnEraser.Location = new System.Drawing.Point(112, 19);
            this.bnEraser.Name = "bnEraser";
            this.bnEraser.Size = new System.Drawing.Size(47, 43);
            this.bnEraser.TabIndex = 14;
            this.bnEraser.UseVisualStyleBackColor = true;
            this.bnEraser.Click += new System.EventHandler(this.bnEraser_Click);
            // 
            // lbFontColor
            // 
            this.lbFontColor.BackColor = System.Drawing.Color.White;
            this.lbFontColor.Location = new System.Drawing.Point(681, 25);
            this.lbFontColor.Name = "lbFontColor";
            this.lbFontColor.Size = new System.Drawing.Size(37, 30);
            this.lbFontColor.TabIndex = 16;
            this.lbFontColor.Click += new System.EventHandler(this.lbFontColor_Click);
            // 
            // lbPaintColor
            // 
            this.lbPaintColor.BackColor = System.Drawing.Color.Black;
            this.lbPaintColor.Location = new System.Drawing.Point(638, 25);
            this.lbPaintColor.Name = "lbPaintColor";
            this.lbPaintColor.Size = new System.Drawing.Size(37, 30);
            this.lbPaintColor.TabIndex = 17;
            this.lbPaintColor.Click += new System.EventHandler(this.lbPaintColor_Click);
            // 
            // bnRotate90
            // 
            this.bnRotate90.Location = new System.Drawing.Point(584, 20);
            this.bnRotate90.Name = "bnRotate90";
            this.bnRotate90.Size = new System.Drawing.Size(48, 40);
            this.bnRotate90.TabIndex = 19;
            this.bnRotate90.Text = "Rotate 90";
            this.bnRotate90.UseVisualStyleBackColor = true;
            this.bnRotate90.Click += new System.EventHandler(this.bnRotate_Click);
            // 
            // bnRotate180
            // 
            this.bnRotate180.Location = new System.Drawing.Point(531, 20);
            this.bnRotate180.Name = "bnRotate180";
            this.bnRotate180.Size = new System.Drawing.Size(47, 40);
            this.bnRotate180.TabIndex = 20;
            this.bnRotate180.Text = "Rotate 180";
            this.bnRotate180.UseVisualStyleBackColor = true;
            this.bnRotate180.Click += new System.EventHandler(this.bnRotate180_Click);
            // 
            // tbBrushSize
            // 
            this.tbBrushSize.Location = new System.Drawing.Point(230, 19);
            this.tbBrushSize.Maximum = 100;
            this.tbBrushSize.Minimum = 1;
            this.tbBrushSize.Name = "tbBrushSize";
            this.tbBrushSize.Size = new System.Drawing.Size(203, 42);
            this.tbBrushSize.TabIndex = 21;
            this.tbBrushSize.Value = 1;
            // 
            // lbColor1
            // 
            this.lbColor1.AutoSize = true;
            this.lbColor1.Location = new System.Drawing.Point(638, 6);
            this.lbColor1.Name = "lbColor1";
            this.lbColor1.Size = new System.Drawing.Size(40, 13);
            this.lbColor1.TabIndex = 22;
            this.lbColor1.Text = "Color 1";
            // 
            // lbColor2
            // 
            this.lbColor2.AutoSize = true;
            this.lbColor2.Location = new System.Drawing.Point(681, 6);
            this.lbColor2.Name = "lbColor2";
            this.lbColor2.Size = new System.Drawing.Size(40, 13);
            this.lbColor2.TabIndex = 23;
            this.lbColor2.Text = "Color 2";
            // 
            // bnInverse
            // 
            this.bnInverse.Location = new System.Drawing.Point(727, 10);
            this.bnInverse.Name = "bnInverse";
            this.bnInverse.Size = new System.Drawing.Size(75, 23);
            this.bnInverse.TabIndex = 24;
            this.bnInverse.Text = "Invert";
            this.bnInverse.UseVisualStyleBackColor = true;
            this.bnInverse.Click += new System.EventHandler(this.bnInverse_Click);
            // 
            // pbInvertation
            // 
            this.pbInvertation.Location = new System.Drawing.Point(809, 27);
            this.pbInvertation.Name = "pbInvertation";
            this.pbInvertation.Size = new System.Drawing.Size(120, 23);
            this.pbInvertation.TabIndex = 25;
            // 
            // bWork
            // 
            this.bWork.WorkerReportsProgress = true;
            this.bWork.WorkerSupportsCancellation = true;
            this.bWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWork_DoWork);
            this.bWork.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bWork_ProgressChanged);
            this.bWork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWork_RunWorkerCompleted);
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(860, 11);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(0, 13);
            this.lbProgress.TabIndex = 27;
            // 
            // ToolBox
            // 
            this.ToolBox.Controls.Add(this.bnCancel);
            this.ToolBox.Controls.Add(this.lbProgress);
            this.ToolBox.Controls.Add(this.bnPencil);
            this.ToolBox.Controls.Add(this.pbInvertation);
            this.ToolBox.Controls.Add(this.bnInverse);
            this.ToolBox.Controls.Add(this.bnLine);
            this.ToolBox.Controls.Add(this.bnEraser);
            this.ToolBox.Controls.Add(this.lbBrushSize);
            this.ToolBox.Controls.Add(this.lbColor2);
            this.ToolBox.Controls.Add(this.tbBrushSize);
            this.ToolBox.Controls.Add(this.lbFontColor);
            this.ToolBox.Controls.Add(this.lbColor1);
            this.ToolBox.Controls.Add(this.bnRectangle);
            this.ToolBox.Controls.Add(this.lbPaintColor);
            this.ToolBox.Controls.Add(this.bnRotate90);
            this.ToolBox.Controls.Add(this.bnRotate180);
            this.ToolBox.Controls.Add(this.bnElipse);
            this.ToolBox.Location = new System.Drawing.Point(0, 26);
            this.ToolBox.Name = "ToolBox";
            this.ToolBox.Size = new System.Drawing.Size(946, 75);
            this.ToolBox.TabIndex = 28;
            this.ToolBox.TabStop = false;
            this.ToolBox.Text = "Tools";
            // 
            // bnCancel
            // 
            this.bnCancel.Enabled = false;
            this.bnCancel.Location = new System.Drawing.Point(727, 47);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(75, 22);
            this.bnCancel.TabIndex = 29;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(946, 483);
            this.Controls.Add(this.pictArea);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ToolBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Little Paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictArea)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrushSize)).EndInit();
            this.ToolBox.ResumeLayout(false);
            this.ToolBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictArea;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lbBrushSize;
        private System.Windows.Forms.Button bnPencil;
        private System.Windows.Forms.Button bnLine;
        private System.Windows.Forms.Button bnElipse;
        private System.Windows.Forms.Button bnRectangle;
        private System.Windows.Forms.Button bnEraser;
        private System.Windows.Forms.Label lbFontColor;
        private System.Windows.Forms.Label lbPaintColor;
        private System.Windows.Forms.Button bnRotate90;
        private System.Windows.Forms.Button bnRotate180;
        private System.Windows.Forms.TrackBar tbBrushSize;
        private System.Windows.Forms.Label lbColor1;
        private System.Windows.Forms.Label lbColor2;
        private System.Windows.Forms.Button bnInverse;
        private System.Windows.Forms.ProgressBar pbInvertation;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.GroupBox ToolBox;
        private System.ComponentModel.BackgroundWorker bWork;
        private System.Windows.Forms.Button bnCancel;
    }
}


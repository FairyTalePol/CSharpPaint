﻿
namespace FinalPaint
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.dropdownPenWidth = new System.Windows.Forms.ComboBox();
            this.penChangeSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainDrawingSurface = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button13 = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penChangeSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDrawingSurface)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 66);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button_open);
            this.panel3.Controls.Add(this.btnEllipse);
            this.panel3.Controls.Add(this.button_save);
            this.panel3.Controls.Add(this.btnRectangle);
            this.panel3.Controls.Add(this.btnPoint);
            this.panel3.Controls.Add(this.btnLine);
            this.panel3.Controls.Add(this.btnPencil);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 64);
            this.panel3.TabIndex = 1;
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.Aqua;
            this.btnEllipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEllipse.BackgroundImage")));
            this.btnEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnEllipse.Image")));
            this.btnEllipse.Location = new System.Drawing.Point(176, 2);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(39, 39);
            this.btnEllipse.TabIndex = 0;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangle.Image")));
            this.btnRectangle.Location = new System.Drawing.Point(133, 2);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(39, 39);
            this.btnRectangle.TabIndex = 0;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.Aqua;
            this.btnPoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPoint.BackgroundImage")));
            this.btnPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPoint.Image = ((System.Drawing.Image)(resources.GetObject("btnPoint.Image")));
            this.btnPoint.Location = new System.Drawing.Point(45, 2);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(39, 39);
            this.btnPoint.TabIndex = 0;
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.Aqua;
            this.btnLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLine.BackgroundImage")));
            this.btnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.Location = new System.Drawing.Point(89, 2);
            this.btnLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(39, 39);
            this.btnLine.TabIndex = 0;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPencil.Image = ((System.Drawing.Image)(resources.GetObject("btnPencil.Image")));
            this.btnPencil.Location = new System.Drawing.Point(2, 2);
            this.btnPencil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(39, 39);
            this.btnPencil.TabIndex = 0;
            this.btnPencil.UseVisualStyleBackColor = false;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.dropdownPenWidth);
            this.panel2.Controls.Add(this.penChangeSizeTrackBar);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.btnColorDialog);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.btnColor);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(361, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 62);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Size";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.ForeColor = System.Drawing.Color.Coral;
            this.btnClear.Location = new System.Drawing.Point(271, 3);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(25, 27);
            this.btnClear.TabIndex = 1;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dropdownPenWidth
            // 
            this.dropdownPenWidth.FormattingEnabled = true;
            this.dropdownPenWidth.Items.AddRange(new object[] {
            "1px",
            "5px",
            "10px",
            "20px"});
            this.dropdownPenWidth.Location = new System.Drawing.Point(184, 35);
            this.dropdownPenWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dropdownPenWidth.Name = "dropdownPenWidth";
            this.dropdownPenWidth.Size = new System.Drawing.Size(81, 21);
            this.dropdownPenWidth.TabIndex = 1;
            this.dropdownPenWidth.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // penChangeSizeTrackBar
            // 
            this.penChangeSizeTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.penChangeSizeTrackBar.Location = new System.Drawing.Point(170, 3);
            this.penChangeSizeTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.penChangeSizeTrackBar.Maximum = 50;
            this.penChangeSizeTrackBar.Name = "penChangeSizeTrackBar";
            this.penChangeSizeTrackBar.Size = new System.Drawing.Size(99, 45);
            this.penChangeSizeTrackBar.TabIndex = 2;
            this.penChangeSizeTrackBar.Scroll += new System.EventHandler(this.penChangeSizeTrackBar_Scroll);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Purple;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Location = new System.Drawing.Point(98, 29);
            this.button10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(20, 22);
            this.button10.TabIndex = 1;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Location = new System.Drawing.Point(74, 29);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(20, 22);
            this.button8.TabIndex = 1;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorDialog.Location = new System.Drawing.Point(122, 2);
            this.btnColorDialog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(44, 49);
            this.btnColorDialog.TabIndex = 1;
            this.btnColorDialog.UseVisualStyleBackColor = true;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Fuchsia;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Location = new System.Drawing.Point(98, 2);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(20, 22);
            this.button9.TabIndex = 1;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Aqua;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.Location = new System.Drawing.Point(74, 2);
            this.btnColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(20, 22);
            this.btnColor.TabIndex = 1;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lime;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(50, 29);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(20, 22);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(50, 2);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 22);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(26, 3);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 22);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(26, 29);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 22);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(2, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 22);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 22);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // mainDrawingSurface
            // 
            this.mainDrawingSurface.BackColor = System.Drawing.Color.White;
            this.mainDrawingSurface.Location = new System.Drawing.Point(0, 66);
            this.mainDrawingSurface.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainDrawingSurface.Name = "mainDrawingSurface";
            this.mainDrawingSurface.Size = new System.Drawing.Size(667, 300);
            this.mainDrawingSurface.TabIndex = 1;
            this.mainDrawingSurface.TabStop = false;
            this.mainDrawingSurface.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainDrawingSurface_MouseClick);
            this.mainDrawingSurface.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainDrawingSurface_MouseDown);
            this.mainDrawingSurface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainDrawingSurface_MouseMove);
            this.mainDrawingSurface.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainDrawingSurface_MouseUp);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(55, 107);
            this.button13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(28, 30);
            this.button13.TabIndex = 0;
            this.button13.Text = "button7";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(315, 37);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(39, 20);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_open
            // 
            this.button_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_open.Location = new System.Drawing.Point(315, 17);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(39, 20);
            this.button_open.TabIndex = 3;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 366);
            this.Controls.Add(this.mainDrawingSurface);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "PaintiK";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penChangeSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDrawingSurface)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox mainDrawingSurface;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar penChangeSizeTrackBar;
        private System.Windows.Forms.ComboBox dropdownPenWidth;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


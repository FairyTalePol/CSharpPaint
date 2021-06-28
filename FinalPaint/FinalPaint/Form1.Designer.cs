
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRoundedRectangle = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.nGon_button = new System.Windows.Forms.Button();
            this.btnHexagon = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.redoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.undoButton = new System.Windows.Forms.Button();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileOnServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOut_btn = new System.Windows.Forms.Button();
            this.mainDrawingSurface = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penChangeSizeTrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDrawingSurface)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.BackgroundImage")));
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSelect.Location = new System.Drawing.Point(765, 87);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 71);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnRoundedRectangle
            // 
            this.btnRoundedRectangle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRoundedRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoundedRectangle.BackgroundImage")));
            this.btnRoundedRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoundedRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoundedRectangle.FlatAppearance.BorderSize = 0;
            this.btnRoundedRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoundedRectangle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRoundedRectangle.Location = new System.Drawing.Point(686, 114);
            this.btnRoundedRectangle.Margin = new System.Windows.Forms.Padding(6);
            this.btnRoundedRectangle.Name = "btnRoundedRectangle";
            this.btnRoundedRectangle.Size = new System.Drawing.Size(51, 51);
            this.btnRoundedRectangle.TabIndex = 2;
            this.btnRoundedRectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRoundedRectangle.UseVisualStyleBackColor = false;
            this.btnRoundedRectangle.Click += new System.EventHandler(this.btnRoundedRectangle_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox.Location = new System.Drawing.Point(1207, 121);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 37);
            this.textBox.TabIndex = 5;
            this.textBox.Text = "5";
            // 
            // nGon_button
            // 
            this.nGon_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nGon_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nGon_button.BackgroundImage")));
            this.nGon_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nGon_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nGon_button.FlatAppearance.BorderSize = 0;
            this.nGon_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nGon_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.nGon_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nGon_button.Location = new System.Drawing.Point(1207, 18);
            this.nGon_button.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.nGon_button.Name = "nGon_button";
            this.nGon_button.Size = new System.Drawing.Size(100, 100);
            this.nGon_button.TabIndex = 4;
            this.nGon_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nGon_button.UseVisualStyleBackColor = false;
            this.nGon_button.Click += new System.EventHandler(this.NGon_button_Click);
            // 
            // btnHexagon
            // 
            this.btnHexagon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHexagon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHexagon.BackgroundImage")));
            this.btnHexagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHexagon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHexagon.FlatAppearance.BorderSize = 0;
            this.btnHexagon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHexagon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHexagon.Location = new System.Drawing.Point(1095, 18);
            this.btnHexagon.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnHexagon.Name = "btnHexagon";
            this.btnHexagon.Size = new System.Drawing.Size(100, 100);
            this.btnHexagon.TabIndex = 2;
            this.btnHexagon.UseVisualStyleBackColor = false;
            this.btnHexagon.Click += new System.EventHandler(this.BtnHexagon_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEllipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEllipse.BackgroundImage")));
            this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEllipse.FlatAppearance.BorderSize = 0;
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEllipse.Location = new System.Drawing.Point(983, 18);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(100, 100);
            this.btnEllipse.TabIndex = 0;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.BtnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRectangle.BackgroundImage")));
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRectangle.FlatAppearance.BorderSize = 0;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRectangle.Location = new System.Drawing.Point(873, 18);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(100, 100);
            this.btnRectangle.TabIndex = 0;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPoint.BackgroundImage")));
            this.btnPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPoint.FlatAppearance.BorderSize = 0;
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPoint.Location = new System.Drawing.Point(564, 117);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(51, 51);
            this.btnPoint.TabIndex = 0;
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.BtnPoint_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLine.BackgroundImage")));
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLine.Location = new System.Drawing.Point(623, 114);
            this.btnLine.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(51, 51);
            this.btnLine.TabIndex = 0;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPencil.BackgroundImage")));
            this.btnPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPencil.FlatAppearance.BorderSize = 0;
            this.btnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencil.ForeColor = System.Drawing.Color.White;
            this.btnPencil.Location = new System.Drawing.Point(501, 117);
            this.btnPencil.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(51, 51);
            this.btnPencil.TabIndex = 0;
            this.btnPencil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPencil.UseVisualStyleBackColor = false;
            this.btnPencil.Click += new System.EventHandler(this.BtnPencil_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox);
            this.panel2.Controls.Add(this.logOut_btn);
            this.panel2.Controls.Add(this.nGon_button);
            this.panel2.Controls.Add(this.redoButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnRoundedRectangle);
            this.panel2.Controls.Add(this.undoButton);
            this.panel2.Controls.Add(this.btnHexagon);
            this.panel2.Controls.Add(this.btnEllipse);
            this.panel2.Controls.Add(this.btnRectangle);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.dropdownPenWidth);
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Controls.Add(this.btnPoint);
            this.panel2.Controls.Add(this.btnLine);
            this.panel2.Controls.Add(this.btnPencil);
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
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1348, 179);
            this.panel2.TabIndex = 0;
            // 
            // redoButton
            // 
            this.redoButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.redoButton.FlatAppearance.BorderSize = 0;
            this.redoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.redoButton.Location = new System.Drawing.Point(185, 2);
            this.redoButton.Margin = new System.Windows.Forms.Padding(6);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(104, 48);
            this.redoButton.TabIndex = 3;
            this.redoButton.Text = "Redo";
            this.redoButton.UseVisualStyleBackColor = false;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(409, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Size";
            // 
            // undoButton
            // 
            this.undoButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.undoButton.FlatAppearance.BorderSize = 0;
            this.undoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.undoButton.Location = new System.Drawing.Point(84, 2);
            this.undoButton.Margin = new System.Windows.Forms.Padding(6);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(104, 48);
            this.undoButton.TabIndex = 2;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = false;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(765, 9);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 66);
            this.btnClear.TabIndex = 1;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // dropdownPenWidth
            // 
            this.dropdownPenWidth.FormattingEnabled = true;
            this.dropdownPenWidth.Items.AddRange(new object[] {
            "1px",
            "5px",
            "10px",
            "20px"});
            this.dropdownPenWidth.Location = new System.Drawing.Point(501, 67);
            this.dropdownPenWidth.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dropdownPenWidth.Name = "dropdownPenWidth";
            this.dropdownPenWidth.Size = new System.Drawing.Size(236, 39);
            this.dropdownPenWidth.TabIndex = 1;
            this.dropdownPenWidth.Text = "Pen width";
            this.dropdownPenWidth.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // penChangeSizeTrackBar
            // 
            this.penChangeSizeTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.penChangeSizeTrackBar.Location = new System.Drawing.Point(477, 4);
            this.penChangeSizeTrackBar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.penChangeSizeTrackBar.Maximum = 50;
            this.penChangeSizeTrackBar.Name = "penChangeSizeTrackBar";
            this.penChangeSizeTrackBar.Size = new System.Drawing.Size(276, 114);
            this.penChangeSizeTrackBar.TabIndex = 2;
            this.penChangeSizeTrackBar.Scroll += new System.EventHandler(this.PenChangeSizeTrackBar_Scroll);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Purple;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(406, 117);
            this.button10.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 48);
            this.button10.TabIndex = 1;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(342, 117);
            this.button8.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 48);
            this.button8.TabIndex = 1;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnColorDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorDialog.FlatAppearance.BorderSize = 0;
            this.btnColorDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorDialog.Location = new System.Drawing.Point(11, 53);
            this.btnColorDialog.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(118, 118);
            this.btnColorDialog.TabIndex = 1;
            this.btnColorDialog.UseVisualStyleBackColor = false;
            this.btnColorDialog.Click += new System.EventHandler(this.BtnColorDialog_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Fuchsia;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(406, 53);
            this.button9.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 48);
            this.button9.TabIndex = 1;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Aqua;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(342, 53);
            this.btnColor.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(48, 48);
            this.btnColor.TabIndex = 1;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lime;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(274, 117);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 48);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(274, 53);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 48);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(214, 53);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 48);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(214, 117);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 48);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(150, 117);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 48);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(150, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 48);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1344, 49);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.saveFileOnServerToolStripMenuItem,
            this.statisticToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.saveFileToolStripMenuItem.Text = "Save file";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // saveFileOnServerToolStripMenuItem
            // 
            this.saveFileOnServerToolStripMenuItem.Name = "saveFileOnServerToolStripMenuItem";
            this.saveFileOnServerToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.saveFileOnServerToolStripMenuItem.Text = "Save file on server";
            this.saveFileOnServerToolStripMenuItem.Click += new System.EventHandler(this.saveFileOnServerToolStripMenuItem_Click);
            // 
            // logOut_btn
            // 
            this.logOut_btn.FlatAppearance.BorderSize = 0;
            this.logOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.logOut_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logOut_btn.Location = new System.Drawing.Point(283, 2);
            this.logOut_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.Size = new System.Drawing.Size(123, 46);
            this.logOut_btn.TabIndex = 4;
            this.logOut_btn.Text = "Log Out";
            this.logOut_btn.UseVisualStyleBackColor = true;
            this.logOut_btn.Click += new System.EventHandler(this.logOut_btn_Click);
            // 
            // mainDrawingSurface
            // 
            this.mainDrawingSurface.BackColor = System.Drawing.Color.White;
            this.mainDrawingSurface.Location = new System.Drawing.Point(0, 180);
            this.mainDrawingSurface.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.mainDrawingSurface.Name = "mainDrawingSurface";
            this.mainDrawingSurface.Size = new System.Drawing.Size(1352, 692);
            this.mainDrawingSurface.TabIndex = 1;
            this.mainDrawingSurface.TabStop = false;
            this.mainDrawingSurface.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainDrawingSurface_MouseClick);
            this.mainDrawingSurface.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainDrawingSurface_MouseDown);
            this.mainDrawingSurface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainDrawingSurface_MouseMove);
            this.mainDrawingSurface.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainDrawingSurface_MouseUp);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1381, 225);
            this.button7.Margin = new System.Windows.Forms.Padding(6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 45);
            this.button7.TabIndex = 2;
            this.button7.Text = "DEBUG";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 183);
            this.panel1.TabIndex = 0;
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.statisticToolStripMenuItem.Text = "Statistics";
            this.statisticToolStripMenuItem.Click += new System.EventHandler(this.statisticToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 870);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.mainDrawingSurface);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaintiK";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penChangeSizeTrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDrawingSurface)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHexagon;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button nGon_button;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnRoundedRectangle;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button logOut_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileOnServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
    }
}


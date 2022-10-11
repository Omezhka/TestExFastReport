namespace TestExFastReports
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.R = new System.Windows.Forms.NumericUpDown();
            this.ChangeBrushColorButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChangePenColorButton = new System.Windows.Forms.Button();
            this.labelAngle = new System.Windows.Forms.Label();
            this.labelRadius = new System.Windows.Forms.Label();
            this.nRadius = new System.Windows.Forms.NumericUpDown();
            this.nAngle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(217, 12);
            this.R.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(123, 23);
            this.R.TabIndex = 0;
            this.R.ValueChanged += new System.EventHandler(this.R_ValueChanged);
            // 
            // ChangeBrushColorButton
            // 
            this.ChangeBrushColorButton.Location = new System.Drawing.Point(89, 179);
            this.ChangeBrushColorButton.Name = "ChangeBrushColorButton";
            this.ChangeBrushColorButton.Size = new System.Drawing.Size(195, 23);
            this.ChangeBrushColorButton.TabIndex = 1;
            this.ChangeBrushColorButton.Text = "Смена цвета заливки фигуры";
            this.ChangeBrushColorButton.UseVisualStyleBackColor = true;
            this.ChangeBrushColorButton.Click += new System.EventHandler(this.ChangeBrushColorButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 408);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.ChangePenColorButton);
            this.panel1.Controls.Add(this.labelAngle);
            this.panel1.Controls.Add(this.labelRadius);
            this.panel1.Controls.Add(this.nRadius);
            this.panel1.Controls.Add(this.nAngle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NumUpDownWidth);
            this.panel1.Controls.Add(this.NumUpDownHeight);
            this.panel1.Controls.Add(this.ChangeBrushColorButton);
            this.panel1.Controls.Add(this.R);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(539, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 408);
            this.panel1.TabIndex = 3;
            // 
            // ChangePenColorButton
            // 
            this.ChangePenColorButton.Location = new System.Drawing.Point(89, 220);
            this.ChangePenColorButton.Name = "ChangePenColorButton";
            this.ChangePenColorButton.Size = new System.Drawing.Size(195, 23);
            this.ChangePenColorButton.TabIndex = 13;
            this.ChangePenColorButton.Text = "Смена цвета окантовки фигуры";
            this.ChangePenColorButton.UseVisualStyleBackColor = true;
            this.ChangePenColorButton.Click += new System.EventHandler(this.ChangePenColorButton_Click);
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Location = new System.Drawing.Point(20, 130);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(166, 15);
            this.labelAngle.TabIndex = 12;
            this.labelAngle.Text = "Угол поворота треугольника";
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(20, 101);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(125, 15);
            this.labelRadius.TabIndex = 11;
            this.labelRadius.Text = "Размер треугольника";
            // 
            // nRadius
            // 
            this.nRadius.Location = new System.Drawing.Point(217, 99);
            this.nRadius.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nRadius.Name = "nRadius";
            this.nRadius.Size = new System.Drawing.Size(123, 23);
            this.nRadius.TabIndex = 9;
            this.nRadius.ValueChanged += new System.EventHandler(this.nRadius_ValueChanged);
            // 
            // nAngle
            // 
            this.nAngle.Location = new System.Drawing.Point(217, 128);
            this.nAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nAngle.Name = "nAngle";
            this.nAngle.Size = new System.Drawing.Size(123, 23);
            this.nAngle.TabIndex = 8;
            this.nAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nAngle.ValueChanged += new System.EventHandler(this.nAngle_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ширина (для прямоугольника)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Длина (для прямоугольника)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Радиус (для круга)";
            // 
            // NumUpDownWidth
            // 
            this.NumUpDownWidth.Location = new System.Drawing.Point(217, 70);
            this.NumUpDownWidth.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NumUpDownWidth.Name = "NumUpDownWidth";
            this.NumUpDownWidth.Size = new System.Drawing.Size(123, 23);
            this.NumUpDownWidth.TabIndex = 3;
            this.NumUpDownWidth.ValueChanged += new System.EventHandler(this.NumUpDownWidth_ValueChanged);
            // 
            // NumUpDownHeight
            // 
            this.NumUpDownHeight.Location = new System.Drawing.Point(217, 41);
            this.NumUpDownHeight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NumUpDownHeight.Name = "NumUpDownHeight";
            this.NumUpDownHeight.Size = new System.Drawing.Size(123, 23);
            this.NumUpDownHeight.TabIndex = 2;
            this.NumUpDownHeight.ValueChanged += new System.EventHandler(this.NumUpDownHeight_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown R;
        private Button ChangeBrushColorButton;
        private PictureBox pictureBox1;
        private Panel panel1;
        private NumericUpDown NumUpDownWidth;
        private NumericUpDown NumUpDownHeight;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label labelAngle;
        private Label labelRadius;
        private NumericUpDown nRadius;
        private NumericUpDown nAngle;
        private ColorDialog colorDialog1;
        private Button ChangePenColorButton;
    }
}
namespace AntennaCatalog.Forms
{
    partial class MagneticFieldCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagneticFieldCalculator));
            this.closeButton = new System.Windows.Forms.Button();
            this.currentElementEquationBox = new System.Windows.Forms.PictureBox();
            this.hLoopCenterPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rotationButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.fcRadiusFactor = new System.Windows.Forms.ComboBox();
            this.fcRadiusValueBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fcCurrentFactor = new System.Windows.Forms.ComboBox();
            this.fcCurrentValueBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.axialLengthValueBox = new System.Windows.Forms.TextBox();
            this.axialLengthFactor = new System.Windows.Forms.ComboBox();
            this.axialLengthResultBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.viewGeometryButton = new System.Windows.Forms.Button();
            this.resultUnit = new System.Windows.Forms.ComboBox();
            this.axialLengthUnit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.currentElementEquationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hLoopCenterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(18, 563);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(99, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // currentElementEquationBox
            // 
            this.currentElementEquationBox.Image = ((System.Drawing.Image)(resources.GetObject("currentElementEquationBox.Image")));
            this.currentElementEquationBox.Location = new System.Drawing.Point(6, 51);
            this.currentElementEquationBox.Name = "currentElementEquationBox";
            this.currentElementEquationBox.Size = new System.Drawing.Size(261, 61);
            this.currentElementEquationBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentElementEquationBox.TabIndex = 64;
            this.currentElementEquationBox.TabStop = false;
            // 
            // hLoopCenterPictureBox
            // 
            this.hLoopCenterPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("hLoopCenterPictureBox.Image")));
            this.hLoopCenterPictureBox.Location = new System.Drawing.Point(9, 211);
            this.hLoopCenterPictureBox.Name = "hLoopCenterPictureBox";
            this.hLoopCenterPictureBox.Size = new System.Drawing.Size(185, 163);
            this.hLoopCenterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hLoopCenterPictureBox.TabIndex = 66;
            this.hLoopCenterPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Is in its integral solution";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "The form of the magnetic field of a current element";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Graphically";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "In units";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(200, 228);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rotationButton);
            this.groupBox1.Controls.Add(this.currentElementEquationBox);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.hLoopCenterPictureBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 403);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Field at Center of Current Loop";
            // 
            // rotationButton
            // 
            this.rotationButton.Location = new System.Drawing.Point(229, 351);
            this.rotationButton.Name = "rotationButton";
            this.rotationButton.Size = new System.Drawing.Size(103, 23);
            this.rotationButton.TabIndex = 94;
            this.rotationButton.Text = "Rotation";
            this.rotationButton.UseVisualStyleBackColor = true;
            this.rotationButton.Click += new System.EventHandler(this.rotationButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(615, 459);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // fcRadiusFactor
            // 
            this.fcRadiusFactor.FormattingEnabled = true;
            this.fcRadiusFactor.Items.AddRange(new object[] {
            "mm",
            "cm",
            "m"});
            this.fcRadiusFactor.Location = new System.Drawing.Point(259, 465);
            this.fcRadiusFactor.Name = "fcRadiusFactor";
            this.fcRadiusFactor.Size = new System.Drawing.Size(46, 21);
            this.fcRadiusFactor.TabIndex = 3;
            // 
            // fcRadiusValueBox
            // 
            this.fcRadiusValueBox.Location = new System.Drawing.Point(206, 466);
            this.fcRadiusValueBox.Name = "fcRadiusValueBox";
            this.fcRadiusValueBox.Size = new System.Drawing.Size(47, 20);
            this.fcRadiusValueBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "r";
            // 
            // fcCurrentFactor
            // 
            this.fcCurrentFactor.FormattingEnabled = true;
            this.fcCurrentFactor.Items.AddRange(new object[] {
            "uA",
            "mA",
            "A"});
            this.fcCurrentFactor.Location = new System.Drawing.Point(259, 440);
            this.fcCurrentFactor.Name = "fcCurrentFactor";
            this.fcCurrentFactor.Size = new System.Drawing.Size(46, 21);
            this.fcCurrentFactor.TabIndex = 1;
            // 
            // fcCurrentValueBox
            // 
            this.fcCurrentValueBox.Location = new System.Drawing.Point(206, 440);
            this.fcCurrentValueBox.Name = "fcCurrentValueBox";
            this.fcCurrentValueBox.Size = new System.Drawing.Size(47, 20);
            this.fcCurrentValueBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "I";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "B =";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(198, 504);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(99, 20);
            this.resultBox.TabIndex = 82;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Location = new System.Drawing.Point(375, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 399);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Field on Axis of Current Loop";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(200, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 73;
            this.label15.Text = "Graphically";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 128);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(253, 265);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 73;
            this.pictureBox4.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 13);
            this.label14.TabIndex = 73;
            this.label14.Text = "The form for the centerline along z";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 73;
            this.pictureBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(386, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = "At a distance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(386, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 88;
            this.label11.Text = "z";
            // 
            // axialLengthValueBox
            // 
            this.axialLengthValueBox.Location = new System.Drawing.Point(402, 440);
            this.axialLengthValueBox.Name = "axialLengthValueBox";
            this.axialLengthValueBox.Size = new System.Drawing.Size(47, 20);
            this.axialLengthValueBox.TabIndex = 4;
            // 
            // axialLengthFactor
            // 
            this.axialLengthFactor.FormattingEnabled = true;
            this.axialLengthFactor.Items.AddRange(new object[] {
            "mm",
            "cm",
            "m"});
            this.axialLengthFactor.Location = new System.Drawing.Point(455, 440);
            this.axialLengthFactor.Name = "axialLengthFactor";
            this.axialLengthFactor.Size = new System.Drawing.Size(46, 21);
            this.axialLengthFactor.TabIndex = 5;
            // 
            // axialLengthResultBox
            // 
            this.axialLengthResultBox.Location = new System.Drawing.Point(402, 505);
            this.axialLengthResultBox.Name = "axialLengthResultBox";
            this.axialLengthResultBox.Size = new System.Drawing.Size(147, 20);
            this.axialLengthResultBox.TabIndex = 91;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(375, 507);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 90;
            this.label13.Text = "B =";
            // 
            // viewGeometryButton
            // 
            this.viewGeometryButton.Location = new System.Drawing.Point(21, 444);
            this.viewGeometryButton.Name = "viewGeometryButton";
            this.viewGeometryButton.Size = new System.Drawing.Size(103, 23);
            this.viewGeometryButton.TabIndex = 93;
            this.viewGeometryButton.Text = "View Geometry";
            this.viewGeometryButton.UseVisualStyleBackColor = true;
            this.viewGeometryButton.Click += new System.EventHandler(this.viewGeometryButton_Click);
            // 
            // resultUnit
            // 
            this.resultUnit.FormattingEnabled = true;
            this.resultUnit.Items.AddRange(new object[] {
            "T",
            "Gauss"});
            this.resultUnit.Location = new System.Drawing.Point(303, 504);
            this.resultUnit.Name = "resultUnit";
            this.resultUnit.Size = new System.Drawing.Size(58, 21);
            this.resultUnit.TabIndex = 7;
            this.resultUnit.SelectedIndexChanged += new System.EventHandler(this.resultUnit_SelectedIndexChanged);
            // 
            // axialLengthUnit
            // 
            this.axialLengthUnit.FormattingEnabled = true;
            this.axialLengthUnit.Items.AddRange(new object[] {
            "T",
            "Gauss"});
            this.axialLengthUnit.Location = new System.Drawing.Point(555, 505);
            this.axialLengthUnit.Name = "axialLengthUnit";
            this.axialLengthUnit.Size = new System.Drawing.Size(58, 21);
            this.axialLengthUnit.TabIndex = 8;
            this.axialLengthUnit.SelectedIndexChanged += new System.EventHandler(this.axialLengthUnit_SelectedIndexChanged);
            // 
            // MagneticFieldCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 597);
            this.Controls.Add(this.axialLengthUnit);
            this.Controls.Add(this.resultUnit);
            this.Controls.Add(this.viewGeometryButton);
            this.Controls.Add(this.axialLengthResultBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.axialLengthFactor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.axialLengthValueBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.fcRadiusFactor);
            this.Controls.Add(this.fcCurrentFactor);
            this.Controls.Add(this.fcRadiusValueBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fcCurrentValueBox);
            this.Name = "MagneticFieldCalculator";
            this.Text = "Loop Proof Palette";
            ((System.ComponentModel.ISupportInitialize)(this.currentElementEquationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hLoopCenterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox currentElementEquationBox;
        private System.Windows.Forms.PictureBox hLoopCenterPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox fcCurrentFactor;
        private System.Windows.Forms.TextBox fcCurrentValueBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox fcRadiusFactor;
        private System.Windows.Forms.TextBox fcRadiusValueBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox axialLengthValueBox;
        private System.Windows.Forms.ComboBox axialLengthFactor;
        private System.Windows.Forms.TextBox axialLengthResultBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button viewGeometryButton;
        private System.Windows.Forms.ComboBox resultUnit;
        private System.Windows.Forms.ComboBox axialLengthUnit;
        private System.Windows.Forms.Button rotationButton;
    }
}
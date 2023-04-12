namespace ILSmodel
{
    partial class TrainingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingForm));
            this.PositionVerticalGroupBox = new System.Windows.Forms.GroupBox();
            this.PlaneVertical = new System.Windows.Forms.PictureBox();
            this.FailureButton = new System.Windows.Forms.Button();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.VerticalPB = new System.Windows.Forms.PictureBox();
            this.DisplaysGroupBox = new System.Windows.Forms.GroupBox();
            this.FlightDirector = new System.Windows.Forms.PictureBox();
            this.HeightPFD = new System.Windows.Forms.Label();
            this.SpeedLabelPFD = new System.Windows.Forms.Label();
            this.HeadingLabelNav = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ControlGroupBox = new System.Windows.Forms.GroupBox();
            this.HeightDown = new System.Windows.Forms.Button();
            this.HeightUP = new System.Windows.Forms.Button();
            this.HeadingRightButton = new System.Windows.Forms.Button();
            this.HeadingLeftButton = new System.Windows.Forms.Button();
            this.APPButton = new System.Windows.Forms.Button();
            this.LocButton = new System.Windows.Forms.Button();
            this.PositionHorizontalGroupBox = new System.Windows.Forms.GroupBox();
            this.PlaneHorizontal = new System.Windows.Forms.PictureBox();
            this.MinimumLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HorizontalPB = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeNotToGoAround = new System.Windows.Forms.Timer(this.components);
            this.PositionVerticalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalPB)).BeginInit();
            this.DisplaysGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlightDirector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ControlGroupBox.SuspendLayout();
            this.PositionHorizontalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalPB)).BeginInit();
            this.SuspendLayout();
            // 
            // PositionVerticalGroupBox
            // 
            this.PositionVerticalGroupBox.Controls.Add(this.PlaneVertical);
            this.PositionVerticalGroupBox.Controls.Add(this.FailureButton);
            this.PositionVerticalGroupBox.Controls.Add(this.HeadingLabel);
            this.PositionVerticalGroupBox.Controls.Add(this.VerticalPB);
            this.PositionVerticalGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PositionVerticalGroupBox.Location = new System.Drawing.Point(9, 284);
            this.PositionVerticalGroupBox.Name = "PositionVerticalGroupBox";
            this.PositionVerticalGroupBox.Size = new System.Drawing.Size(485, 489);
            this.PositionVerticalGroupBox.TabIndex = 0;
            this.PositionVerticalGroupBox.TabStop = false;
            this.PositionVerticalGroupBox.Text = "Вертикальное положение ВС";
            // 
            // PlaneVertical
            // 
            this.PlaneVertical.BackColor = System.Drawing.Color.Transparent;
            this.PlaneVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlaneVertical.ErrorImage = global::ILSmodel.Properties.Resources.plane_point;
            this.PlaneVertical.Image = global::ILSmodel.Properties.Resources.plane_point;
            this.PlaneVertical.InitialImage = global::ILSmodel.Properties.Resources.plane_point;
            this.PlaneVertical.Location = new System.Drawing.Point(243, 20);
            this.PlaneVertical.Name = "PlaneVertical";
            this.PlaneVertical.Size = new System.Drawing.Size(18, 20);
            this.PlaneVertical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlaneVertical.TabIndex = 7;
            this.PlaneVertical.TabStop = false;
            // 
            // FailureButton
            // 
            this.FailureButton.Location = new System.Drawing.Point(373, 456);
            this.FailureButton.Name = "FailureButton";
            this.FailureButton.Size = new System.Drawing.Size(106, 29);
            this.FailureButton.TabIndex = 13;
            this.FailureButton.Text = "Отказ КРМ";
            this.FailureButton.UseVisualStyleBackColor = true;
            this.FailureButton.Click += new System.EventHandler(this.FailureButton_Click);
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Location = new System.Drawing.Point(338, 16);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(81, 23);
            this.HeadingLabel.TabIndex = 12;
            this.HeadingLabel.Text = "Курс ВС: ";
            // 
            // VerticalPB
            // 
            this.VerticalPB.BackgroundImage = global::ILSmodel.Properties.Resources.Vertical_ILS;
            this.VerticalPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VerticalPB.ErrorImage = global::ILSmodel.Properties.Resources.Vertical_ILS;
            this.VerticalPB.InitialImage = global::ILSmodel.Properties.Resources.Vertical_ILS;
            this.VerticalPB.Location = new System.Drawing.Point(6, 94);
            this.VerticalPB.Name = "VerticalPB";
            this.VerticalPB.Size = new System.Drawing.Size(463, 260);
            this.VerticalPB.TabIndex = 1;
            this.VerticalPB.TabStop = false;
            // 
            // DisplaysGroupBox
            // 
            this.DisplaysGroupBox.Controls.Add(this.FlightDirector);
            this.DisplaysGroupBox.Controls.Add(this.HeightPFD);
            this.DisplaysGroupBox.Controls.Add(this.SpeedLabelPFD);
            this.DisplaysGroupBox.Controls.Add(this.HeadingLabelNav);
            this.DisplaysGroupBox.Controls.Add(this.pictureBox2);
            this.DisplaysGroupBox.Controls.Add(this.pictureBox1);
            this.DisplaysGroupBox.Controls.Add(this.label8);
            this.DisplaysGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplaysGroupBox.Location = new System.Drawing.Point(9, 14);
            this.DisplaysGroupBox.Name = "DisplaysGroupBox";
            this.DisplaysGroupBox.Size = new System.Drawing.Size(485, 264);
            this.DisplaysGroupBox.TabIndex = 1;
            this.DisplaysGroupBox.TabStop = false;
            this.DisplaysGroupBox.Text = "Дисплеи";
            // 
            // FlightDirector
            // 
            this.FlightDirector.BackColor = System.Drawing.Color.Transparent;
            this.FlightDirector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FlightDirector.BackgroundImage")));
            this.FlightDirector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlightDirector.Location = new System.Drawing.Point(117, 223);
            this.FlightDirector.Name = "FlightDirector";
            this.FlightDirector.Size = new System.Drawing.Size(19, 23);
            this.FlightDirector.TabIndex = 11;
            this.FlightDirector.TabStop = false;
            // 
            // HeightPFD
            // 
            this.HeightPFD.BackColor = System.Drawing.Color.Moccasin;
            this.HeightPFD.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightPFD.Location = new System.Drawing.Point(212, 117);
            this.HeightPFD.Name = "HeightPFD";
            this.HeightPFD.Size = new System.Drawing.Size(44, 23);
            this.HeightPFD.TabIndex = 10;
            this.HeightPFD.Text = "999";
            this.HeightPFD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpeedLabelPFD
            // 
            this.SpeedLabelPFD.BackColor = System.Drawing.Color.Gold;
            this.SpeedLabelPFD.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpeedLabelPFD.Location = new System.Drawing.Point(39, 117);
            this.SpeedLabelPFD.Name = "SpeedLabelPFD";
            this.SpeedLabelPFD.Size = new System.Drawing.Size(34, 23);
            this.SpeedLabelPFD.TabIndex = 9;
            this.SpeedLabelPFD.Text = "999";
            this.SpeedLabelPFD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeadingLabelNav
            // 
            this.HeadingLabelNav.BackColor = System.Drawing.Color.Silver;
            this.HeadingLabelNav.Location = new System.Drawing.Point(335, 43);
            this.HeadingLabelNav.Name = "HeadingLabelNav";
            this.HeadingLabelNav.Size = new System.Drawing.Size(89, 23);
            this.HeadingLabelNav.TabIndex = 3;
            this.HeadingLabelNav.Text = "999";
            this.HeadingLabelNav.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ILSmodel.Properties.Resources.NavDisplay;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(289, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 171);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ILSmodel.Properties.Resources.PFD_center;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 230);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Курс:";
            // 
            // ControlGroupBox
            // 
            this.ControlGroupBox.Controls.Add(this.HeightDown);
            this.ControlGroupBox.Controls.Add(this.HeightUP);
            this.ControlGroupBox.Controls.Add(this.HeadingRightButton);
            this.ControlGroupBox.Controls.Add(this.HeadingLeftButton);
            this.ControlGroupBox.Controls.Add(this.APPButton);
            this.ControlGroupBox.Controls.Add(this.LocButton);
            this.ControlGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ControlGroupBox.Location = new System.Drawing.Point(500, 14);
            this.ControlGroupBox.Name = "ControlGroupBox";
            this.ControlGroupBox.Size = new System.Drawing.Size(477, 264);
            this.ControlGroupBox.TabIndex = 2;
            this.ControlGroupBox.TabStop = false;
            this.ControlGroupBox.Text = "Управление ВС";
            // 
            // HeightDown
            // 
            this.HeightDown.BackColor = System.Drawing.Color.Peru;
            this.HeightDown.Location = new System.Drawing.Point(77, 181);
            this.HeightDown.Name = "HeightDown";
            this.HeightDown.Size = new System.Drawing.Size(147, 46);
            this.HeightDown.TabIndex = 5;
            this.HeightDown.Text = "Снизиться";
            this.HeightDown.UseVisualStyleBackColor = false;
            this.HeightDown.Click += new System.EventHandler(this.HeightDown_Click);
            // 
            // HeightUP
            // 
            this.HeightUP.BackColor = System.Drawing.Color.PaleTurquoise;
            this.HeightUP.Location = new System.Drawing.Point(77, 77);
            this.HeightUP.Name = "HeightUP";
            this.HeightUP.Size = new System.Drawing.Size(147, 46);
            this.HeightUP.TabIndex = 4;
            this.HeightUP.Text = "Набрать высоту";
            this.HeightUP.UseVisualStyleBackColor = false;
            this.HeightUP.Click += new System.EventHandler(this.HeightUP_Click);
            // 
            // HeadingRightButton
            // 
            this.HeadingRightButton.Location = new System.Drawing.Point(150, 129);
            this.HeadingRightButton.Name = "HeadingRightButton";
            this.HeadingRightButton.Size = new System.Drawing.Size(138, 46);
            this.HeadingRightButton.TabIndex = 3;
            this.HeadingRightButton.Text = "Курс прав -->";
            this.HeadingRightButton.UseVisualStyleBackColor = true;
            this.HeadingRightButton.Click += new System.EventHandler(this.HeadingRightButton_Click);
            // 
            // HeadingLeftButton
            // 
            this.HeadingLeftButton.Location = new System.Drawing.Point(6, 129);
            this.HeadingLeftButton.Name = "HeadingLeftButton";
            this.HeadingLeftButton.Size = new System.Drawing.Size(138, 46);
            this.HeadingLeftButton.TabIndex = 2;
            this.HeadingLeftButton.Text = "Курс лев <--";
            this.HeadingLeftButton.UseVisualStyleBackColor = true;
            this.HeadingLeftButton.Click += new System.EventHandler(this.HeadingLeftButton_Click);
            // 
            // APPButton
            // 
            this.APPButton.BackColor = System.Drawing.Color.Red;
            this.APPButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.APPButton.Location = new System.Drawing.Point(331, 210);
            this.APPButton.Name = "APPButton";
            this.APPButton.Size = new System.Drawing.Size(140, 46);
            this.APPButton.TabIndex = 1;
            this.APPButton.Text = "APP";
            this.APPButton.UseVisualStyleBackColor = false;
            this.APPButton.Click += new System.EventHandler(this.APPButton_Click);
            // 
            // LocButton
            // 
            this.LocButton.BackColor = System.Drawing.Color.Red;
            this.LocButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LocButton.Location = new System.Drawing.Point(331, 142);
            this.LocButton.Name = "LocButton";
            this.LocButton.Size = new System.Drawing.Size(140, 46);
            this.LocButton.TabIndex = 0;
            this.LocButton.Text = "LOC";
            this.LocButton.UseVisualStyleBackColor = false;
            this.LocButton.Click += new System.EventHandler(this.LocButton_Click);
            // 
            // PositionHorizontalGroupBox
            // 
            this.PositionHorizontalGroupBox.Controls.Add(this.PlaneHorizontal);
            this.PositionHorizontalGroupBox.Controls.Add(this.MinimumLabel);
            this.PositionHorizontalGroupBox.Controls.Add(this.HeightLabel);
            this.PositionHorizontalGroupBox.Controls.Add(this.HorizontalPB);
            this.PositionHorizontalGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PositionHorizontalGroupBox.Location = new System.Drawing.Point(500, 284);
            this.PositionHorizontalGroupBox.Name = "PositionHorizontalGroupBox";
            this.PositionHorizontalGroupBox.Size = new System.Drawing.Size(477, 489);
            this.PositionHorizontalGroupBox.TabIndex = 3;
            this.PositionHorizontalGroupBox.TabStop = false;
            this.PositionHorizontalGroupBox.Text = "Горизонтальное положение ВС";
            // 
            // PlaneHorizontal
            // 
            this.PlaneHorizontal.BackColor = System.Drawing.Color.Transparent;
            this.PlaneHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlaneHorizontal.ErrorImage = global::ILSmodel.Properties.Resources.plane_point;
            this.PlaneHorizontal.Image = global::ILSmodel.Properties.Resources.plane_point;
            this.PlaneHorizontal.InitialImage = global::ILSmodel.Properties.Resources.plane_point;
            this.PlaneHorizontal.Location = new System.Drawing.Point(293, 20);
            this.PlaneHorizontal.Name = "PlaneHorizontal";
            this.PlaneHorizontal.Size = new System.Drawing.Size(18, 20);
            this.PlaneHorizontal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlaneHorizontal.TabIndex = 10;
            this.PlaneHorizontal.TabStop = false;
            // 
            // MinimumLabel
            // 
            this.MinimumLabel.AutoSize = true;
            this.MinimumLabel.Location = new System.Drawing.Point(6, 459);
            this.MinimumLabel.Name = "MinimumLabel";
            this.MinimumLabel.Size = new System.Drawing.Size(87, 23);
            this.MinimumLabel.TabIndex = 14;
            this.MinimumLabel.Text = "Minimum:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(317, 16);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(153, 23);
            this.HeightLabel.TabIndex = 11;
            this.HeightLabel.Text = "Высота ВС:  3000ft";
            // 
            // HorizontalPB
            // 
            this.HorizontalPB.BackgroundImage = global::ILSmodel.Properties.Resources.Horizontal_ILS;
            this.HorizontalPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HorizontalPB.ErrorImage = global::ILSmodel.Properties.Resources.Horizontal_ILS;
            this.HorizontalPB.InitialImage = global::ILSmodel.Properties.Resources.Horizontal_ILS;
            this.HorizontalPB.Location = new System.Drawing.Point(6, 94);
            this.HorizontalPB.Name = "HorizontalPB";
            this.HorizontalPB.Size = new System.Drawing.Size(457, 260);
            this.HorizontalPB.TabIndex = 9;
            this.HorizontalPB.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 600;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeNotToGoAround
            // 
            this.timeNotToGoAround.Tick += new System.EventHandler(this.timeNotToGoAround_Tick);
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(989, 775);
            this.Controls.Add(this.PositionHorizontalGroupBox);
            this.Controls.Add(this.ControlGroupBox);
            this.Controls.Add(this.DisplaysGroupBox);
            this.Controls.Add(this.PositionVerticalGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1007, 822);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1007, 822);
            this.Name = "TrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainingForm_FormClosing);
            this.Load += new System.EventHandler(this.TrainingForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrainingForm_KeyDown);
            this.PositionVerticalGroupBox.ResumeLayout(false);
            this.PositionVerticalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalPB)).EndInit();
            this.DisplaysGroupBox.ResumeLayout(false);
            this.DisplaysGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlightDirector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ControlGroupBox.ResumeLayout(false);
            this.PositionHorizontalGroupBox.ResumeLayout(false);
            this.PositionHorizontalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox PositionVerticalGroupBox;
        private PictureBox VerticalPB;
        private GroupBox DisplaysGroupBox;
        private GroupBox ControlGroupBox;
        private Button LocButton;
        private Button APPButton;
        private Button HeadingLeftButton;
        private Button HeadingRightButton;
        private Button HeightUP;
        private Button HeightDown;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox PlaneVertical;
        private Label HeadingLabelNav;
        private GroupBox PositionHorizontalGroupBox;
        private PictureBox PlaneHorizontal;
        private PictureBox HorizontalPB;
        private Label HeightLabel;
        private Label HeadingLabel;
        private Button FailureButton;
        private Label MinimumLabel;
        private Label HeightPFD;
        private Label SpeedLabelPFD;
        private System.Windows.Forms.Timer timer;
        private Label label8;
        private System.Windows.Forms.Timer timeNotToGoAround;
        private PictureBox FlightDirector;
    }
}
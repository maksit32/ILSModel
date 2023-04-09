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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingForm));
            this.PositionGroupBox = new System.Windows.Forms.GroupBox();
            this.VerticalPB = new System.Windows.Forms.PictureBox();
            this.HorizontalPB = new System.Windows.Forms.PictureBox();
            this.DisplaysGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ControlGroupBox = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.APPButton = new System.Windows.Forms.Button();
            this.LocButton = new System.Windows.Forms.Button();
            this.PlaneVertical = new System.Windows.Forms.PictureBox();
            this.PlaneHorizontal = new System.Windows.Forms.PictureBox();
            this.PositionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalPB)).BeginInit();
            this.DisplaysGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ControlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneHorizontal)).BeginInit();
            this.SuspendLayout();
            // 
            // PositionGroupBox
            // 
            this.PositionGroupBox.Controls.Add(this.PlaneHorizontal);
            this.PositionGroupBox.Controls.Add(this.PlaneVertical);
            this.PositionGroupBox.Controls.Add(this.VerticalPB);
            this.PositionGroupBox.Controls.Add(this.HorizontalPB);
            this.PositionGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PositionGroupBox.Location = new System.Drawing.Point(9, 284);
            this.PositionGroupBox.Name = "PositionGroupBox";
            this.PositionGroupBox.Size = new System.Drawing.Size(951, 360);
            this.PositionGroupBox.TabIndex = 0;
            this.PositionGroupBox.TabStop = false;
            this.PositionGroupBox.Text = "Позиция ВС";
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
            // HorizontalPB
            // 
            this.HorizontalPB.BackgroundImage = global::ILSmodel.Properties.Resources.Horizontal_ILS;
            this.HorizontalPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HorizontalPB.ErrorImage = global::ILSmodel.Properties.Resources.Horizontal_ILS;
            this.HorizontalPB.InitialImage = global::ILSmodel.Properties.Resources.Horizontal_ILS;
            this.HorizontalPB.Location = new System.Drawing.Point(481, 94);
            this.HorizontalPB.Name = "HorizontalPB";
            this.HorizontalPB.Size = new System.Drawing.Size(463, 260);
            this.HorizontalPB.TabIndex = 0;
            this.HorizontalPB.TabStop = false;
            // 
            // DisplaysGroupBox
            // 
            this.DisplaysGroupBox.Controls.Add(this.pictureBox2);
            this.DisplaysGroupBox.Controls.Add(this.pictureBox1);
            this.DisplaysGroupBox.Controls.Add(this.label8);
            this.DisplaysGroupBox.Controls.Add(this.label7);
            this.DisplaysGroupBox.Controls.Add(this.label5);
            this.DisplaysGroupBox.Controls.Add(this.label4);
            this.DisplaysGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplaysGroupBox.Location = new System.Drawing.Point(9, 14);
            this.DisplaysGroupBox.Name = "DisplaysGroupBox";
            this.DisplaysGroupBox.Size = new System.Drawing.Size(469, 264);
            this.DisplaysGroupBox.TabIndex = 1;
            this.DisplaysGroupBox.TabStop = false;
            this.DisplaysGroupBox.Text = "Дисплеи";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ILSmodel.Properties.Resources.NavDisplay;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(262, 41);
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
            this.pictureBox1.Size = new System.Drawing.Size(228, 230);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Минимум:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Закрылки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "OnAPP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "OnLock:";
            // 
            // ControlGroupBox
            // 
            this.ControlGroupBox.Controls.Add(this.button6);
            this.ControlGroupBox.Controls.Add(this.button5);
            this.ControlGroupBox.Controls.Add(this.button4);
            this.ControlGroupBox.Controls.Add(this.button3);
            this.ControlGroupBox.Controls.Add(this.button2);
            this.ControlGroupBox.Controls.Add(this.button1);
            this.ControlGroupBox.Controls.Add(this.APPButton);
            this.ControlGroupBox.Controls.Add(this.LocButton);
            this.ControlGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ControlGroupBox.Location = new System.Drawing.Point(484, 14);
            this.ControlGroupBox.Name = "ControlGroupBox";
            this.ControlGroupBox.Size = new System.Drawing.Size(476, 264);
            this.ControlGroupBox.TabIndex = 2;
            this.ControlGroupBox.TabStop = false;
            this.ControlGroupBox.Text = "Управление ВС";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(331, 81);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 38);
            this.button6.TabIndex = 7;
            this.button6.Text = "Закрылки выпуск:";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(331, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 38);
            this.button5.TabIndex = 6;
            this.button5.Text = "Закрылки вверх";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Peru;
            this.button4.Location = new System.Drawing.Point(77, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 46);
            this.button4.TabIndex = 5;
            this.button4.Text = "Высота вниз";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Location = new System.Drawing.Point(77, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "Высота вверх ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Курс прав -->";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Курс лев <--";
            this.button1.UseVisualStyleBackColor = true;
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
            // 
            // PlaneVertical
            // 
            this.PlaneVertical.BackColor = System.Drawing.Color.Transparent;
            this.PlaneVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlaneVertical.ErrorImage = global::ILSmodel.Properties.Resources.plane_point;
            this.PlaneVertical.Image = global::ILSmodel.Properties.Resources.plane_point;
            this.PlaneVertical.InitialImage = global::ILSmodel.Properties.Resources.plane_point;
            this.PlaneVertical.Location = new System.Drawing.Point(381, 16);
            this.PlaneVertical.Name = "PlaneVertical";
            this.PlaneVertical.Size = new System.Drawing.Size(18, 20);
            this.PlaneVertical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlaneVertical.TabIndex = 7;
            this.PlaneVertical.TabStop = false;
            // 
            // PlaneHorizontal
            // 
            this.PlaneHorizontal.BackColor = System.Drawing.Color.Transparent;
            this.PlaneHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlaneHorizontal.ErrorImage = global::ILSmodel.Properties.Resources.plane_point;
            this.PlaneHorizontal.Image = global::ILSmodel.Properties.Resources.plane_point;
            this.PlaneHorizontal.InitialImage = global::ILSmodel.Properties.Resources.plane_point;
            this.PlaneHorizontal.Location = new System.Drawing.Point(806, 16);
            this.PlaneHorizontal.Name = "PlaneHorizontal";
            this.PlaneHorizontal.Size = new System.Drawing.Size(18, 20);
            this.PlaneHorizontal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlaneHorizontal.TabIndex = 8;
            this.PlaneHorizontal.TabStop = false;
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(967, 656);
            this.Controls.Add(this.ControlGroupBox);
            this.Controls.Add(this.DisplaysGroupBox);
            this.Controls.Add(this.PositionGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainingForm_FormClosing);
            this.Load += new System.EventHandler(this.TrainingForm_Load);
            this.PositionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VerticalPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalPB)).EndInit();
            this.DisplaysGroupBox.ResumeLayout(false);
            this.DisplaysGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ControlGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlaneVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneHorizontal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox PositionGroupBox;
        private PictureBox VerticalPB;
        private PictureBox HorizontalPB;
        private GroupBox DisplaysGroupBox;
        private GroupBox ControlGroupBox;
        private Button LocButton;
        private Button APPButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label5;
        private Label label4;
        private Label label7;
        private Button button5;
        private Button button6;
        private Label label8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox PlaneHorizontal;
        private PictureBox PlaneVertical;
    }
}
namespace eilidh_assign3
{
    partial class Card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            lblName = new Label();
            lblMainStyle = new Label();
            lblDOB = new Label();
            lblDOD = new Label();
            lblYearsActive = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.Control;
            pictureBox.Location = new Point(15, 17);
            pictureBox.Margin = new Padding(4, 2, 4, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(370, 370);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(175, 397);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 32);
            lblName.TabIndex = 1;
            // 
            // lblMainStyle
            // 
            lblMainStyle.AutoSize = true;
            lblMainStyle.Location = new Point(176, 461);
            lblMainStyle.Margin = new Padding(4, 0, 4, 0);
            lblMainStyle.Name = "lblMainStyle";
            lblMainStyle.Size = new Size(0, 32);
            lblMainStyle.TabIndex = 2;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(176, 525);
            lblDOB.Margin = new Padding(4, 0, 4, 0);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(0, 32);
            lblDOB.TabIndex = 3;
            // 
            // lblDOD
            // 
            lblDOD.AutoSize = true;
            lblDOD.Location = new Point(175, 589);
            lblDOD.Margin = new Padding(4, 0, 4, 0);
            lblDOD.Name = "lblDOD";
            lblDOD.Size = new Size(0, 32);
            lblDOD.TabIndex = 4;
            // 
            // lblYearsActive
            // 
            lblYearsActive.AutoSize = true;
            lblYearsActive.Location = new Point(175, 653);
            lblYearsActive.Margin = new Padding(6, 0, 6, 0);
            lblYearsActive.Name = "lblYearsActive";
            lblYearsActive.Size = new Size(0, 32);
            lblYearsActive.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 397);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 6;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 461);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 32);
            label2.TabIndex = 7;
            label2.Text = "Main Style:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 525);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(155, 32);
            label3.TabIndex = 8;
            label3.Text = "Date of Birth:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 589);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 32);
            label4.TabIndex = 9;
            label4.Text = "Date of Death:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 653);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(145, 32);
            label5.TabIndex = 10;
            label5.Text = "Years Active:";
            // 
            // Card
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblYearsActive);
            Controls.Add(lblDOD);
            Controls.Add(lblDOB);
            Controls.Add(lblMainStyle);
            Controls.Add(lblName);
            Controls.Add(pictureBox);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Card";
            Size = new Size(401, 779);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label lblName;
        private Label lblMainStyle;
        private Label lblDOB;
        private Label lblDOD;
        private Label lblYearsActive;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}

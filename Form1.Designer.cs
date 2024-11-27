namespace eilidh_assign3
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
            card1 = new Card();
            listView1 = new ListView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtFullName = new TextBox();
            txtDOB = new TextBox();
            txtDOD = new TextBox();
            txtMainStyle = new TextBox();
            txtYearsActive = new TextBox();
            btnSelectImage = new Button();
            btnClearCard = new Button();
            SuspendLayout();
            // 
            // card1
            // 
            card1.BorderStyle = BorderStyle.FixedSingle;
            card1.DOBText = "";
            card1.DODText = "";
            card1.Location = new Point(526, 88);
            card1.MainStyleText = "";
            card1.Margin = new Padding(2, 0, 2, 0);
            card1.Name = "card1";
            card1.NameText = "";
            card1.ProfileImage = null;
            card1.Size = new Size(401, 705);
            card1.TabIndex = 0;
            card1.YearsActiveText = "";
            // 
            // listView1
            // 
            listView1.Location = new Point(28, 19);
            listView1.Margin = new Padding(4, 2, 4, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(444, 772);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(273, 979);
            btnAdd.Margin = new Padding(6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 49);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(581, 979);
            btnDelete.Margin = new Padding(6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 49);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(427, 979);
            btnUpdate.Margin = new Padding(6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(139, 49);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(260, 832);
            txtFullName.Margin = new Padding(6);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(387, 39);
            txtFullName.TabIndex = 5;
            txtFullName.Text = "Name";
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(67, 894);
            txtDOB.Margin = new Padding(6);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(258, 39);
            txtDOB.TabIndex = 6;
            txtDOB.Text = "DOB";
            // 
            // txtDOD
            // 
            txtDOD.Location = new Point(340, 894);
            txtDOD.Margin = new Padding(6);
            txtDOD.Name = "txtDOD";
            txtDOD.Size = new Size(258, 39);
            txtDOD.TabIndex = 7;
            txtDOD.Text = "DOD";
            // 
            // txtMainStyle
            // 
            txtMainStyle.Location = new Point(661, 832);
            txtMainStyle.Margin = new Padding(6);
            txtMainStyle.Name = "txtMainStyle";
            txtMainStyle.Size = new Size(236, 39);
            txtMainStyle.TabIndex = 8;
            txtMainStyle.Text = "Main Style";
            // 
            // txtYearsActive
            // 
            txtYearsActive.Location = new Point(613, 894);
            txtYearsActive.Margin = new Padding(6);
            txtYearsActive.Name = "txtYearsActive";
            txtYearsActive.Size = new Size(284, 39);
            txtYearsActive.TabIndex = 9;
            txtYearsActive.Text = "Years Active";
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(67, 832);
            btnSelectImage.Margin = new Padding(6);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(182, 39);
            btnSelectImage.TabIndex = 10;
            btnSelectImage.Text = "Add Image";
            btnSelectImage.TextAlign = ContentAlignment.TopLeft;
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // btnClearCard
            // 
            btnClearCard.Location = new Point(777, 19);
            btnClearCard.Name = "btnClearCard";
            btnClearCard.Size = new Size(150, 46);
            btnClearCard.TabIndex = 11;
            btnClearCard.Text = "Clear Card";
            btnClearCard.UseVisualStyleBackColor = true;
            btnClearCard.Click += btnClearCard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 1058);
            Controls.Add(btnClearCard);
            Controls.Add(btnSelectImage);
            Controls.Add(txtYearsActive);
            Controls.Add(txtMainStyle);
            Controls.Add(txtDOD);
            Controls.Add(txtDOB);
            Controls.Add(txtFullName);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(listView1);
            Controls.Add(card1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Card card1;
        private ListView listView1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtFullName;
        private TextBox txtDOB;
        private TextBox txtDOD;
        private TextBox txtMainStyle;
        private TextBox txtYearsActive;
        private Button btnSelectImage;
        private Button btnClearCard;
    }
}

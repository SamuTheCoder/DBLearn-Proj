namespace DBLearn
{
    partial class addStudent
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
            label1 = new Label();
            idBox = new TextBox();
            stNameBox = new TextBox();
            label2 = new Label();
            lstNameBox = new TextBox();
            label3 = new Label();
            genderBox = new TextBox();
            label4 = new Label();
            addrBox = new TextBox();
            label5 = new Label();
            ccBox = new TextBox();
            label6 = new Label();
            degreeBox = new TextBox();
            label7 = new Label();
            emailBox = new TextBox();
            label8 = new Label();
            submitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 74);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // idBox
            // 
            idBox.Location = new Point(207, 71);
            idBox.Name = "idBox";
            idBox.Size = new Size(125, 27);
            idBox.TabIndex = 1;
            // 
            // stNameBox
            // 
            stNameBox.Location = new Point(207, 121);
            stNameBox.Name = "stNameBox";
            stNameBox.Size = new Size(125, 27);
            stNameBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 124);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // lstNameBox
            // 
            lstNameBox.Location = new Point(207, 170);
            lstNameBox.Name = "lstNameBox";
            lstNameBox.Size = new Size(125, 27);
            lstNameBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 173);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // genderBox
            // 
            genderBox.Location = new Point(207, 221);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(125, 27);
            genderBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 224);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // addrBox
            // 
            addrBox.Location = new Point(530, 221);
            addrBox.Name = "addrBox";
            addrBox.Size = new Size(125, 27);
            addrBox.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 224);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 14;
            label5.Text = " Address";
            // 
            // ccBox
            // 
            ccBox.Location = new Point(530, 170);
            ccBox.Name = "ccBox";
            ccBox.Size = new Size(125, 27);
            ccBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(439, 173);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 12;
            label6.Text = "Nº CC";
            // 
            // degreeBox
            // 
            degreeBox.Location = new Point(530, 121);
            degreeBox.Name = "degreeBox";
            degreeBox.Size = new Size(125, 27);
            degreeBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(408, 124);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 10;
            label7.Text = "Degree ID";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(530, 71);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(125, 27);
            emailBox.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(439, 74);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 8;
            label8.Text = "Email";
            // 
            // submitBtn
            // 
            submitBtn.Font = new Font("Segoe UI", 14F);
            submitBtn.Location = new Point(302, 326);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(205, 86);
            submitBtn.TabIndex = 16;
            submitBtn.Text = "SUBMIT";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // addStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submitBtn);
            Controls.Add(addrBox);
            Controls.Add(label5);
            Controls.Add(ccBox);
            Controls.Add(label6);
            Controls.Add(degreeBox);
            Controls.Add(label7);
            Controls.Add(emailBox);
            Controls.Add(label8);
            Controls.Add(genderBox);
            Controls.Add(label4);
            Controls.Add(lstNameBox);
            Controls.Add(label3);
            Controls.Add(stNameBox);
            Controls.Add(label2);
            Controls.Add(idBox);
            Controls.Add(label1);
            Name = "addStudent";
            Text = "addStudent";
            Load += addStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox idBox;
        private TextBox stNameBox;
        private Label label2;
        private TextBox lstNameBox;
        private Label label3;
        private TextBox genderBox;
        private Label label4;
        private TextBox addrBox;
        private Label label5;
        private TextBox ccBox;
        private Label label6;
        private TextBox degreeBox;
        private Label label7;
        private TextBox emailBox;
        private Label label8;
        private Button submitBtn;
    }
}
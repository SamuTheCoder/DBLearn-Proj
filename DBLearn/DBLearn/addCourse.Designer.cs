namespace DBLearn
{
    partial class addCourse
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
            nameBox = new TextBox();
            label2 = new Label();
            creditsBox = new TextBox();
            label3 = new Label();
            descBox = new TextBox();
            label4 = new Label();
            deptBox = new TextBox();
            label6 = new Label();
            submitBtn = new Button();
            degreeIdBox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 42);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Course ID";
            // 
            // idBox
            // 
            idBox.Location = new Point(366, 42);
            idBox.Name = "idBox";
            idBox.Size = new Size(125, 27);
            idBox.TabIndex = 1;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(366, 90);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(125, 27);
            nameBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 90);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 2;
            label2.Text = "Course Name";
            // 
            // creditsBox
            // 
            creditsBox.Location = new Point(366, 184);
            creditsBox.Name = "creditsBox";
            creditsBox.Size = new Size(125, 27);
            creditsBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 191);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 6;
            label3.Text = "Credits";
            // 
            // descBox
            // 
            descBox.Location = new Point(366, 136);
            descBox.Name = "descBox";
            descBox.Size = new Size(125, 27);
            descBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 139);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 4;
            label4.Text = "Course Description";
            // 
            // deptBox
            // 
            deptBox.Location = new Point(366, 232);
            deptBox.Name = "deptBox";
            deptBox.Size = new Size(125, 27);
            deptBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 232);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 8;
            label6.Text = "Department Id";
            // 
            // submitBtn
            // 
            submitBtn.Font = new Font("Segoe UI", 14F);
            submitBtn.Location = new Point(297, 345);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(194, 71);
            submitBtn.TabIndex = 10;
            submitBtn.Text = "SUBMIT";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // degreeIdBox
            // 
            degreeIdBox.Location = new Point(366, 280);
            degreeIdBox.Name = "degreeIdBox";
            degreeIdBox.Size = new Size(125, 27);
            degreeIdBox.TabIndex = 12;
            degreeIdBox.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 283);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 11;
            label5.Text = "Associated Degree ID";
            // 
            // addCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(degreeIdBox);
            Controls.Add(label5);
            Controls.Add(submitBtn);
            Controls.Add(deptBox);
            Controls.Add(label6);
            Controls.Add(creditsBox);
            Controls.Add(label3);
            Controls.Add(descBox);
            Controls.Add(label4);
            Controls.Add(nameBox);
            Controls.Add(label2);
            Controls.Add(idBox);
            Controls.Add(label1);
            Name = "addCourse";
            Text = "addCourse";
            Load += addCourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox idBox;
        private TextBox nameBox;
        private Label label2;
        private TextBox creditsBox;
        private Label label3;
        private TextBox descBox;
        private Label label4;
        private TextBox deptBox;
        private Label label6;
        private Button submitBtn;
        private TextBox degreeIdBox;
        private Label label5;
    }
}
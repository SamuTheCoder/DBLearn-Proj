namespace DBLearn
{
    partial class addDegree
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
            levelBox = new TextBox();
            label4 = new Label();
            deptIdBox = new TextBox();
            label5 = new Label();
            prereqsBox = new TextBox();
            label6 = new Label();
            submitDegreeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 89);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Degree Name";
            // 
            // idBox
            // 
            idBox.Location = new Point(329, 34);
            idBox.Name = "idBox";
            idBox.Size = new Size(151, 27);
            idBox.TabIndex = 1;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(329, 82);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(151, 27);
            nameBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 41);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Degree ID";
            // 
            // creditsBox
            // 
            creditsBox.Location = new Point(329, 177);
            creditsBox.Name = "creditsBox";
            creditsBox.Size = new Size(151, 27);
            creditsBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 180);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 6;
            label3.Text = "Credits";
            // 
            // levelBox
            // 
            levelBox.Location = new Point(329, 129);
            levelBox.Name = "levelBox";
            levelBox.Size = new Size(151, 27);
            levelBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 132);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 4;
            label4.Text = "Degree Level";
            // 
            // deptIdBox
            // 
            deptIdBox.Location = new Point(329, 274);
            deptIdBox.Name = "deptIdBox";
            deptIdBox.Size = new Size(151, 27);
            deptIdBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 274);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 10;
            label5.Text = "Department ID";
            // 
            // prereqsBox
            // 
            prereqsBox.Location = new Point(329, 226);
            prereqsBox.Name = "prereqsBox";
            prereqsBox.Size = new Size(151, 27);
            prereqsBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 226);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 8;
            label6.Text = "Prerequisites";
            // 
            // submitDegreeBtn
            // 
            submitDegreeBtn.Font = new Font("Segoe UI", 14F);
            submitDegreeBtn.Location = new Point(272, 341);
            submitDegreeBtn.Name = "submitDegreeBtn";
            submitDegreeBtn.Size = new Size(223, 77);
            submitDegreeBtn.TabIndex = 12;
            submitDegreeBtn.Text = "SUBMIT";
            submitDegreeBtn.UseVisualStyleBackColor = true;
            submitDegreeBtn.Click += submitDegreeBtn_Click;
            // 
            // addDegree
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submitDegreeBtn);
            Controls.Add(deptIdBox);
            Controls.Add(label5);
            Controls.Add(prereqsBox);
            Controls.Add(label6);
            Controls.Add(creditsBox);
            Controls.Add(label3);
            Controls.Add(levelBox);
            Controls.Add(label4);
            Controls.Add(nameBox);
            Controls.Add(label2);
            Controls.Add(idBox);
            Controls.Add(label1);
            Name = "addDegree";
            Text = "addDegree";
            Load += addDegree_Load;
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
        private TextBox levelBox;
        private Label label4;
        private TextBox deptIdBox;
        private Label label5;
        private TextBox prereqsBox;
        private Label label6;
        private Button submitDegreeBtn;
    }
}
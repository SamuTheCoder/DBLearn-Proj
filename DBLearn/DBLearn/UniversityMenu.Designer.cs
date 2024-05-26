
namespace DBLearn
{
    partial class UniversityMenu
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
            departmentsBtn = new Button();
            degreesBtn = new Button();
            studentsBtn = new Button();
            uniLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // departmentsBtn
            // 
            departmentsBtn.Location = new Point(116, 194);
            departmentsBtn.Name = "departmentsBtn";
            departmentsBtn.Size = new Size(170, 58);
            departmentsBtn.TabIndex = 0;
            departmentsBtn.Text = "Departments";
            departmentsBtn.UseVisualStyleBackColor = true;
            departmentsBtn.Click += departmentsBtn_Click;
            // 
            // degreesBtn
            // 
            degreesBtn.Location = new Point(314, 194);
            degreesBtn.Name = "degreesBtn";
            degreesBtn.Size = new Size(170, 58);
            degreesBtn.TabIndex = 1;
            degreesBtn.Text = "Degrees";
            degreesBtn.UseVisualStyleBackColor = true;
            degreesBtn.Click += degreesBtn_Click;
            // 
            // studentsBtn
            // 
            studentsBtn.Location = new Point(511, 194);
            studentsBtn.Name = "studentsBtn";
            studentsBtn.Size = new Size(170, 58);
            studentsBtn.TabIndex = 4;
            studentsBtn.Text = "Students";
            studentsBtn.UseVisualStyleBackColor = true;
            studentsBtn.Click += studentsBtn_Click;
            // 
            // uniLabel
            // 
            uniLabel.AutoSize = true;
            uniLabel.Font = new Font("Segoe UI", 18F);
            uniLabel.Location = new Point(294, 73);
            uniLabel.Name = "uniLabel";
            uniLabel.Size = new Size(233, 41);
            uniLabel.TabIndex = 5;
            uniLabel.Text = "University Menu";
            uniLabel.TextAlign = ContentAlignment.TopCenter;
            uniLabel.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(212, 139);
            label2.Name = "label2";
            label2.Size = new Size(390, 28);
            label2.TabIndex = 6;
            label2.Text = "Choose one of the following to get it's data";
            label2.Click += uniLabel_Click;
            // 
            // UniversityMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(uniLabel);
            Controls.Add(studentsBtn);
            Controls.Add(degreesBtn);
            Controls.Add(departmentsBtn);
            Name = "UniversityMenu";
            Text = "UniversityMenu";
            Load += UniversityMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button departmentsBtn;
        private Button degreesBtn;
        private Button studentsBtn;
        private Label uniLabel;
        private Label label2;
    }
}
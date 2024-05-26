namespace DBLearn
{
    partial class CoursesForm
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
            dataGridView1 = new DataGridView();
            uniLabel = new Label();
            label1 = new Label();
            listCoursesBtn = new Button();
            addCourseBtn = new Button();
            rmvCourseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(381, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(906, 297);
            dataGridView1.TabIndex = 0;
            // 
            // uniLabel
            // 
            uniLabel.AutoSize = true;
            uniLabel.Font = new Font("Segoe UI", 18F);
            uniLabel.Location = new Point(606, 27);
            uniLabel.Name = "uniLabel";
            uniLabel.Size = new Size(63, 41);
            uniLabel.TabIndex = 1;
            uniLabel.Text = "Uni";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(567, 84);
            label1.Name = "label1";
            label1.Size = new Size(124, 41);
            label1.TabIndex = 2;
            label1.Text = "Courses";
            // 
            // listCoursesBtn
            // 
            listCoursesBtn.Location = new Point(1110, 148);
            listCoursesBtn.Name = "listCoursesBtn";
            listCoursesBtn.Size = new Size(177, 57);
            listCoursesBtn.TabIndex = 3;
            listCoursesBtn.Text = "List Courses";
            listCoursesBtn.UseVisualStyleBackColor = true;
            listCoursesBtn.Click += listCoursesBtn_Click;
            // 
            // addCourseBtn
            // 
            addCourseBtn.Location = new Point(12, 222);
            addCourseBtn.Name = "addCourseBtn";
            addCourseBtn.Size = new Size(177, 57);
            addCourseBtn.TabIndex = 4;
            addCourseBtn.Text = "Add Course";
            addCourseBtn.UseVisualStyleBackColor = true;
            addCourseBtn.Click += addCourseBtn_Click;
            // 
            // rmvCourseBtn
            // 
            rmvCourseBtn.Location = new Point(12, 332);
            rmvCourseBtn.Name = "rmvCourseBtn";
            rmvCourseBtn.Size = new Size(177, 57);
            rmvCourseBtn.TabIndex = 5;
            rmvCourseBtn.Text = "Remove Course";
            rmvCourseBtn.UseVisualStyleBackColor = true;
            rmvCourseBtn.Click += rmvCourseBtn_Click;
            // 
            // CoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 520);
            Controls.Add(rmvCourseBtn);
            Controls.Add(addCourseBtn);
            Controls.Add(listCoursesBtn);
            Controls.Add(label1);
            Controls.Add(uniLabel);
            Controls.Add(dataGridView1);
            Name = "CoursesForm";
            Text = "CoursesForm";
            Load += CourserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label uniLabel;
        private Label label1;
        private Button listCoursesBtn;
        private Button addCourseBtn;
        private Button rmvCourseBtn;
    }
}
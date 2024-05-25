namespace DBLearn
{
    partial class TeachersForm
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
            departmentLabel = new Label();
            teachersLabel = new Label();
            listTeachersBtn = new Button();
            addTeacherBtn = new Button();
            rmvTeacherBtn = new Button();
            searchTeacherBtn = new Button();
            searchTeacherBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1022, 274);
            dataGridView1.TabIndex = 0;
            // 
            // uniLabel
            // 
            uniLabel.AutoSize = true;
            uniLabel.Font = new Font("Segoe UI", 18F);
            uniLabel.Location = new Point(244, 27);
            uniLabel.Name = "uniLabel";
            uniLabel.Size = new Size(59, 41);
            uniLabel.TabIndex = 1;
            uniLabel.Text = "uni";
            uniLabel.Click += uniLabel_Click;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new Font("Segoe UI", 18F);
            departmentLabel.Location = new Point(230, 88);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(73, 41);
            departmentLabel.TabIndex = 2;
            departmentLabel.Text = "Dep";
            // 
            // teachersLabel
            // 
            teachersLabel.AutoSize = true;
            teachersLabel.Font = new Font("Segoe UI", 14F);
            teachersLabel.Location = new Point(34, 175);
            teachersLabel.Name = "teachersLabel";
            teachersLabel.Size = new Size(106, 32);
            teachersLabel.TabIndex = 3;
            teachersLabel.Text = "Teachers";
            // 
            // listTeachersBtn
            // 
            listTeachersBtn.Location = new Point(1104, 251);
            listTeachersBtn.Name = "listTeachersBtn";
            listTeachersBtn.Size = new Size(130, 48);
            listTeachersBtn.TabIndex = 4;
            listTeachersBtn.Text = "List Teachers";
            listTeachersBtn.UseVisualStyleBackColor = true;
            listTeachersBtn.Click += listTeachersBtn_Click;
            // 
            // addTeacherBtn
            // 
            addTeacherBtn.Location = new Point(1104, 321);
            addTeacherBtn.Name = "addTeacherBtn";
            addTeacherBtn.Size = new Size(130, 48);
            addTeacherBtn.TabIndex = 5;
            addTeacherBtn.Text = "Add Teacher";
            addTeacherBtn.UseVisualStyleBackColor = true;
            addTeacherBtn.Click += addTeacherBtn_Click;
            // 
            // rmvTeacherBtn
            // 
            rmvTeacherBtn.Location = new Point(1104, 391);
            rmvTeacherBtn.Name = "rmvTeacherBtn";
            rmvTeacherBtn.Size = new Size(130, 48);
            rmvTeacherBtn.TabIndex = 6;
            rmvTeacherBtn.Text = "Remove Teacher";
            rmvTeacherBtn.UseVisualStyleBackColor = true;
            rmvTeacherBtn.Click += rmvTeacherBtn_Click;
            // 
            // searchTeacherBtn
            // 
            searchTeacherBtn.Location = new Point(244, 170);
            searchTeacherBtn.Name = "searchTeacherBtn";
            searchTeacherBtn.Size = new Size(130, 48);
            searchTeacherBtn.TabIndex = 7;
            searchTeacherBtn.Text = "Search Teacher";
            searchTeacherBtn.UseVisualStyleBackColor = true;
            searchTeacherBtn.Click += searchTeacherBtn_Click;
            // 
            // searchTeacherBox
            // 
            searchTeacherBox.Location = new Point(380, 181);
            searchTeacherBox.Name = "searchTeacherBox";
            searchTeacherBox.Size = new Size(342, 27);
            searchTeacherBox.TabIndex = 8;
            // 
            // TeachersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 529);
            Controls.Add(searchTeacherBox);
            Controls.Add(searchTeacherBtn);
            Controls.Add(rmvTeacherBtn);
            Controls.Add(addTeacherBtn);
            Controls.Add(listTeachersBtn);
            Controls.Add(teachersLabel);
            Controls.Add(departmentLabel);
            Controls.Add(uniLabel);
            Controls.Add(dataGridView1);
            Name = "TeachersForm";
            Text = "Teachers";
            Load += Teachers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label uniLabel;
        private Label departmentLabel;
        private Label teachersLabel;
        private Button listTeachersBtn;
        private Button addTeacherBtn;
        private Button rmvTeacherBtn;
        private Button searchTeacherBtn;
        private TextBox searchTeacherBox;
    }
}
namespace DBLearn
{
    partial class DepartmentsForm
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
            deptGridView = new DataGridView();
            deptUniLabel = new Label();
            deptLabel = new Label();
            listDeptsBtn = new Button();
            addDeptBtn = new Button();
            removeDeptBtn = new Button();
            searchBtn = new Button();
            goToCourseBtn = new Button();
            searchBox = new TextBox();
            teachersBtn = new Button();
            calcDeptCredsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)deptGridView).BeginInit();
            SuspendLayout();
            // 
            // deptGridView
            // 
            deptGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            deptGridView.Location = new Point(356, 279);
            deptGridView.Name = "deptGridView";
            deptGridView.RowHeadersWidth = 51;
            deptGridView.Size = new Size(841, 244);
            deptGridView.TabIndex = 0;
            deptGridView.SelectionChanged += deptGridView_selectionChanged;
            // 
            // deptUniLabel
            // 
            deptUniLabel.AutoSize = true;
            deptUniLabel.Font = new Font("Segoe UI", 18F);
            deptUniLabel.Location = new Point(389, 27);
            deptUniLabel.Name = "deptUniLabel";
            deptUniLabel.Size = new Size(64, 41);
            deptUniLabel.TabIndex = 1;
            deptUniLabel.Text = "Def";
            deptUniLabel.Click += deptUniLabel_Click;
            // 
            // deptLabel
            // 
            deptLabel.AutoSize = true;
            deptLabel.Font = new Font("Segoe UI", 18F);
            deptLabel.Location = new Point(492, 87);
            deptLabel.Name = "deptLabel";
            deptLabel.Size = new Size(190, 41);
            deptLabel.TabIndex = 2;
            deptLabel.Text = "Departments";
            // 
            // listDeptsBtn
            // 
            listDeptsBtn.Location = new Point(1005, 187);
            listDeptsBtn.Name = "listDeptsBtn";
            listDeptsBtn.Size = new Size(192, 79);
            listDeptsBtn.TabIndex = 3;
            listDeptsBtn.Text = "List Departments";
            listDeptsBtn.UseVisualStyleBackColor = true;
            listDeptsBtn.Click += listDeptsBtn_Click;
            // 
            // addDeptBtn
            // 
            addDeptBtn.Location = new Point(29, 244);
            addDeptBtn.Name = "addDeptBtn";
            addDeptBtn.Size = new Size(207, 80);
            addDeptBtn.TabIndex = 4;
            addDeptBtn.Text = "Add Department";
            addDeptBtn.UseVisualStyleBackColor = true;
            addDeptBtn.Click += addDeptBtn_Click;
            // 
            // removeDeptBtn
            // 
            removeDeptBtn.Location = new Point(29, 355);
            removeDeptBtn.Name = "removeDeptBtn";
            removeDeptBtn.Size = new Size(207, 74);
            removeDeptBtn.TabIndex = 8;
            removeDeptBtn.Text = "Remove Department";
            removeDeptBtn.UseVisualStyleBackColor = true;
            removeDeptBtn.Click += removeDeptBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(773, 212);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(208, 54);
            searchBtn.TabIndex = 9;
            searchBtn.Text = "Search Department";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // goToCourseBtn
            // 
            goToCourseBtn.Location = new Point(29, 143);
            goToCourseBtn.Name = "goToCourseBtn";
            goToCourseBtn.Size = new Size(207, 74);
            goToCourseBtn.TabIndex = 6;
            goToCourseBtn.Text = "Department's Courses";
            goToCourseBtn.UseVisualStyleBackColor = true;
            goToCourseBtn.Click += goToCourseBtn_Click;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(369, 226);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(364, 27);
            searchBox.TabIndex = 10;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // teachersBtn
            // 
            teachersBtn.Location = new Point(29, 449);
            teachersBtn.Name = "teachersBtn";
            teachersBtn.Size = new Size(207, 74);
            teachersBtn.TabIndex = 11;
            teachersBtn.Text = "Teachers (Select a Department)";
            teachersBtn.UseVisualStyleBackColor = true;
            teachersBtn.Click += teachersBtn_Click;
            // 
            // calcDeptCredsBtn
            // 
            calcDeptCredsBtn.Location = new Point(1005, 124);
            calcDeptCredsBtn.Name = "calcDeptCredsBtn";
            calcDeptCredsBtn.Size = new Size(192, 57);
            calcDeptCredsBtn.TabIndex = 12;
            calcDeptCredsBtn.Text = "Calculate Department Credits";
            calcDeptCredsBtn.UseVisualStyleBackColor = true;
            calcDeptCredsBtn.Click += calcDeptCredsBtn_Click;
            // 
            // DepartmentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 535);
            Controls.Add(calcDeptCredsBtn);
            Controls.Add(teachersBtn);
            Controls.Add(searchBox);
            Controls.Add(searchBtn);
            Controls.Add(removeDeptBtn);
            Controls.Add(goToCourseBtn);
            Controls.Add(addDeptBtn);
            Controls.Add(listDeptsBtn);
            Controls.Add(deptLabel);
            Controls.Add(deptUniLabel);
            Controls.Add(deptGridView);
            Name = "DepartmentsForm";
            Text = "DepartmentsForm";
            Load += DepartmentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)deptGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView deptGridView;
        private Label deptUniLabel;
        private Label deptLabel;
        private Button listDeptsBtn;
        private Button addDeptBtn;
        private Button removeDeptBtn;
        private Button searchBtn;
        private Button goToCourseBtn;
        private TextBox searchBox;
        private Button teachersBtn;
        private Button calcDeptCredsBtn;
    }
}
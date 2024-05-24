namespace DBLearn
{
    partial class InitialForm
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
            label1 = new Label();
            university_btn = new Button();
            universityDataGrid = new DataGridView();
            goToUniversity = new Button();
            addUniversityBtn = new Button();
            removeUniversityBtn = new Button();
            universityNameTextBox = new TextBox();
            universityAddrTextBox = new TextBox();
            uniNameLabel = new Label();
            uniAddrLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)universityDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(235, 32);
            label1.Name = "label1";
            label1.Size = new Size(337, 41);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO DBLEARN";
            label1.Click += label1_Click;
            // 
            // university_btn
            // 
            university_btn.Location = new Point(23, 107);
            university_btn.Name = "university_btn";
            university_btn.Size = new Size(149, 59);
            university_btn.TabIndex = 1;
            university_btn.Text = "List Universities";
            university_btn.UseVisualStyleBackColor = true;
            university_btn.Click += university_btn_Click;
            // 
            // universityDataGrid
            // 
            universityDataGrid.AllowUserToAddRows = false;
            universityDataGrid.AllowUserToDeleteRows = false;
            universityDataGrid.AllowUserToOrderColumns = true;
            universityDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            universityDataGrid.Location = new Point(23, 179);
            universityDataGrid.Name = "universityDataGrid";
            universityDataGrid.ReadOnly = true;
            universityDataGrid.RowHeadersWidth = 51;
            universityDataGrid.Size = new Size(441, 188);
            universityDataGrid.TabIndex = 2;
            universityDataGrid.CellContentClick += UniversityDataGrid_CellContentClick;
            // 
            // goToUniversity
            // 
            goToUniversity.Location = new Point(587, 362);
            goToUniversity.Name = "goToUniversity";
            goToUniversity.Size = new Size(149, 59);
            goToUniversity.TabIndex = 3;
            goToUniversity.Text = "Go To University";
            goToUniversity.UseVisualStyleBackColor = true;
            goToUniversity.Click += goToUniversity_Click;
            // 
            // addUniversityBtn
            // 
            addUniversityBtn.Location = new Point(587, 107);
            addUniversityBtn.Name = "addUniversityBtn";
            addUniversityBtn.Size = new Size(149, 59);
            addUniversityBtn.TabIndex = 4;
            addUniversityBtn.Text = "Add University";
            addUniversityBtn.UseVisualStyleBackColor = true;
            addUniversityBtn.Click += addUniversityBtn_Click;
            // 
            // removeUniversityBtn
            // 
            removeUniversityBtn.Location = new Point(587, 269);
            removeUniversityBtn.Name = "removeUniversityBtn";
            removeUniversityBtn.Size = new Size(149, 59);
            removeUniversityBtn.TabIndex = 5;
            removeUniversityBtn.Text = "Remove University";
            removeUniversityBtn.UseVisualStyleBackColor = true;
            removeUniversityBtn.Click += removeUniversityBtn_Click;
            // 
            // universityNameTextBox
            // 
            universityNameTextBox.Location = new Point(611, 176);
            universityNameTextBox.Name = "universityNameTextBox";
            universityNameTextBox.Size = new Size(125, 27);
            universityNameTextBox.TabIndex = 6;
            // 
            // universityAddrTextBox
            // 
            universityAddrTextBox.Location = new Point(611, 209);
            universityAddrTextBox.Name = "universityAddrTextBox";
            universityAddrTextBox.Size = new Size(125, 27);
            universityAddrTextBox.TabIndex = 7;
            // 
            // uniNameLabel
            // 
            uniNameLabel.AutoSize = true;
            uniNameLabel.Location = new Point(488, 179);
            uniNameLabel.Name = "uniNameLabel";
            uniNameLabel.Size = new Size(117, 20);
            uniNameLabel.TabIndex = 8;
            uniNameLabel.Text = "University Name";
            // 
            // uniAddrLabel
            // 
            uniAddrLabel.AutoSize = true;
            uniAddrLabel.Location = new Point(475, 212);
            uniAddrLabel.Name = "uniAddrLabel";
            uniAddrLabel.Size = new Size(130, 20);
            uniAddrLabel.TabIndex = 9;
            uniAddrLabel.Text = "University Address";
            // 
            // InitialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(uniAddrLabel);
            Controls.Add(uniNameLabel);
            Controls.Add(universityAddrTextBox);
            Controls.Add(universityNameTextBox);
            Controls.Add(removeUniversityBtn);
            Controls.Add(addUniversityBtn);
            Controls.Add(goToUniversity);
            Controls.Add(universityDataGrid);
            Controls.Add(university_btn);
            Controls.Add(label1);
            Name = "InitialForm";
            Text = "Initial Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)universityDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button university_btn;
        private DataGridView universityDataGrid;
        private Button goToUniversity;
        private Button addUniversityBtn;
        private Button removeUniversityBtn;
        private TextBox universityNameTextBox;
        private TextBox universityAddrTextBox;
        private Label uniNameLabel;
        private Label uniAddrLabel;
    }
}

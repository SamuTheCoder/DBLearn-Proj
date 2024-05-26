namespace DBLearn
{
    partial class StudentsForm
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
            Button filterGenderBtn;
            studsGridView = new DataGridView();
            uniLabel = new Label();
            studsLabel = new Label();
            listStudsBtn = new Button();
            filterNameBtn = new Button();
            rmvStudBtn = new Button();
            addStudBtn = new Button();
            filterNameBox = new TextBox();
            filterDegreeBox = new TextBox();
            filterDegreeBtn = new Button();
            filterGenderBox = new TextBox();
            updateStudBtn = new Button();
            addrBox = new TextBox();
            filterGenderBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)studsGridView).BeginInit();
            SuspendLayout();
            // 
            // filterGenderBtn
            // 
            filterGenderBtn.Location = new Point(203, 412);
            filterGenderBtn.Name = "filterGenderBtn";
            filterGenderBtn.Size = new Size(109, 49);
            filterGenderBtn.TabIndex = 10;
            filterGenderBtn.Text = "Filter by Gender";
            filterGenderBtn.UseVisualStyleBackColor = true;
            filterGenderBtn.Click += filterGenderBtn_Click;
            // 
            // studsGridView
            // 
            studsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studsGridView.Location = new Point(318, 221);
            studsGridView.Name = "studsGridView";
            studsGridView.RowHeadersWidth = 51;
            studsGridView.Size = new Size(1076, 260);
            studsGridView.TabIndex = 0;
            // 
            // uniLabel
            // 
            uniLabel.AutoSize = true;
            uniLabel.Font = new Font("Segoe UI", 18F);
            uniLabel.Location = new Point(584, 29);
            uniLabel.Name = "uniLabel";
            uniLabel.Size = new Size(63, 41);
            uniLabel.TabIndex = 1;
            uniLabel.Text = "Uni";
            // 
            // studsLabel
            // 
            studsLabel.AutoSize = true;
            studsLabel.Font = new Font("Segoe UI", 18F);
            studsLabel.Location = new Point(550, 92);
            studsLabel.Name = "studsLabel";
            studsLabel.Size = new Size(134, 41);
            studsLabel.TabIndex = 2;
            studsLabel.Text = "Students";
            // 
            // listStudsBtn
            // 
            listStudsBtn.Location = new Point(1199, 153);
            listStudsBtn.Name = "listStudsBtn";
            listStudsBtn.Size = new Size(152, 52);
            listStudsBtn.TabIndex = 3;
            listStudsBtn.Text = "List Students";
            listStudsBtn.UseVisualStyleBackColor = true;
            listStudsBtn.Click += listStudsBtn_Click;
            // 
            // filterNameBtn
            // 
            filterNameBtn.Location = new Point(203, 279);
            filterNameBtn.Name = "filterNameBtn";
            filterNameBtn.Size = new Size(109, 49);
            filterNameBtn.TabIndex = 4;
            filterNameBtn.Text = "Filter By Name";
            filterNameBtn.UseVisualStyleBackColor = true;
            filterNameBtn.Click += filterNameBtn_Click;
            // 
            // rmvStudBtn
            // 
            rmvStudBtn.Location = new Point(1028, 153);
            rmvStudBtn.Name = "rmvStudBtn";
            rmvStudBtn.Size = new Size(152, 52);
            rmvStudBtn.TabIndex = 5;
            rmvStudBtn.Text = "Remove Student";
            rmvStudBtn.UseVisualStyleBackColor = true;
            rmvStudBtn.Click += rmvStudBtn_Click;
            // 
            // addStudBtn
            // 
            addStudBtn.Location = new Point(847, 153);
            addStudBtn.Name = "addStudBtn";
            addStudBtn.Size = new Size(152, 52);
            addStudBtn.TabIndex = 6;
            addStudBtn.Text = "Add Student";
            addStudBtn.UseVisualStyleBackColor = true;
            addStudBtn.Click += addStudBtn_Click;
            // 
            // filterNameBox
            // 
            filterNameBox.Location = new Point(12, 290);
            filterNameBox.Name = "filterNameBox";
            filterNameBox.Size = new Size(185, 27);
            filterNameBox.TabIndex = 7;
            // 
            // filterDegreeBox
            // 
            filterDegreeBox.Location = new Point(12, 358);
            filterDegreeBox.Name = "filterDegreeBox";
            filterDegreeBox.Size = new Size(185, 27);
            filterDegreeBox.TabIndex = 9;
            // 
            // filterDegreeBtn
            // 
            filterDegreeBtn.Location = new Point(203, 347);
            filterDegreeBtn.Name = "filterDegreeBtn";
            filterDegreeBtn.Size = new Size(109, 49);
            filterDegreeBtn.TabIndex = 8;
            filterDegreeBtn.Text = "Filter by Degree";
            filterDegreeBtn.UseVisualStyleBackColor = true;
            filterDegreeBtn.Click += filterDegreeBtn_Click;
            // 
            // filterGenderBox
            // 
            filterGenderBox.Location = new Point(12, 423);
            filterGenderBox.Name = "filterGenderBox";
            filterGenderBox.Size = new Size(185, 27);
            filterGenderBox.TabIndex = 11;
            // 
            // updateStudBtn
            // 
            updateStudBtn.Location = new Point(318, 153);
            updateStudBtn.Name = "updateStudBtn";
            updateStudBtn.Size = new Size(152, 52);
            updateStudBtn.TabIndex = 12;
            updateStudBtn.Text = "Update Student's Address";
            updateStudBtn.UseVisualStyleBackColor = true;
            updateStudBtn.Click += updateStudBtn_Click;
            // 
            // addrBox
            // 
            addrBox.Location = new Point(476, 166);
            addrBox.Name = "addrBox";
            addrBox.Size = new Size(298, 27);
            addrBox.TabIndex = 13;
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 493);
            Controls.Add(addrBox);
            Controls.Add(updateStudBtn);
            Controls.Add(filterGenderBox);
            Controls.Add(filterGenderBtn);
            Controls.Add(filterDegreeBox);
            Controls.Add(filterDegreeBtn);
            Controls.Add(filterNameBox);
            Controls.Add(addStudBtn);
            Controls.Add(rmvStudBtn);
            Controls.Add(filterNameBtn);
            Controls.Add(listStudsBtn);
            Controls.Add(studsLabel);
            Controls.Add(uniLabel);
            Controls.Add(studsGridView);
            Name = "StudentsForm";
            Text = "StudentsForm";
            Load += StudentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)studsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView studsGridView;
        private Label uniLabel;
        private Label studsLabel;
        private Button listStudsBtn;
        private Button filterNameBtn;
        private Button rmvStudBtn;
        private Button addStudBtn;
        private TextBox filterNameBox;
        private TextBox filterDegreeBox;
        private Button filterDegreeBtn;
        private TextBox filterGenderBox;
        private Button filterGenderBtn;
        private Button updateStudBtn;
        private TextBox addrBox;
    }
}
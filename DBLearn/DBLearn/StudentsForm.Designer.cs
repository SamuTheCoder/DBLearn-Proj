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
            studsGridView = new DataGridView();
            uniLabel = new Label();
            studsLabel = new Label();
            listStudsBtn = new Button();
            searchStudBtn = new Button();
            rmvStudBtn = new Button();
            addStudBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)studsGridView).BeginInit();
            SuspendLayout();
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
            // searchStudBtn
            // 
            searchStudBtn.Location = new Point(37, 388);
            searchStudBtn.Name = "searchStudBtn";
            searchStudBtn.Size = new Size(152, 52);
            searchStudBtn.TabIndex = 4;
            searchStudBtn.Text = "Search Student";
            searchStudBtn.UseVisualStyleBackColor = true;
            // 
            // rmvStudBtn
            // 
            rmvStudBtn.Location = new Point(37, 318);
            rmvStudBtn.Name = "rmvStudBtn";
            rmvStudBtn.Size = new Size(152, 52);
            rmvStudBtn.TabIndex = 5;
            rmvStudBtn.Text = "Remove Student";
            rmvStudBtn.UseVisualStyleBackColor = true;
            // 
            // addStudBtn
            // 
            addStudBtn.Location = new Point(37, 245);
            addStudBtn.Name = "addStudBtn";
            addStudBtn.Size = new Size(152, 52);
            addStudBtn.TabIndex = 6;
            addStudBtn.Text = "Add Student";
            addStudBtn.UseVisualStyleBackColor = true;
            addStudBtn.Click += addStudBtn_Click;
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 493);
            Controls.Add(addStudBtn);
            Controls.Add(rmvStudBtn);
            Controls.Add(searchStudBtn);
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
        private Button searchStudBtn;
        private Button rmvStudBtn;
        private Button addStudBtn;
    }
}
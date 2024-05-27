namespace DBLearn
{
    partial class DegreesForm
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
            degreeGridView = new DataGridView();
            uniLabel = new Label();
            label1 = new Label();
            listDegreeBtn = new Button();
            addDegreeBtn = new Button();
            rmvDegreeBtn = new Button();
            menuStrip1 = new MenuStrip();
            degreeCourseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)degreeGridView).BeginInit();
            SuspendLayout();
            // 
            // degreeGridView
            // 
            degreeGridView.AllowUserToOrderColumns = true;
            degreeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            degreeGridView.Location = new Point(294, 221);
            degreeGridView.Name = "degreeGridView";
            degreeGridView.RowHeadersWidth = 51;
            degreeGridView.Size = new Size(899, 274);
            degreeGridView.TabIndex = 0;
            // 
            // uniLabel
            // 
            uniLabel.AutoSize = true;
            uniLabel.Font = new Font("Segoe UI", 18F);
            uniLabel.Location = new Point(516, 40);
            uniLabel.Name = "uniLabel";
            uniLabel.Size = new Size(63, 41);
            uniLabel.TabIndex = 1;
            uniLabel.Text = "Uni";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(473, 93);
            label1.Name = "label1";
            label1.Size = new Size(128, 41);
            label1.TabIndex = 2;
            label1.Text = "Degrees";
            // 
            // listDegreeBtn
            // 
            listDegreeBtn.Location = new Point(992, 163);
            listDegreeBtn.Name = "listDegreeBtn";
            listDegreeBtn.Size = new Size(169, 52);
            listDegreeBtn.TabIndex = 3;
            listDegreeBtn.Text = "List Degrees";
            listDegreeBtn.UseVisualStyleBackColor = true;
            listDegreeBtn.Click += listDegreeBtn_Click;
            // 
            // addDegreeBtn
            // 
            addDegreeBtn.Location = new Point(30, 235);
            addDegreeBtn.Name = "addDegreeBtn";
            addDegreeBtn.Size = new Size(169, 52);
            addDegreeBtn.TabIndex = 4;
            addDegreeBtn.Text = "Add Degree";
            addDegreeBtn.UseVisualStyleBackColor = true;
            addDegreeBtn.Click += addDegreeBtn_Click;
            // 
            // rmvDegreeBtn
            // 
            rmvDegreeBtn.Location = new Point(30, 326);
            rmvDegreeBtn.Name = "rmvDegreeBtn";
            rmvDegreeBtn.Size = new Size(169, 52);
            rmvDegreeBtn.TabIndex = 5;
            rmvDegreeBtn.Text = "Remove Degree";
            rmvDegreeBtn.UseVisualStyleBackColor = true;
            rmvDegreeBtn.Click += rmvDegreeBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1222, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // degreeCourseBtn
            // 
            degreeCourseBtn.Location = new Point(294, 163);
            degreeCourseBtn.Name = "degreeCourseBtn";
            degreeCourseBtn.Size = new Size(169, 52);
            degreeCourseBtn.TabIndex = 9;
            degreeCourseBtn.Text = "List Degree's Courses";
            degreeCourseBtn.UseVisualStyleBackColor = true;
            degreeCourseBtn.Click += degreeCourseBtn_Click;
            // 
            // DegreesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 527);
            Controls.Add(degreeCourseBtn);
            Controls.Add(rmvDegreeBtn);
            Controls.Add(addDegreeBtn);
            Controls.Add(listDegreeBtn);
            Controls.Add(label1);
            Controls.Add(uniLabel);
            Controls.Add(degreeGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DegreesForm";
            Text = "DegreesForm";
            Load += DegreesForm_Load;
            ((System.ComponentModel.ISupportInitialize)degreeGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView degreeGridView;
        private Label uniLabel;
        private Label label1;
        private Button listDegreeBtn;
        private Button addDegreeBtn;
        private Button rmvDegreeBtn;
        private MenuStrip menuStrip1;
        private Button degreeCourseBtn;
    }
}
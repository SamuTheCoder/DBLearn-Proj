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
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)deptGridView).BeginInit();
            SuspendLayout();
            // 
            // deptGridView
            // 
            deptGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            deptGridView.Location = new Point(221, 233);
            deptGridView.Name = "deptGridView";
            deptGridView.RowHeadersWidth = 51;
            deptGridView.Size = new Size(567, 188);
            deptGridView.TabIndex = 0;
            deptGridView.CellContentClick += deptGridView_CellContentClick;
            // 
            // deptUniLabel
            // 
            deptUniLabel.AutoSize = true;
            deptUniLabel.Font = new Font("Segoe UI", 18F);
            deptUniLabel.Location = new Point(278, 35);
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
            deptLabel.Location = new Point(298, 76);
            deptLabel.Name = "deptLabel";
            deptLabel.Size = new Size(190, 41);
            deptLabel.TabIndex = 2;
            deptLabel.Text = "Departments";
            // 
            // listDeptsBtn
            // 
            listDeptsBtn.Location = new Point(644, 145);
            listDeptsBtn.Name = "listDeptsBtn";
            listDeptsBtn.Size = new Size(133, 59);
            listDeptsBtn.TabIndex = 3;
            listDeptsBtn.Text = "List Departments";
            listDeptsBtn.UseVisualStyleBackColor = true;
            listDeptsBtn.Click += listDeptsBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 145);
            button1.Name = "button1";
            button1.Size = new Size(133, 59);
            button1.TabIndex = 4;
            button1.Text = "Add Department";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(328, 145);
            button3.Name = "button3";
            button3.Size = new Size(133, 59);
            button3.TabIndex = 6;
            button3.Text = "Update Department";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(489, 145);
            button4.Name = "button4";
            button4.Size = new Size(133, 59);
            button4.TabIndex = 7;
            button4.Text = "Add Department";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(172, 145);
            button5.Name = "button5";
            button5.Size = new Size(133, 59);
            button5.TabIndex = 8;
            button5.Text = "Remove Department";
            button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 233);
            button2.Name = "button2";
            button2.Size = new Size(133, 59);
            button2.TabIndex = 9;
            button2.Text = "Search Department";
            button2.UseVisualStyleBackColor = true;
            // 
            // DepartmentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
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
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button2;
    }
}
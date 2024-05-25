namespace DBLearn
{
    partial class addDepartment
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
            addrBox = new TextBox();
            label2 = new Label();
            nameBox = new TextBox();
            label3 = new Label();
            emailBox = new TextBox();
            label4 = new Label();
            submitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 50);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Department ID";
            label1.Click += label1_Click;
            // 
            // idBox
            // 
            idBox.Location = new Point(206, 50);
            idBox.Name = "idBox";
            idBox.Size = new Size(208, 27);
            idBox.TabIndex = 1;
            idBox.TextChanged += idBox_TextChanged;
            // 
            // addrBox
            // 
            addrBox.Location = new Point(206, 152);
            addrBox.Name = "addrBox";
            addrBox.Size = new Size(208, 27);
            addrBox.TabIndex = 3;
            addrBox.TextChanged += addrBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 155);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 2;
            label2.Text = "Department Address:";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(206, 102);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(208, 27);
            nameBox.TabIndex = 5;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 105);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 4;
            label3.Text = "Department Name:";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(206, 200);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(208, 27);
            emailBox.TabIndex = 7;
            emailBox.TextChanged += emailBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 203);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 6;
            label4.Text = "Department Email:";
            // 
            // submitBtn
            // 
            submitBtn.Font = new Font("Segoe UI", 18F);
            submitBtn.Location = new Point(101, 264);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(272, 74);
            submitBtn.TabIndex = 9;
            submitBtn.Text = "SUBMIT";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // addDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 400);
            Controls.Add(submitBtn);
            Controls.Add(emailBox);
            Controls.Add(label4);
            Controls.Add(nameBox);
            Controls.Add(label3);
            Controls.Add(addrBox);
            Controls.Add(label2);
            Controls.Add(idBox);
            Controls.Add(label1);
            Name = "addDepartment";
            Text = "addDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox idBox;
        private TextBox addrBox;
        private Label label2;
        private TextBox nameBox;
        private Label label3;
        private TextBox emailBox;
        private Label label4;
        private Button submitBtn;
    }
}
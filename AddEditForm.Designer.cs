namespace Демо_Экзамен_Тимур_Жуков
{
    partial class AddEditForm
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
            txtName = new TextBox();
            label2 = new Label();
            cmbType = new ComboBox();
            label3 = new Label();
            nudRating = new NumericUpDown();
            label4 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtDirector = new TextBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 18);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // txtName
            // 
            txtName.Location = new Point(51, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 18);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "Тип:";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(202, 47);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 23);
            cmbType.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 18);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Рейтинг:";
            // 
            // nudRating
            // 
            nudRating.Location = new Point(385, 48);
            nudRating.Name = "nudRating";
            nudRating.Size = new Size(120, 23);
            nudRating.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(588, 18);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Адрес:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(558, 48);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 93);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 8;
            label5.Text = "Директор:";
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(52, 123);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(100, 23);
            txtDirector.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 93);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 10;
            label6.Text = "Телефон:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(193, 123);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(356, 93);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 12;
            label7.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(336, 123);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(200, 210);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 45);
            btnSave.TabIndex = 14;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(346, 210);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 45);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(txtDirector);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(nudRating);
            Controls.Add(label3);
            Controls.Add(cmbType);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "AddEditForm";
            Text = "AddEditForm";
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private ComboBox cmbType;
        private Label label3;
        private NumericUpDown nudRating;
        private Label label4;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtDirector;
        private Label label6;
        private TextBox txtPhone;
        private Label label7;
        private TextBox txtEmail;
        private Button btnSave;
        private Button btnCancel;
    }
}
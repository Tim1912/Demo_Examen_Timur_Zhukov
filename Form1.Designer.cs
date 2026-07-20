namespace Демо_Экзамен_Тимур_Жуков
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnHistory = new Button();
            btnCalc = new Button();
            btnDiscount = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(700, 250);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(50, 320);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(190, 320);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 40);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(330, 320);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(120, 40);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "История";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(472, 320);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(97, 40);
            btnCalc.TabIndex = 4;
            btnCalc.Text = "Тест расчета материала";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(594, 320);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(94, 40);
            btnDiscount.TabIndex = 5;
            btnDiscount.Text = "Рассчитать скидку";
            btnDiscount.UseVisualStyleBackColor = true;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(btnDiscount);
            Controls.Add(btnCalc);
            Controls.Add(btnHistory);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Список партнеров";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnHistory;
        private Button btnCalc;
        private Button btnDiscount;
    }
}
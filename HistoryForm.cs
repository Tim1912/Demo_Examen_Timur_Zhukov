using System;
using System.Windows.Forms;

namespace Демо_Экзамен_Тимур_Жуков
{
    public partial class HistoryForm : Form
    {
        public HistoryForm(int partnerId, string name)
        {
            InitializeComponent();
            this.Text = "История: " + name;

            try
            {
                string sql = "SELECT pr.name AS 'Продукция', s.quantity AS 'Количество', " +
                    "s.sale_date AS 'Дата' FROM sales s " +
                    "JOIN products pr ON s.product_id = pr.id " +
                    "WHERE s.partner_id = " + partnerId;

                dataGridView1.DataSource = DbHelper.GetData(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using System;
using System.Data;
using System.Windows.Forms;

namespace Демо_Экзамен_Тимур_Жуков
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Список партнеров";
            LoadData();
        }

        void LoadData()
        {
            try
            {
                string sql = "SELECT p.id, p.name AS 'Название', pt.type_name AS 'Тип', " +
                    "p.rating AS 'Рейтинг', p.address AS 'Адрес' " +
                    "FROM partners p JOIN partner_types pt ON p.type_id = pt.id";

                dataGridView1.DataSource = DbHelper.GetData(sql);

                if (dataGridView1.Columns.Contains("id"))
                    dataGridView1.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditForm f = new AddEditForm(-1);
            if (f.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите партнера!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            AddEditForm f = new AddEditForm(id);
            if (f.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите партнера!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            string name = dataGridView1.CurrentRow.Cells["Название"].Value.ToString();
            new HistoryForm(id, name).Show();
        }
        //МЕТОД РАСЧЕТА МАТЕРИАЛА
        public int CalculateMaterial(int productTypeId, int materialTypeId, int quantity, double param1, double param2)
        {
            try
            {
                string sql1 = "SELECT coefficient FROM product_types WHERE id = " + productTypeId;
                DataTable dt1 = DbHelper.GetData(sql1);
                if (dt1.Rows.Count == 0) return -1;
                double coeff = Convert.ToDouble(dt1.Rows[0]["coefficient"]);

                string sql2 = "SELECT defect FROM material_types WHERE id = " + materialTypeId;
                DataTable dt2 = DbHelper.GetData(sql2);
                if (dt2.Rows.Count == 0) return -1;
                double defect = Convert.ToDouble(dt2.Rows[0]["defect"]);

                double materialPerUnit = param1 * param2 * coeff;
                double totalMaterial = materialPerUnit * quantity;
                double withDefect = totalMaterial * (1 + defect / 100.0);

                return (int)Math.Ceiling(withDefect);
            }
            catch
            {
                return -1;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int result = CalculateMaterial(1, 1, 10, 10.5, 5.0);

            if (result == -1)
            {
                MessageBox.Show("Ошибка: неверные данные для расчета!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Необходимое количество материала: " + result + " ед.", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Расчет скидки для партнера
        private double CalculateDiscount(int partnerId)
        {
            try
            {
                // 1. Считаем общую сумму продаж партнера
                string sql = "SELECT SUM(s.quantity) as total FROM sales s " +
                             "JOIN products p ON s.product_id = p.id " +
                             "WHERE s.partner_id = " + partnerId;

                DataTable dt = DbHelper.GetData(sql);

                if (dt.Rows.Count == 0 || dt.Rows[0]["total"] == DBNull.Value)
                    return 0; // Если продаж нет — скидка 0%

                double total = Convert.ToDouble(dt.Rows[0]["total"]);

                // 2. Применяем алгоритм скидки
                if (total < 10000) return 0;
                if (total < 50000) return 5;
                if (total < 300000) return 10;
                return 15;
            }
            catch
            {
                return 0;
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите партнера!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            string name = dataGridView1.CurrentRow.Cells["Название"].Value.ToString();

            double discount = CalculateDiscount(id);

            MessageBox.Show($"Партнер: {name}\nСкидка: {discount}%",
                "Расчет скидки", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
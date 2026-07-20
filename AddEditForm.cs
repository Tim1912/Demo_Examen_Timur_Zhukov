using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Демо_Экзамен_Тимур_Жуков
{
    public partial class AddEditForm : Form
    {
        private int partnerId;
        private bool isEdit;

        public AddEditForm(int id)
        {
            InitializeComponent();
            partnerId = id;
            isEdit = (id != -1);

            if (isEdit)
                this.Text = "Редактирование партнера";
            else
                this.Text = "Добавление партнера";

            LoadTypes();

            if (isEdit)
                LoadPartnerData();
        }

        private void LoadTypes()
        {
            try
            {
                string sql = "SELECT id, type_name FROM partner_types";
                DataTable dt = DbHelper.GetData(sql);

                cmbType.DataSource = dt;
                cmbType.DisplayMember = "type_name";
                cmbType.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки типов: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPartnerData()
        {
            try
            {
                string sql = "SELECT * FROM partners WHERE id = " + partnerId;
                DataTable dt = DbHelper.GetData(sql);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtName.Text = row["name"].ToString();
                    cmbType.SelectedValue = row["type_id"];
                    nudRating.Value = Convert.ToInt32(row["rating"]);
                    txtAddress.Text = row["address"].ToString();
                    txtDirector.Text = row["director"].ToString();
                    txtPhone.Text = row["phone"].ToString();
                    txtEmail.Text = row["email"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите название партнера!", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.BackColor = Color.LightCoral;
                return;
            }
            txtName.BackColor = Color.White;

            try
            {
                string sql;

                if (isEdit)
                {
                    sql = "UPDATE partners SET " +
                          "name = @name, " +
                          "type_id = @type, " +
                          "rating = @rating, " +
                          "address = @address, " +
                          "director = @director, " +
                          "phone = @phone, " +
                          "email = @email " +
                          "WHERE id = " + partnerId;
                }
                else
                {
                    sql = "INSERT INTO partners " +
                          "(name, type_id, rating, address, director, phone, email) " +
                          "VALUES " +
                          "(@name, @type, @rating, @address, @director, @phone, @email)";
                }

                using (MySqlConnection conn = new MySqlConnection(DbHelper.conn))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", cmbType.SelectedValue);
                        cmd.Parameters.AddWithValue("@rating", (int)nudRating.Value);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@director", txtDirector.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Данные успешно сохранены!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
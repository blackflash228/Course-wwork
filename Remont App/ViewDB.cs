using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Remont_App
{

    public partial class ViewDB : Form
    {
        #region змінні
        static public string connectionString = ConfigurationManager.AppSettings["connectionString"];
        static SqlConnection connection = new SqlConnection(connectionString);
        #endregion
        public ViewDB()
        {
            InitializeComponent();
        }
        private void Leftback_Click(object sender, EventArgs e)
        {
            Hide();
            StartScreen back = new StartScreen();
            back.ShowDialog();
            Close();
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            this.clientTableAdapter.Fill(this.clientDBDataSet.Client);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientTableAdapter.Update(this.clientDBDataSet.Client);
            MessageBox.Show("Записи в Базі Даних було оновлено");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataRow row = (OutputGridView.CurrentRow.DataBoundItem as DataRowView).Row;
            DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видалити запис?", "Видалення запису", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                row.Delete();
        }

        private void BaseFORM_Load(object sender, EventArgs e)
        {
            this.clientTableAdapter.Fill(this.clientDBDataSet.Client);
            this.OutputGridView.DefaultCellStyle.Font = new Font("SF UI Display", 12);
           searchparam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void Searchbox_TextChanged_1(object sender, EventArgs e)
        {
            switch (searchparam.SelectedIndex)
            {
                case 0:
                    clientBindingSource.Filter = "[Date] LIKE'" + searchbox.Text + "%'";
                    break;
                case 1:
                    clientBindingSource.Filter = "[Name] LIKE'" + searchbox.Text + "%'";
                    break;
                case 2:
                    clientBindingSource.Filter = "[Clientphone] LIKE'" + searchbox.Text + "%'";
                    break;
                case 3:
                    clientBindingSource.Filter = "[Firstname] LIKE'" + searchbox.Text + "%'";
                    break;

            }
        }
    }
}


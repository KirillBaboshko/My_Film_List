using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Film_List
{
    public partial class SignForm : Form
    {
        DataBase dataBase = new DataBase();
        public SignForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            goodTextBoxPassword.MaxLength = 50;
            goodTextBoxLogin.MaxLength = 50;
        }

        private void pictureBoxOpen_Click(object sender, EventArgs e)
        {
            goodTextBoxPassword.PasswordChar = false;
            pictureBoxOpen.Visible = false;
            pictureBoxClose.Visible = true;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            goodTextBoxPassword.PasswordChar = true;
            pictureBoxOpen.Visible = true;
            pictureBoxClose.Visible = false;
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            goodTextBoxPassword.Texts = "";
            goodTextBoxLogin.Texts = "";
        }

        private void SignButt_Click(object sender, EventArgs e)
        {
            if (checkuser())
            {
                var login = goodTextBoxLogin.Texts;
                var password = goodTextBoxPassword.Texts;

                string sqlquery = $"insert into Registration(login_user, password_user) values('{login}', '{password}')";

                SqlCommand command = new SqlCommand(sqlquery, dataBase.GetConnection());

                dataBase.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!", "Успеx!");
                    LogForm logForm = new LogForm();
                    this.Hide();
                    logForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Аккаунт не создан!");
                }
                dataBase.closeConnection();
            }
        }

        private Boolean checkuser()
        {
            var loginUser = goodTextBoxLogin.Texts;
            var passUser = goodTextBoxPassword.Texts;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string sqlquer = $"select id_user, login_user, password_user from Registration where login_user = '{loginUser}' and password_user = '{passUser}'";
            SqlCommand command = new SqlCommand(sqlquer,dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count>0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

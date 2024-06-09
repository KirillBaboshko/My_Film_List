using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace My_Film_List
{
    public partial class LogForm : Form
    {
        DataBase dataBase = new DataBase();
        public LogForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            goodTextBoxPassword.MaxLength = 50;
            goodTextBoxLogin.MaxLength = 50;
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

        private void pictureBoxOpen_Click(object sender, EventArgs e)
        {
            goodTextBoxPassword.PasswordChar = false;
            pictureBoxOpen.Visible = false;
            pictureBoxClose.Visible = true;
        }

        private void LogButt_Click(object sender, EventArgs e)
        {
            var loginUser = goodTextBoxLogin.Texts;
            var passwordUser = goodTextBoxPassword.Texts;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string sqlquery = $"select id_user,login_user,password_user from Registration where login_user = '{loginUser}' and password_user = '{passwordUser}'";

            SqlCommand command = new SqlCommand(sqlquery, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count==1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 fm1 = new Form1();
                this.Hide();
                fm1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль! Убедитесь, что ткой аккаунт существует", "Ошибка входа!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignForm signForm = new SignForm();
            signForm.Show();
            this.Hide();
        }
    }
}

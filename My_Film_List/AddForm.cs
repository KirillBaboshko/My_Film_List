using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Film_List
{
    public partial class AddForm : Form
    {
        DataBase dataBase = new DataBase();
        MainForm mainForm;
        public AddForm(MainForm mainForm)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            this.mainForm = mainForm;
        }

        private void ButtAdd_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var Name = TextBoxName.Texts;
            int MaxCount;
            int MinCount;
            int Duration;
            int Date;
            var Link = TextBoxLink.Texts;

            if(int.TryParse(TextBoxCount1.Texts,out MaxCount) && int.TryParse(TextBoxCount2.Texts, out MinCount) && int.TryParse(TextBoxDuration.Texts, out Duration) && int.TryParse(TextBoxDate.Texts, out Date))
            {
                if (MinCount <= MaxCount && MinCount >= 0 && Duration > 0 && Date >= 1895 && MaxCount >= 0 && Date<=3000)
                {
                    if (Name != null && Name.ToString().Trim() != string.Empty)
                    {
                        var addQuert = $"INSERT INTO Planned (item_name,item_count_of_episodes_max,item_count_of_episodes_now,item_duration,item_realease_date,item_link) values ('{Name}','{MaxCount}','{MinCount}','{Duration}','{Date}','{Link}')";
                        var command = new SQLiteCommand(addQuert, dataBase.GetConnection());
                        command.ExecuteNonQuery();
                        MessageBox.Show("Произведение успешно добавлено в ваш список запланированного!!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainForm.RefreshDataGridPlanned(mainForm.DataGridPlanned);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Поле название не должно быть путсым!!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Допустили ошибку при вводе даты,количества эпизодов или продолжительности!!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Допустили ошибку при вводе данных!!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clean_View_Click(object sender, EventArgs e)
        {
            TextBoxCount1.Texts = "";
            TextBoxCount2.Texts = "";
            TextBoxDate.Texts = "";
            TextBoxDuration.Texts = "";
            TextBoxLink.Texts = "";
            TextBoxName.Texts = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Все поля, кроме поля Ссылка обязательны к заполнению", "Информация при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    }
}

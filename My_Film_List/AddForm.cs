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
                var addQuert = $"INSERT INTO Planned (item_name,item_count_of_episodes_max,item_count_of_episodes_now,item_duration,item_realease_date,item_link) values ('{Name}','{MaxCount}','{MinCount}','{Duration}','{Date}','{Link}')";
                var command = new SQLiteCommand(addQuert,dataBase.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Произведение успешно добавлено в ваш список запланированного!!!","Успех!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                mainForm.RefreshDataGridPlanned(mainForm.DataGridPlanned);
                this.Close();
            }
            else
            {
                MessageBox.Show("Допустили ошибку при вводе данных!!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
            
        }
    }
}

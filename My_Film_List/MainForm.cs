using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.LinkLabel;

namespace My_Film_List
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class MainForm : Form
    {
        int SelectRow;
        DataBase dataBase = new DataBase();
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void CreateColumns()
        {
            DataGridPlanned.Columns.Add("id_item", "Id");
            DataGridPlanned.Columns.Add("item_name", "Название");
            DataGridPlanned.Columns.Add("item_count_of_episodes", "Кол-во эпизодов");
            DataGridPlanned.Columns.Add("item_duration", "Общая продолжительность");
            DataGridPlanned.Columns.Add("item_realease_date", "Год выхода");
            DataGridPlanned.Columns.Add("item_link", "Ссылка");
            DataGridPlanned.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridPlanned.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridPlanned.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridPlanned.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridPlanned.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            DataGridViewed.Columns.Add("id_item", "Id");
            DataGridViewed.Columns.Add("item_name", "Название");
            DataGridViewed.Columns.Add("item_count_of_episodes", "Кол-во эпизодов");
            DataGridViewed.Columns.Add("item_duration", "Общая продолжительность");
            DataGridViewed.Columns.Add("item_realease_date", "Год выхода");
            DataGridViewed.Columns.Add("item_link", "Ссылка");
            DataGridViewed.Columns.Add("item_rating", "Рейтинг");
            DataGridViewed.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewed.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewed.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewed.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewed.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewed.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void ClearFieldsPlanned()
        {
            TextBoxName.Texts = "";
            TextBoxCount1.Texts = "";
            TextBoxCount2.Texts = "";
            TextBoxData.Texts = "";
            TextBoxDuration.Texts = "";
            TextBoxLink.Texts = "";
        }
        private void ClearFieldsViewed()
        {
            TextBoxName_View.Texts = "";
            TextBoxCount1_View.Texts = "";
            TextBoxCount2_View.Texts = "";
            TextBoxData_View.Texts = "";
            TextBoxDuration_View.Texts = "";
            TextBoxLink_View.Texts = "";
            TextBoxRating.Texts = "";
        }
        private void ReadSingleRowPlanned(DataGridView dgw,IDataRecord record)
        {
            dgw.Rows.Add(int.Parse(record.GetValue(0).ToString()), record.GetValue(1).ToString(), $"{int.Parse(record.GetValue(3).ToString())} из {int.Parse(record.GetValue(2).ToString())}", int.Parse(record.GetValue(4).ToString()), int.Parse(record.GetValue(5).ToString()), record.GetValue(6).ToString());
        }
        private void ReadSingleRowViewed(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(int.Parse(record.GetValue(0).ToString()), record.GetValue(1).ToString(), $"{int.Parse(record.GetValue(3).ToString())} из {int.Parse(record.GetValue(2).ToString())}", int.Parse(record.GetValue(4).ToString()), int.Parse(record.GetValue(5).ToString()), record.GetValue(6).ToString(),$"{record.GetValue(7).ToString()} / 10");
        }
        private void AddRowViewed()
        {
            dataBase.openConnection();
            int index = DataGridPlanned.CurrentCell.RowIndex;
            int id= int.Parse(DataGridPlanned.Rows[index].Cells[0].Value.ToString());
            var Name = DataGridPlanned.Rows[index].Cells[1].Value;
            string[] str = DataGridPlanned.Rows[index].Cells[2].Value.ToString().Split();
            int MaxCount= int.Parse(str[2]);
            int MinCount = int.Parse(str[0]);
            int Duration = int.Parse(DataGridPlanned.Rows[index].Cells[3].Value.ToString());
            int Date=int.Parse(DataGridPlanned.Rows[index].Cells[4].Value.ToString());
            var Link = DataGridPlanned.Rows[index].Cells[5].Value;
            var addQuert = $"INSERT INTO Viewed (id_item,item_name,item_count_of_episodes_max,item_count_of_episodes_now,item_duration,item_realease_date,item_link,item_rating) values ('{id}','{Name}','{MaxCount}','{MinCount}','{Duration}','{Date}','{Link}','{0.0}')";
            var command = new SQLiteCommand(addQuert, dataBase.GetConnection());
            command.ExecuteNonQuery();
            dataBase.closeConnection();
            RefreshDataGridViewed(DataGridViewed);
        }
        private void DeleteRowPlanned()
        {
            dataBase.openConnection();
            int index = DataGridPlanned.CurrentCell.RowIndex;
            var id = Convert.ToInt32(DataGridPlanned.Rows[index].Cells[0].Value);
            string deleteQuery = $"DELETE FROM Planned WHERE id_item = {id}";
            var com = new SQLiteCommand(deleteQuery,dataBase.GetConnection());
            com.ExecuteNonQuery();
            dataBase.closeConnection();
            RefreshDataGridPlanned(DataGridPlanned);
        }
        private void DeleteRowViewed()
        {
            dataBase.openConnection();
            int index = DataGridViewed.CurrentCell.RowIndex;
            var id = Convert.ToInt32(DataGridViewed.Rows[index].Cells[0].Value);
            string deleteQuery = $"DELETE FROM Viewed WHERE id_item = {id}";
            var com = new SQLiteCommand(deleteQuery, dataBase.GetConnection());
            com.ExecuteNonQuery();
            dataBase.closeConnection();
            RefreshDataGridViewed(DataGridViewed);
        }
        public void RefreshDataGridViewed(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Viewed";
            SQLiteCommand command = new SQLiteCommand(queryString, dataBase.GetConnection());
            dataBase.openConnection();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRowViewed(dgw, reader);
            }
            reader.Close();
        }
        public void RefreshDataGridPlanned(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Planned";
            SQLiteCommand command = new SQLiteCommand(queryString, dataBase.GetConnection());
            dataBase.openConnection();
            SQLiteDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                ReadSingleRowPlanned(dgw,reader);
            }
            reader.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGridPlanned(DataGridPlanned);
            RefreshDataGridViewed(DataGridViewed);
        }

        private void DataGridPlanned_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != DataGridPlanned.Rows.Count-1)
            {
                SelectRow = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = DataGridPlanned.Rows[SelectRow];
                    TextBoxName.Texts = row.Cells[1].Value.ToString();
                    string[] str = row.Cells[2].Value.ToString().Split();
                    TextBoxCount1.Texts = str[2];
                    TextBoxCount2.Texts = str[0];
                    TextBoxDuration.Texts = row.Cells[3].Value.ToString();
                    TextBoxData.Texts = row.Cells[4].Value.ToString();
                    TextBoxLink.Texts = row.Cells[5].Value.ToString();
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridPlanned(DataGridPlanned);
        }

        private void Butt_Add_Click(object sender, EventArgs e)
        {
            AddForm addfrm = new AddForm(this);
            addfrm.Show();
        }
        private void SearchPlanned(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchStr = $"SELECT * FROM Planned WHERE item_name LIKE '%{textBox1.Text}%' OR item_count_of_episodes_max LIKE '%{textBox1.Text}%' OR item_count_of_episodes_now LIKE '%{textBox1.Text}%' OR item_duration LIKE '%{textBox1.Text}%' OR item_realease_date LIKE '%{textBox1.Text}%' OR item_link LIKE '%{textBox1.Text}%'";
            SQLiteCommand com = new SQLiteCommand(searchStr,dataBase.GetConnection());
            dataBase.openConnection();
            SQLiteDataReader read = com.ExecuteReader();
            while(read.Read())
            {
                ReadSingleRowPlanned(dgw,read);
            }
            read.Close();
        }
        private void SearchViewed(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchStr = $"SELECT * FROM Viewed WHERE item_name LIKE '%{textBox2.Text}%' OR item_count_of_episodes_max LIKE '%{textBox2.Text}%' OR item_count_of_episodes_now LIKE '%{textBox2.Text}%' OR item_duration LIKE '%{textBox2.Text}%' OR item_realease_date LIKE '%{textBox2.Text}%' OR item_link LIKE '%{textBox2.Text}%' OR item_rating LIKE '%{textBox2.Text}%'";
            SQLiteCommand com = new SQLiteCommand(searchStr, dataBase.GetConnection());
            dataBase.openConnection();
            SQLiteDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRowViewed(dgw, read);
            }
            read.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchPlanned(DataGridPlanned);
        }

        private void Butt_Del_Click(object sender, EventArgs e)
        {
            DeleteRowPlanned();
            ClearFieldsPlanned();
        }
        private void EditPlanned()
        {
            int index= DataGridPlanned.CurrentCell.RowIndex;
            dataBase.openConnection();
            var id = DataGridPlanned.Rows[index].Cells[0].Value.ToString();
            var Name = TextBoxName.Texts;
            int MaxCount;
            int MinCount;
            int Duration;
            int Date;
            var Link = TextBoxLink.Texts;

            if (int.TryParse(TextBoxCount1.Texts, out MaxCount) && int.TryParse(TextBoxCount2.Texts, out MinCount) && int.TryParse(TextBoxDuration.Texts, out Duration) && int.TryParse(TextBoxData.Texts, out Date))
            {
                var addQuert = $"UPDATE Planned SET item_name= '{Name}',item_count_of_episodes_max = '{MaxCount}',item_count_of_episodes_now = '{MinCount}',item_duration = '{Duration}',item_realease_date = '{Date}',item_link = '{Link}' WHERE id_item='{id}'";
                var command = new SQLiteCommand(addQuert, dataBase.GetConnection());
                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Допустили ошибку при вводе данных!!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
            RefreshDataGridPlanned(DataGridPlanned);
        }
        private void Butt_Edit_Click(object sender, EventArgs e)
        {
            EditPlanned();
            ClearFieldsPlanned();
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            ClearFieldsPlanned();
        }

        private void Butt_Transfer_Click(object sender, EventArgs e)
        {
            AddRowViewed();
            DeleteRowPlanned();
        }

        private void DataGridViewed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != DataGridViewed.Rows.Count - 1)
            {
                SelectRow = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = DataGridViewed.Rows[SelectRow];
                    TextBoxName_View.Texts = row.Cells[1].Value.ToString();
                    string[] str = row.Cells[2].Value.ToString().Split();
                    TextBoxCount1_View.Texts = str[2];
                    TextBoxCount2_View.Texts = str[0];
                    TextBoxDuration_View.Texts = row.Cells[3].Value.ToString();
                    TextBoxData_View.Texts = row.Cells[4].Value.ToString();
                    TextBoxLink_View.Texts = row.Cells[5].Value.ToString();
                    string[] strrat = row.Cells[6].Value.ToString().Split();
                    TextBoxRating.Texts = strrat[0];
                    TextBoxName_View.textBox1.ReadOnly = true;
                    TextBoxCount1_View.textBox1.ReadOnly = true;
                    TextBoxCount2_View.textBox1.ReadOnly = true;
                    TextBoxDuration_View.textBox1.ReadOnly = true;
                    TextBoxData_View.textBox1.ReadOnly = true;
                    TextBoxLink_View.textBox1.ReadOnly = true;

                }
            }
        }

        private void Butt_Rating_Click(object sender, EventArgs e)
        {
            int index = DataGridViewed.CurrentCell.RowIndex;
            int id= int.Parse(DataGridViewed.Rows[index].Cells[0].Value.ToString());
            dataBase.openConnection();
            float Rating;
            if(float.TryParse(TextBoxRating.Texts.ToString(),out Rating))
            {
                string str = Rating.ToString();
                str = str.Replace(",",".");
                var addQuert = $"UPDATE Viewed SET item_rating= '{str}' WHERE id_item='{id}'";
                var command = new SQLiteCommand(addQuert, dataBase.GetConnection());
                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Допустили ошибку при вводе данных!!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
            RefreshDataGridViewed(DataGridViewed);
            ClearFieldsViewed();
        }

        private void Butt_Del_View_Click(object sender, EventArgs e)
        {
            DeleteRowViewed();
            ClearFieldsViewed();
        }

        private void Clean_View_Click(object sender, EventArgs e)
        {
            ClearFieldsViewed();
        }

        private void Refresh_View_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewed(DataGridViewed);
            ClearFieldsViewed();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SearchViewed(DataGridViewed);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex==2)
            {
                this.Close();
            }
        }
    }
}

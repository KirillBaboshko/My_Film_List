using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
            DataGrid.Columns.Add("id_item", "Id");
            DataGrid.Columns.Add("item_name", "Название");
            DataGrid.Columns.Add("item_count_of_episodes", "Кол-во эпизодов");
            DataGrid.Columns.Add("item_duration", "Общая продолжительность");
            DataGrid.Columns.Add("item_realease_date", "Дата выхода");
            DataGrid.Columns.Add("item_link", "Ссылка");
        }
        private void ClearFields()
        {
            TextBoxName.Texts = "";
            TextBoxCount1.Texts = "";
            TextBoxCount2.Texts = "";
            TextBoxData.Texts = "";
            TextBoxDuration.Texts = "";
            TextBoxLink.Texts = "";
        }
        private void ReadSingleRow(DataGridView dgw,IDataRecord record)
        {
            dgw.Rows.Add(int.Parse(record.GetValue(0).ToString()), record.GetValue(1).ToString(), $"{int.Parse(record.GetValue(3).ToString())} из {int.Parse(record.GetValue(2).ToString())}", int.Parse(record.GetValue(4).ToString()), DateTime.Parse(record.GetValue(5).ToString()).ToShortDateString(), record.GetValue(6).ToString());
        }
        private void DeleteRow()
        {
            dataBase.openConnection();
            int index = DataGrid.CurrentCell.RowIndex;
            var id = Convert.ToInt32(DataGrid.Rows[index].Cells[0].Value);
            string deleteQuery = $"DELETE FROM Planned WHERE id_item = {id}";
            var com = new SQLiteCommand(deleteQuery,dataBase.GetConnection());
            com.ExecuteNonQuery();
            dataBase.closeConnection();
            RefreshDataGrid(DataGrid);
        }
        public void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Planned";
            SQLiteCommand command = new SQLiteCommand(queryString, dataBase.GetConnection());
            dataBase.openConnection();
            SQLiteDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                ReadSingleRow(dgw,reader);
            }
            reader.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(DataGrid);
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow = e.RowIndex;
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = DataGrid.Rows[SelectRow];
                TextBoxName.Texts = row.Cells[1].Value.ToString();
                string[] str = row.Cells[2].Value.ToString().Split();
                TextBoxCount1.Texts = str[2];
                TextBoxCount2.Texts = str[0];
                TextBoxDuration.Texts= row.Cells[3].Value.ToString();
                TextBoxData.Texts = row.Cells[4].Value.ToString();
                TextBoxLink.Texts = row.Cells[5].Value.ToString();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(DataGrid);
        }

        private void Butt_Add_Click(object sender, EventArgs e)
        {
            AddForm addfrm = new AddForm(this);
            addfrm.Show();
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchStr = $"SELECT * FROM Planned WHERE item_name LIKE '%{textBox1.Text}%' OR item_count_of_episodes_max LIKE '%{textBox1.Text}%' OR item_count_of_episodes_now LIKE '%{textBox1.Text}%' OR item_duration LIKE '%{textBox1.Text}%' OR item_realease_date LIKE '%{textBox1.Text}%' OR item_link LIKE '%{textBox1.Text}%'";
            SQLiteCommand com = new SQLiteCommand(searchStr,dataBase.GetConnection());
            dataBase.openConnection();
            SQLiteDataReader read = com.ExecuteReader();
            while(read.Read())
            {
                ReadSingleRow(dgw,read);
            }
            read.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(DataGrid);
        }

        private void Butt_Del_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }
        private void Edit()
        {
            int index= DataGrid.CurrentCell.RowIndex;
            dataBase.openConnection();
            var id = DataGrid.Rows[index].Cells[0].Value.ToString();
            var Name = TextBoxName.Texts;
            int MaxCount;
            int MinCount;
            int Duration;
            DateTime Date;
            var Link = TextBoxLink.Texts;

            if (int.TryParse(TextBoxCount1.Texts, out MaxCount) && int.TryParse(TextBoxCount2.Texts, out MinCount) && int.TryParse(TextBoxDuration.Texts, out Duration) && DateTime.TryParse(TextBoxData.Texts, out Date))
            {
                var addQuert = $"UPDATE Planned SET item_name= '{Name}',item_count_of_episodes_max = '{MaxCount}',item_count_of_episodes_now = '{MinCount}',item_duration = '{Duration}',item_realease_date = '{Date.ToShortDateString()}',item_link = '{Link}' WHERE id_item='{id}'";
                var command = new SQLiteCommand(addQuert, dataBase.GetConnection());
                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Допустили ошибку при вводе данных!!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
            RefreshDataGrid(DataGrid);
        }
        private void Butt_Edit_Click(object sender, EventArgs e)
        {
            Edit();
            ClearFields();
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}

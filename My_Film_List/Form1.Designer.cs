using System.Windows.Forms;

namespace My_Film_List
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clean = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxCount2 = new My_Film_List.GoodControls.GoodTextBox();
            this.TextBoxLink = new My_Film_List.GoodControls.GoodTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxData = new My_Film_List.GoodControls.GoodTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxDuration = new My_Film_List.GoodControls.GoodTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxCount1 = new My_Film_List.GoodControls.GoodTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxName = new My_Film_List.GoodControls.GoodTextBox();
            this.Butt_Edit = new My_Film_List.GoodButton();
            this.Butt_Del = new My_Film_List.GoodButton();
            this.Butt_Add = new My_Film_List.GoodButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(123, 70);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(880, 367);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Clean);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 55);
            this.panel1.TabIndex = 1;
            // 
            // Clean
            // 
            this.Clean.BackgroundImage = global::My_Film_List.Properties.Resources.изображение_2024_06_15_233133387;
            this.Clean.Location = new System.Drawing.Point(681, 12);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(40, 40);
            this.Clean.TabIndex = 2;
            this.Clean.TabStop = false;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(852, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Refresh
            // 
            this.Refresh.Image = global::My_Film_List.Properties.Resources.refresh_1_1024__1___1___1_;
            this.Refresh.Location = new System.Drawing.Point(735, 12);
            this.Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(40, 40);
            this.Refresh.TabIndex = 0;
            this.Refresh.TabStop = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(207, 448);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбранное произведение:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TextBoxCount2);
            this.panel2.Controls.Add(this.TextBoxLink);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TextBoxData);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TextBoxDuration);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TextBoxCount1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TextBoxName);
            this.panel2.Location = new System.Drawing.Point(44, 482);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 236);
            this.panel2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(24, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Просмотренное кол-во эпизодов:";
            // 
            // TextBoxCount2
            // 
            this.TextBoxCount2.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxCount2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TextBoxCount2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxCount2.BorderSize = 2;
            this.TextBoxCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCount2.ForeColor = System.Drawing.Color.DimGray;
            this.TextBoxCount2.Location = new System.Drawing.Point(326, 88);
            this.TextBoxCount2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxCount2.MaxLength = 50;
            this.TextBoxCount2.Multiline = false;
            this.TextBoxCount2.Name = "TextBoxCount2";
            this.TextBoxCount2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextBoxCount2.PasswordChar = false;
            this.TextBoxCount2.Size = new System.Drawing.Size(188, 29);
            this.TextBoxCount2.TabIndex = 5;
            this.TextBoxCount2.Texts = "";
            this.TextBoxCount2.UnderlinedStyle = false;
            // 
            // TextBoxLink
            // 
            this.TextBoxLink.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxLink.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TextBoxLink.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxLink.BorderSize = 2;
            this.TextBoxLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLink.ForeColor = System.Drawing.Color.DimGray;
            this.TextBoxLink.Location = new System.Drawing.Point(326, 193);
            this.TextBoxLink.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxLink.MaxLength = 50;
            this.TextBoxLink.Multiline = false;
            this.TextBoxLink.Name = "TextBoxLink";
            this.TextBoxLink.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextBoxLink.PasswordChar = false;
            this.TextBoxLink.Size = new System.Drawing.Size(188, 29);
            this.TextBoxLink.TabIndex = 9;
            this.TextBoxLink.Texts = "";
            this.TextBoxLink.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(234, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ссылка:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(193, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дата выхода:";
            // 
            // TextBoxData
            // 
            this.TextBoxData.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxData.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TextBoxData.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxData.BorderSize = 2;
            this.TextBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxData.ForeColor = System.Drawing.Color.DimGray;
            this.TextBoxData.Location = new System.Drawing.Point(326, 158);
            this.TextBoxData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxData.MaxLength = 50;
            this.TextBoxData.Multiline = false;
            this.TextBoxData.Name = "TextBoxData";
            this.TextBoxData.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextBoxData.PasswordChar = false;
            this.TextBoxData.Size = new System.Drawing.Size(188, 29);
            this.TextBoxData.TabIndex = 6;
            this.TextBoxData.Texts = "";
            this.TextBoxData.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(133, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Продолжительность:";
            // 
            // TextBoxDuration
            // 
            this.TextBoxDuration.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxDuration.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TextBoxDuration.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxDuration.BorderSize = 2;
            this.TextBoxDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxDuration.ForeColor = System.Drawing.Color.DimGray;
            this.TextBoxDuration.Location = new System.Drawing.Point(326, 123);
            this.TextBoxDuration.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxDuration.MaxLength = 50;
            this.TextBoxDuration.Multiline = false;
            this.TextBoxDuration.Name = "TextBoxDuration";
            this.TextBoxDuration.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextBoxDuration.PasswordChar = false;
            this.TextBoxDuration.Size = new System.Drawing.Size(188, 29);
            this.TextBoxDuration.TabIndex = 4;
            this.TextBoxDuration.Texts = "";
            this.TextBoxDuration.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(96, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Общее кол-во эпизодов:";
            // 
            // TextBoxCount1
            // 
            this.TextBoxCount1.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxCount1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TextBoxCount1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxCount1.BorderSize = 2;
            this.TextBoxCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCount1.ForeColor = System.Drawing.Color.DimGray;
            this.TextBoxCount1.Location = new System.Drawing.Point(326, 53);
            this.TextBoxCount1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxCount1.MaxLength = 50;
            this.TextBoxCount1.Multiline = false;
            this.TextBoxCount1.Name = "TextBoxCount1";
            this.TextBoxCount1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextBoxCount1.PasswordChar = false;
            this.TextBoxCount1.Size = new System.Drawing.Size(188, 29);
            this.TextBoxCount1.TabIndex = 2;
            this.TextBoxCount1.Texts = "";
            this.TextBoxCount1.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(218, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TextBoxName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxName.BorderSize = 2;
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxName.ForeColor = System.Drawing.Color.DimGray;
            this.TextBoxName.Location = new System.Drawing.Point(326, 18);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxName.MaxLength = 50;
            this.TextBoxName.Multiline = false;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextBoxName.PasswordChar = false;
            this.TextBoxName.Size = new System.Drawing.Size(188, 29);
            this.TextBoxName.TabIndex = 0;
            this.TextBoxName.Texts = "";
            this.TextBoxName.UnderlinedStyle = false;
            // 
            // Butt_Edit
            // 
            this.Butt_Edit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Butt_Edit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Butt_Edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Butt_Edit.BorderRadius = 20;
            this.Butt_Edit.BorderSize = 0;
            this.Butt_Edit.FlatAppearance.BorderSize = 0;
            this.Butt_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Edit.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Butt_Edit.ForeColor = System.Drawing.Color.White;
            this.Butt_Edit.Location = new System.Drawing.Point(861, 629);
            this.Butt_Edit.Name = "Butt_Edit";
            this.Butt_Edit.Size = new System.Drawing.Size(142, 40);
            this.Butt_Edit.TabIndex = 6;
            this.Butt_Edit.Text = "Изменить";
            this.Butt_Edit.TextColor = System.Drawing.Color.White;
            this.Butt_Edit.UseVisualStyleBackColor = false;
            this.Butt_Edit.Click += new System.EventHandler(this.Butt_Edit_Click);
            // 
            // Butt_Del
            // 
            this.Butt_Del.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Butt_Del.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Butt_Del.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Butt_Del.BorderRadius = 20;
            this.Butt_Del.BorderSize = 0;
            this.Butt_Del.FlatAppearance.BorderSize = 0;
            this.Butt_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Del.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Butt_Del.ForeColor = System.Drawing.Color.White;
            this.Butt_Del.Location = new System.Drawing.Point(861, 570);
            this.Butt_Del.Name = "Butt_Del";
            this.Butt_Del.Size = new System.Drawing.Size(142, 40);
            this.Butt_Del.TabIndex = 5;
            this.Butt_Del.Text = "Удалить";
            this.Butt_Del.TextColor = System.Drawing.Color.White;
            this.Butt_Del.UseVisualStyleBackColor = false;
            this.Butt_Del.Click += new System.EventHandler(this.Butt_Del_Click);
            // 
            // Butt_Add
            // 
            this.Butt_Add.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Butt_Add.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Butt_Add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Butt_Add.BorderRadius = 20;
            this.Butt_Add.BorderSize = 0;
            this.Butt_Add.FlatAppearance.BorderSize = 0;
            this.Butt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Add.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Butt_Add.ForeColor = System.Drawing.Color.White;
            this.Butt_Add.Location = new System.Drawing.Point(861, 514);
            this.Butt_Add.Margin = new System.Windows.Forms.Padding(2);
            this.Butt_Add.Name = "Butt_Add";
            this.Butt_Add.Size = new System.Drawing.Size(142, 41);
            this.Butt_Add.TabIndex = 2;
            this.Butt_Add.Text = "Добавить ";
            this.Butt_Add.TextColor = System.Drawing.Color.White;
            this.Butt_Add.UseVisualStyleBackColor = false;
            this.Butt_Add.Click += new System.EventHandler(this.Butt_Add_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.Butt_Edit);
            this.Controls.Add(this.Butt_Del);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Butt_Add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список для просмотра";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView DataGrid;
        private Panel panel1;
        private PictureBox Refresh;
        private GoodButton Butt_Add;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private GoodControls.GoodTextBox TextBoxName;
        private GoodControls.GoodTextBox TextBoxCount1;
        private Label label3;
        private GoodControls.GoodTextBox TextBoxData;
        private Label label4;
        private GoodControls.GoodTextBox TextBoxDuration;
        private Label label5;
        private GoodControls.GoodTextBox TextBoxLink;
        private Label label6;
        private Label label7;
        private GoodControls.GoodTextBox TextBoxCount2;
        private TextBox textBox1;
        private GoodButton Butt_Del;
        private GoodButton Butt_Edit;
        private PictureBox Clean;
    }
}


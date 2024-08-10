using System;
using System.Drawing;
using System.Runtime.InteropServices;
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
        /// 

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font fntTab;
            Brush bshBack;
            Brush bshFore;
            if (e.Index == 2)
            {
                ;
                fntTab = new Font(e.Font, FontStyle.Bold);
                bshBack = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height+4), Color.FromArgb(237, 92, 84), Color.FromArgb(237, 92, 84), System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                bshFore = Brushes.White;
                string tabName = this.tabControl1.TabPages[e.Index].Text;
                StringFormat sftTab = new StringFormat(StringFormatFlags.NoClip);
                sftTab.Alignment = StringAlignment.Center;
                sftTab.LineAlignment = StringAlignment.Center;
                e.Graphics.FillRectangle(bshBack, new Rectangle(e.Bounds.X , e.Bounds.Y , e.Bounds.Width, e.Bounds.Height + 4));
                Rectangle recTab = new Rectangle(e.Bounds.X , e.Bounds.Y , e.Bounds.Width, e.Bounds.Height + 4);
                recTab = new Rectangle(recTab.X, recTab.Y + 4, recTab.Width, recTab.Height - 4);
                e.Graphics.DrawString(tabName, fntTab, bshFore, recTab, sftTab);
            }
            else 
            {
                if (e.Index == this.tabControl1.SelectedIndex)
                {
                    fntTab = new Font(e.Font, FontStyle.Bold);
                    bshBack = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.FromArgb(48, 33, 120), Color.FromArgb(48, 33, 120) , System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                    bshFore = Brushes.White;
                }
                else
                {
                    fntTab = e.Font;
                    bshBack = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.FromArgb(73, 55, 135), Color.FromArgb(73, 55, 135), System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal);
                    bshFore = Brushes.White;
                }
                string tabName = this.tabControl1.TabPages[e.Index].Text;
                StringFormat sftTab = new StringFormat(StringFormatFlags.NoClip);
                sftTab.Alignment = StringAlignment.Center;
                sftTab.LineAlignment = StringAlignment.Center;
                e.Graphics.FillRectangle(bshBack, e.Bounds);
                Rectangle recTab = e.Bounds;
                recTab = new Rectangle(recTab.X, recTab.Y + 4, recTab.Width, recTab.Height - 4);
                e.Graphics.DrawString(tabName, fntTab, bshFore, recTab, sftTab);
            }
            
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PageViewed = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Butt_Del_View = new My_Film_List.GoodButton();
            this.Butt_Rating = new My_Film_List.GoodButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TextBoxRating = new My_Film_List.GoodControls.GoodTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxCount2_View = new My_Film_List.GoodControls.GoodTextBox();
            this.TextBoxLink_View = new My_Film_List.GoodControls.GoodTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxData_View = new My_Film_List.GoodControls.GoodTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TextBoxDuration_View = new My_Film_List.GoodControls.GoodTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TextBoxCount1_View = new My_Film_List.GoodControls.GoodTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TextBoxName_View = new My_Film_List.GoodControls.GoodTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Clean_View = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Refresh_View = new System.Windows.Forms.PictureBox();
            this.DataGridViewed = new System.Windows.Forms.DataGridView();
            this.PagePlanned = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Butt_Transfer = new My_Film_List.GoodButton();
            this.Butt_Edit = new My_Film_List.GoodButton();
            this.Butt_Del = new My_Film_List.GoodButton();
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
            this.Butt_Add = new My_Film_List.GoodButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clean = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.PictureBox();
            this.DataGridPlanned = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Close = new System.Windows.Forms.TabPage();
            this.PageViewed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clean_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewed)).BeginInit();
            this.PagePlanned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPlanned)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageViewed
            // 
            this.PageViewed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.PageViewed.Controls.Add(this.pictureBox1);
            this.PageViewed.Controls.Add(this.Butt_Del_View);
            this.PageViewed.Controls.Add(this.Butt_Rating);
            this.PageViewed.Controls.Add(this.label8);
            this.PageViewed.Controls.Add(this.panel4);
            this.PageViewed.Controls.Add(this.panel3);
            this.PageViewed.Controls.Add(this.DataGridViewed);
            this.PageViewed.Font = new System.Drawing.Font("Plus Jakarta Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageViewed.Location = new System.Drawing.Point(4, 44);
            this.PageViewed.Margin = new System.Windows.Forms.Padding(4);
            this.PageViewed.Name = "PageViewed";
            this.PageViewed.Padding = new System.Windows.Forms.Padding(4);
            this.PageViewed.Size = new System.Drawing.Size(1605, 946);
            this.PageViewed.TabIndex = 1;
            this.PageViewed.Text = "Просмотренные";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::My_Film_List.Properties.Resources.icons8_cinema_seats_80;
            this.pictureBox1.Location = new System.Drawing.Point(29, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 100);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Butt_Del_View
            // 
            this.Butt_Del_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.Butt_Del_View.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.Butt_Del_View.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Butt_Del_View.BorderRadius = 20;
            this.Butt_Del_View.BorderSize = 0;
            this.Butt_Del_View.FlatAppearance.BorderSize = 0;
            this.Butt_Del_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Del_View.Font = new System.Drawing.Font("Plus Jakarta Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Del_View.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Butt_Del_View.Location = new System.Drawing.Point(1239, 693);
            this.Butt_Del_View.Margin = new System.Windows.Forms.Padding(4);
            this.Butt_Del_View.Name = "Butt_Del_View";
            this.Butt_Del_View.Size = new System.Drawing.Size(284, 60);
            this.Butt_Del_View.TabIndex = 15;
            this.Butt_Del_View.Text = "Удалить";
            this.Butt_Del_View.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Butt_Del_View.UseVisualStyleBackColor = false;
            this.Butt_Del_View.Click += new System.EventHandler(this.Butt_Del_View_Click);
            // 
            // Butt_Rating
            // 
            this.Butt_Rating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.Butt_Rating.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.Butt_Rating.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Butt_Rating.BorderRadius = 20;
            this.Butt_Rating.BorderSize = 0;
            this.Butt_Rating.FlatAppearance.BorderSize = 0;
            this.Butt_Rating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Rating.Font = new System.Drawing.Font("Plus Jakarta Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Rating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Butt_Rating.Location = new System.Drawing.Point(1239, 608);
            this.Butt_Rating.Margin = new System.Windows.Forms.Padding(4);
            this.Butt_Rating.Name = "Butt_Rating";
            this.Butt_Rating.Size = new System.Drawing.Size(284, 60);
            this.Butt_Rating.TabIndex = 14;
            this.Butt_Rating.Text = "Выставить рейтинг";
            this.Butt_Rating.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Butt_Rating.UseVisualStyleBackColor = false;
            this.Butt_Rating.Click += new System.EventHandler(this.Butt_Rating_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Plus Jakarta Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(271, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(417, 38);
            this.label8.TabIndex = 12;
            this.label8.Text = "Выбранное произведение:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TextBoxRating);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.TextBoxCount2_View);
            this.panel4.Controls.Add(this.TextBoxLink_View);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.TextBoxData_View);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.TextBoxDuration_View);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.TextBoxCount1_View);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.TextBoxName_View);
            this.panel4.Location = new System.Drawing.Point(7, 544);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1225, 290);
            this.panel4.TabIndex = 13;
            // 
            // TextBoxRating
            // 
            this.TextBoxRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.TextBoxRating.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.TextBoxRating.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxRating.BorderSize = 2;
            this.TextBoxRating.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRating.ForeColor = System.Drawing.Color.White;
            this.TextBoxRating.Location = new System.Drawing.Point(949, 116);
            this.TextBoxRating.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxRating.MaxLength = 50;
            this.TextBoxRating.Multiline = false;
            this.TextBoxRating.Name = "TextBoxRating";
            this.TextBoxRating.Padding = new System.Windows.Forms.Padding(9);
            this.TextBoxRating.PasswordChar = false;
            this.TextBoxRating.Size = new System.Drawing.Size(251, 47);
            this.TextBoxRating.TabIndex = 12;
            this.TextBoxRating.Texts = "";
            this.TextBoxRating.UnderlinedStyle = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Plus Jakarta Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(736, 122);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(210, 38);
            this.label15.TabIndex = 11;
            this.label15.Text = "Ваша оценка:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Plus Jakarta Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(400, 32);
            this.label9.TabIndex = 10;
            this.label9.Text = "Просмотренное кол-во эпизодов:";
            // 
            // TextBoxCount2_View
            // 
            this.TextBoxCount2_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.TextBoxCount2_View.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.TextBoxCount2_View.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxCount2_View.BorderSize = 2;
            this.TextBoxCount2_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCount2_View.ForeColor = System.Drawing.Color.White;
            this.TextBoxCount2_View.Location = new System.Drawing.Point(455, 107);
            this.TextBoxCount2_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxCount2_View.MaxLength = 50;
            this.TextBoxCount2_View.Multiline = false;
            this.TextBoxCount2_View.Name = "TextBoxCount2_View";
            this.TextBoxCount2_View.Padding = new System.Windows.Forms.Padding(7);
            this.TextBoxCount2_View.PasswordChar = false;
            this.TextBoxCount2_View.Size = new System.Drawing.Size(251, 35);
            this.TextBoxCount2_View.TabIndex = 5;
            this.TextBoxCount2_View.Texts = "";
            this.TextBoxCount2_View.UnderlinedStyle = true;
            // 
            // TextBoxLink_View
            // 
            this.TextBoxLink_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.TextBoxLink_View.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.TextBoxLink_View.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxLink_View.BorderSize = 2;
            this.TextBoxLink_View.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLink_View.ForeColor = System.Drawing.Color.White;
            this.TextBoxLink_View.Location = new System.Drawing.Point(455, 233);
            this.TextBoxLink_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxLink_View.MaxLength = 50;
            this.TextBoxLink_View.Multiline = false;
            this.TextBoxLink_View.Name = "TextBoxLink_View";
            this.TextBoxLink_View.Padding = new System.Windows.Forms.Padding(7);
            this.TextBoxLink_View.PasswordChar = false;
            this.TextBoxLink_View.Size = new System.Drawing.Size(251, 43);
            this.TextBoxLink_View.TabIndex = 9;
            this.TextBoxLink_View.Texts = "";
            this.TextBoxLink_View.UnderlinedStyle = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Plus Jakarta Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(335, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 32);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ссылка:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Plus Jakarta Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(287, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 32);
            this.label11.TabIndex = 7;
            this.label11.Text = "Год выхода:";
            // 
            // TextBoxData_View
            // 
            this.TextBoxData_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.TextBoxData_View.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.TextBoxData_View.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxData_View.BorderSize = 2;
            this.TextBoxData_View.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxData_View.ForeColor = System.Drawing.Color.White;
            this.TextBoxData_View.Location = new System.Drawing.Point(455, 190);
            this.TextBoxData_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxData_View.MaxLength = 50;
            this.TextBoxData_View.Multiline = false;
            this.TextBoxData_View.Name = "TextBoxData_View";
            this.TextBoxData_View.Padding = new System.Windows.Forms.Padding(7);
            this.TextBoxData_View.PasswordChar = false;
            this.TextBoxData_View.Size = new System.Drawing.Size(251, 43);
            this.TextBoxData_View.TabIndex = 6;
            this.TextBoxData_View.Texts = "";
            this.TextBoxData_View.UnderlinedStyle = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Plus Jakarta Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(163, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(258, 32);
            this.label12.TabIndex = 5;
            this.label12.Text = "Продолжительность:";
            // 
            // TextBoxDuration_View
            // 
            this.TextBoxDuration_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.TextBoxDuration_View.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.TextBoxDuration_View.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxDuration_View.BorderSize = 2;
            this.TextBoxDuration_View.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDuration_View.ForeColor = System.Drawing.Color.White;
            this.TextBoxDuration_View.Location = new System.Drawing.Point(455, 144);
            this.TextBoxDuration_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDuration_View.MaxLength = 50;
            this.TextBoxDuration_View.Multiline = false;
            this.TextBoxDuration_View.Name = "TextBoxDuration_View";
            this.TextBoxDuration_View.Padding = new System.Windows.Forms.Padding(7);
            this.TextBoxDuration_View.PasswordChar = false;
            this.TextBoxDuration_View.Size = new System.Drawing.Size(251, 43);
            this.TextBoxDuration_View.TabIndex = 4;
            this.TextBoxDuration_View.Texts = "";
            this.TextBoxDuration_View.UnderlinedStyle = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Plus Jakarta Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(135, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(296, 32);
            this.label13.TabIndex = 3;
            this.label13.Text = "Общее кол-во эпизодов:";
            // 
            // TextBoxCount1_View
            // 
            this.TextBoxCount1_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.TextBoxCount1_View.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.TextBoxCount1_View.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxCount1_View.BorderSize = 2;
            this.TextBoxCount1_View.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCount1_View.ForeColor = System.Drawing.Color.White;
            this.TextBoxCount1_View.Location = new System.Drawing.Point(455, 59);
            this.TextBoxCount1_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxCount1_View.MaxLength = 50;
            this.TextBoxCount1_View.Multiline = false;
            this.TextBoxCount1_View.Name = "TextBoxCount1_View";
            this.TextBoxCount1_View.Padding = new System.Windows.Forms.Padding(7);
            this.TextBoxCount1_View.PasswordChar = false;
            this.TextBoxCount1_View.Size = new System.Drawing.Size(251, 43);
            this.TextBoxCount1_View.TabIndex = 2;
            this.TextBoxCount1_View.Texts = "";
            this.TextBoxCount1_View.UnderlinedStyle = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Plus Jakarta Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(311, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 32);
            this.label14.TabIndex = 1;
            this.label14.Text = "Название:";
            // 
            // TextBoxName_View
            // 
            this.TextBoxName_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.TextBoxName_View.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.TextBoxName_View.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxName_View.BorderSize = 2;
            this.TextBoxName_View.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName_View.ForeColor = System.Drawing.Color.White;
            this.TextBoxName_View.Location = new System.Drawing.Point(455, 15);
            this.TextBoxName_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxName_View.MaxLength = 50;
            this.TextBoxName_View.Multiline = false;
            this.TextBoxName_View.Name = "TextBoxName_View";
            this.TextBoxName_View.Padding = new System.Windows.Forms.Padding(7);
            this.TextBoxName_View.PasswordChar = false;
            this.TextBoxName_View.Size = new System.Drawing.Size(251, 43);
            this.TextBoxName_View.TabIndex = 0;
            this.TextBoxName_View.Texts = "";
            this.TextBoxName_View.UnderlinedStyle = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Clean_View);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.Refresh_View);
            this.panel3.Location = new System.Drawing.Point(172, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1268, 74);
            this.panel3.TabIndex = 9;
            // 
            // Clean_View
            // 
            this.Clean_View.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Clean_View.BackgroundImage")));
            this.Clean_View.Location = new System.Drawing.Point(791, 15);
            this.Clean_View.Margin = new System.Windows.Forms.Padding(4);
            this.Clean_View.Name = "Clean_View";
            this.Clean_View.Size = new System.Drawing.Size(53, 49);
            this.Clean_View.TabIndex = 2;
            this.Clean_View.TabStop = false;
            this.Clean_View.Click += new System.EventHandler(this.Clean_View_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(998, 27);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 28);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Refresh_View
            // 
            this.Refresh_View.Image = ((System.Drawing.Image)(resources.GetObject("Refresh_View.Image")));
            this.Refresh_View.Location = new System.Drawing.Point(862, 15);
            this.Refresh_View.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Refresh_View.Name = "Refresh_View";
            this.Refresh_View.Size = new System.Drawing.Size(53, 49);
            this.Refresh_View.TabIndex = 0;
            this.Refresh_View.TabStop = false;
            this.Refresh_View.Click += new System.EventHandler(this.Refresh_View_Click);
            // 
            // DataGridViewed
            // 
            this.DataGridViewed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(77)))), ((int)(((byte)(150)))));
            this.DataGridViewed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(77)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Plus Jakarta Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(77)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Plus Jakarta Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewed.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewed.EnableHeadersVisualStyles = false;
            this.DataGridViewed.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.DataGridViewed.Location = new System.Drawing.Point(167, 85);
            this.DataGridViewed.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridViewed.Name = "DataGridViewed";
            this.DataGridViewed.ReadOnly = true;
            this.DataGridViewed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(77)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Plus Jakarta Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewed.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewed.RowHeadersWidth = 51;
            this.DataGridViewed.Size = new System.Drawing.Size(1219, 401);
            this.DataGridViewed.TabIndex = 0;
            this.DataGridViewed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewed_CellClick);
            this.DataGridViewed.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewed_CellContentDoubleClick);
            // 
            // PagePlanned
            // 
            this.PagePlanned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.PagePlanned.Controls.Add(this.pictureBox2);
            this.PagePlanned.Controls.Add(this.Butt_Transfer);
            this.PagePlanned.Controls.Add(this.Butt_Edit);
            this.PagePlanned.Controls.Add(this.Butt_Del);
            this.PagePlanned.Controls.Add(this.label1);
            this.PagePlanned.Controls.Add(this.panel2);
            this.PagePlanned.Controls.Add(this.Butt_Add);
            this.PagePlanned.Controls.Add(this.panel1);
            this.PagePlanned.Controls.Add(this.DataGridPlanned);
            this.PagePlanned.Font = new System.Drawing.Font("Plus Jakarta Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagePlanned.Location = new System.Drawing.Point(4, 44);
            this.PagePlanned.Margin = new System.Windows.Forms.Padding(4);
            this.PagePlanned.Name = "PagePlanned";
            this.PagePlanned.Padding = new System.Windows.Forms.Padding(4);
            this.PagePlanned.Size = new System.Drawing.Size(1605, 946);
            this.PagePlanned.TabIndex = 0;
            this.PagePlanned.Text = "Запланированные";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::My_Film_List.Properties.Resources.icons8_cinema_seats_80;
            this.pictureBox2.Location = new System.Drawing.Point(27, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 100);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Butt_Transfer
            // 
            this.Butt_Transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.Butt_Transfer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.Butt_Transfer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Butt_Transfer.BorderRadius = 20;
            this.Butt_Transfer.BorderSize = 0;
            this.Butt_Transfer.FlatAppearance.BorderSize = 0;
            this.Butt_Transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Transfer.Font = new System.Drawing.Font("Plus Jakarta Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Transfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Butt_Transfer.Location = new System.Drawing.Point(1151, 741);
            this.Butt_Transfer.Margin = new System.Windows.Forms.Padding(4);
            this.Butt_Transfer.Name = "Butt_Transfer";
            this.Butt_Transfer.Size = new System.Drawing.Size(207, 49);
            this.Butt_Transfer.TabIndex = 14;
            this.Butt_Transfer.Text = "Просмотренно";
            this.Butt_Transfer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Butt_Transfer.UseVisualStyleBackColor = false;
            this.Butt_Transfer.Click += new System.EventHandler(this.Butt_Transfer_Click);
            // 
            // Butt_Edit
            // 
            this.Butt_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.Butt_Edit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.Butt_Edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Butt_Edit.BorderRadius = 20;
            this.Butt_Edit.BorderSize = 0;
            this.Butt_Edit.FlatAppearance.BorderSize = 0;
            this.Butt_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Edit.Font = new System.Drawing.Font("Plus Jakarta Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Butt_Edit.Location = new System.Drawing.Point(1151, 674);
            this.Butt_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.Butt_Edit.Name = "Butt_Edit";
            this.Butt_Edit.Size = new System.Drawing.Size(207, 49);
            this.Butt_Edit.TabIndex = 13;
            this.Butt_Edit.Text = "Изменить";
            this.Butt_Edit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Butt_Edit.UseVisualStyleBackColor = false;
            this.Butt_Edit.Click += new System.EventHandler(this.Butt_Edit_Click);
            // 
            // Butt_Del
            // 
            this.Butt_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.Butt_Del.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.Butt_Del.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Butt_Del.BorderRadius = 20;
            this.Butt_Del.BorderSize = 0;
            this.Butt_Del.FlatAppearance.BorderSize = 0;
            this.Butt_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Del.Font = new System.Drawing.Font("Plus Jakarta Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Butt_Del.Location = new System.Drawing.Point(1151, 612);
            this.Butt_Del.Margin = new System.Windows.Forms.Padding(4);
            this.Butt_Del.Name = "Butt_Del";
            this.Butt_Del.Size = new System.Drawing.Size(207, 49);
            this.Butt_Del.TabIndex = 12;
            this.Butt_Del.Text = "Удалить";
            this.Butt_Del.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Butt_Del.UseVisualStyleBackColor = false;
            this.Butt_Del.Click += new System.EventHandler(this.Butt_Del_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Plus Jakarta Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 38);
            this.label1.TabIndex = 10;
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
            this.panel2.Location = new System.Drawing.Point(85, 546);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 286);
            this.panel2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Plus Jakarta Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-4, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(400, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Просмотренное кол-во эпизодов:";
            // 
            // TextBoxCount2
            // 
            this.TextBoxCount2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.TextBoxCount2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.TextBoxCount2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxCount2.BorderSize = 2;
            this.TextBoxCount2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCount2.ForeColor = System.Drawing.Color.White;
            this.TextBoxCount2.Location = new System.Drawing.Point(435, 108);
            this.TextBoxCount2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxCount2.MaxLength = 50;
            this.TextBoxCount2.Multiline = false;
            this.TextBoxCount2.Name = "TextBoxCount2";
            this.TextBoxCount2.Padding = new System.Windows.Forms.Padding(7);
            this.TextBoxCount2.PasswordChar = false;
            this.TextBoxCount2.Size = new System.Drawing.Size(251, 43);
            this.TextBoxCount2.TabIndex = 5;
            this.TextBoxCount2.Texts = "";
            this.TextBoxCount2.UnderlinedStyle = true;
            // 
            // TextBoxLink
            // 
            this.TextBoxLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.TextBoxLink.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.TextBoxLink.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxLink.BorderSize = 2;
            this.TextBoxLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLink.ForeColor = System.Drawing.Color.White;
            this.TextBoxLink.Location = new System.Drawing.Point(435, 238);
            this.TextBoxLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxLink.MaxLength = 50;
            this.TextBoxLink.Multiline = false;
            this.TextBoxLink.Name = "TextBoxLink";
            this.TextBoxLink.Padding = new System.Windows.Forms.Padding(7);
            this.TextBoxLink.PasswordChar = false;
            this.TextBoxLink.Size = new System.Drawing.Size(251, 35);
            this.TextBoxLink.TabIndex = 9;
            this.TextBoxLink.Texts = "";
            this.TextBoxLink.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Plus Jakarta Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(315, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ссылка:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Plus Jakarta Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(265, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Год выхода:";
            // 
            // TextBoxData
            // 
            this.TextBoxData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.TextBoxData.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.TextBoxData.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxData.BorderSize = 2;
            this.TextBoxData.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxData.ForeColor = System.Drawing.Color.White;
            this.TextBoxData.Location = new System.Drawing.Point(435, 194);
            this.TextBoxData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxData.MaxLength = 50;
            this.TextBoxData.Multiline = false;
            this.TextBoxData.Name = "TextBoxData";
            this.TextBoxData.Padding = new System.Windows.Forms.Padding(7);
            this.TextBoxData.PasswordChar = false;
            this.TextBoxData.Size = new System.Drawing.Size(251, 43);
            this.TextBoxData.TabIndex = 6;
            this.TextBoxData.Texts = "";
            this.TextBoxData.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Plus Jakarta Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(143, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Продолжительность:";
            // 
            // TextBoxDuration
            // 
            this.TextBoxDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.TextBoxDuration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.TextBoxDuration.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxDuration.BorderSize = 2;
            this.TextBoxDuration.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDuration.ForeColor = System.Drawing.Color.White;
            this.TextBoxDuration.Location = new System.Drawing.Point(435, 151);
            this.TextBoxDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDuration.MaxLength = 50;
            this.TextBoxDuration.Multiline = false;
            this.TextBoxDuration.Name = "TextBoxDuration";
            this.TextBoxDuration.Padding = new System.Windows.Forms.Padding(7);
            this.TextBoxDuration.PasswordChar = false;
            this.TextBoxDuration.Size = new System.Drawing.Size(251, 43);
            this.TextBoxDuration.TabIndex = 4;
            this.TextBoxDuration.Texts = "";
            this.TextBoxDuration.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Plus Jakarta Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Общее кол-во эпизодов:";
            // 
            // TextBoxCount1
            // 
            this.TextBoxCount1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.TextBoxCount1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.TextBoxCount1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxCount1.BorderSize = 2;
            this.TextBoxCount1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCount1.ForeColor = System.Drawing.Color.White;
            this.TextBoxCount1.Location = new System.Drawing.Point(435, 65);
            this.TextBoxCount1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxCount1.MaxLength = 50;
            this.TextBoxCount1.Multiline = false;
            this.TextBoxCount1.Name = "TextBoxCount1";
            this.TextBoxCount1.Padding = new System.Windows.Forms.Padding(7);
            this.TextBoxCount1.PasswordChar = false;
            this.TextBoxCount1.Size = new System.Drawing.Size(251, 43);
            this.TextBoxCount1.TabIndex = 2;
            this.TextBoxCount1.Texts = "";
            this.TextBoxCount1.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Plus Jakarta Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(291, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(33)))), ((int)(((byte)(120)))));
            this.TextBoxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.TextBoxName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TextBoxName.BorderSize = 2;
            this.TextBoxName.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.ForeColor = System.Drawing.Color.White;
            this.TextBoxName.Location = new System.Drawing.Point(435, 22);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxName.MaxLength = 50;
            this.TextBoxName.Multiline = false;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Padding = new System.Windows.Forms.Padding(7);
            this.TextBoxName.PasswordChar = false;
            this.TextBoxName.Size = new System.Drawing.Size(251, 43);
            this.TextBoxName.TabIndex = 0;
            this.TextBoxName.Texts = "";
            this.TextBoxName.UnderlinedStyle = true;
            // 
            // Butt_Add
            // 
            this.Butt_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.Butt_Add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(136)))), ((int)(((byte)(250)))));
            this.Butt_Add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Butt_Add.BorderRadius = 20;
            this.Butt_Add.BorderSize = 0;
            this.Butt_Add.FlatAppearance.BorderSize = 0;
            this.Butt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Add.Font = new System.Drawing.Font("Plus Jakarta Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Butt_Add.Location = new System.Drawing.Point(1151, 546);
            this.Butt_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Butt_Add.Name = "Butt_Add";
            this.Butt_Add.Size = new System.Drawing.Size(207, 50);
            this.Butt_Add.TabIndex = 9;
            this.Butt_Add.Text = "Добавить ";
            this.Butt_Add.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Butt_Add.UseVisualStyleBackColor = false;
            this.Butt_Add.Click += new System.EventHandler(this.Butt_Add_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Clean);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Location = new System.Drawing.Point(172, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 74);
            this.panel1.TabIndex = 8;
            // 
            // Clean
            // 
            this.Clean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Clean.BackgroundImage")));
            this.Clean.Location = new System.Drawing.Point(791, 15);
            this.Clean.Margin = new System.Windows.Forms.Padding(4);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(53, 49);
            this.Clean.TabIndex = 2;
            this.Clean.TabStop = false;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(998, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Refresh
            // 
            this.Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.Image")));
            this.Refresh.Location = new System.Drawing.Point(862, 15);
            this.Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(53, 49);
            this.Refresh.TabIndex = 0;
            this.Refresh.TabStop = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // DataGridPlanned
            // 
            this.DataGridPlanned.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(77)))), ((int)(((byte)(150)))));
            this.DataGridPlanned.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridPlanned.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(77)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Plus Jakarta Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPlanned.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridPlanned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(77)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Plus Jakarta Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridPlanned.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridPlanned.EnableHeadersVisualStyles = false;
            this.DataGridPlanned.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(125)))), ((int)(((byte)(179)))));
            this.DataGridPlanned.Location = new System.Drawing.Point(172, 84);
            this.DataGridPlanned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridPlanned.Name = "DataGridPlanned";
            this.DataGridPlanned.ReadOnly = true;
            this.DataGridPlanned.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(77)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Plus Jakarta Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(55)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPlanned.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridPlanned.RowHeadersWidth = 51;
            this.DataGridPlanned.RowTemplate.Height = 24;
            this.DataGridPlanned.Size = new System.Drawing.Size(1213, 412);
            this.DataGridPlanned.TabIndex = 7;
            this.DataGridPlanned.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPlanned_CellClick);
            this.DataGridPlanned.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPlanned_CellContentDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PagePlanned);
            this.tabControl1.Controls.Add(this.PageViewed);
            this.tabControl1.Controls.Add(this.Close);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(402, 40);
            this.tabControl1.Location = new System.Drawing.Point(-7, -2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1613, 994);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(4, 44);
            this.Close.Margin = new System.Windows.Forms.Padding(4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(1605, 946);
            this.Close.TabIndex = 2;
            this.Close.Text = "Закончить ссесию";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Film List";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PageViewed.ResumeLayout(false);
            this.PageViewed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clean_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewed)).EndInit();
            this.PagePlanned.ResumeLayout(false);
            this.PagePlanned.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPlanned)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabPage PageViewed;
        private GoodButton Butt_Del_View;
        private GoodButton Butt_Rating;
        private Label label8;
        private Panel panel4;
        private GoodControls.GoodTextBox TextBoxRating;
        private Label label15;
        private Label label9;
        private GoodControls.GoodTextBox TextBoxCount2_View;
        private GoodControls.GoodTextBox TextBoxLink_View;
        private Label label10;
        private Label label11;
        private GoodControls.GoodTextBox TextBoxData_View;
        private Label label12;
        private GoodControls.GoodTextBox TextBoxDuration_View;
        private Label label13;
        private GoodControls.GoodTextBox TextBoxCount1_View;
        private Label label14;
        private GoodControls.GoodTextBox TextBoxName_View;
        private Panel panel3;
        private PictureBox Clean_View;
        private TextBox textBox2;
        private PictureBox Refresh_View;
        private DataGridView DataGridViewed;
        private TabPage PagePlanned;
        private GoodButton Butt_Transfer;
        private GoodButton Butt_Edit;
        private GoodButton Butt_Del;
        private Label label1;
        private Panel panel2;
        private Label label7;
        private GoodControls.GoodTextBox TextBoxCount2;
        private GoodControls.GoodTextBox TextBoxLink;
        private Label label6;
        private Label label5;
        private GoodControls.GoodTextBox TextBoxData;
        private Label label4;
        private GoodControls.GoodTextBox TextBoxDuration;
        private Label label3;
        private GoodControls.GoodTextBox TextBoxCount1;
        private Label label2;
        private GoodControls.GoodTextBox TextBoxName;
        private GoodButton Butt_Add;
        private Panel panel1;
        private PictureBox Clean;
        private TextBox textBox1;
        private PictureBox Refresh;
        public DataGridView DataGridPlanned;
        private TabControl tabControl1;
        private TabPage Close;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}


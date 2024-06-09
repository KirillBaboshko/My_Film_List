namespace My_Film_List
{
    partial class SignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignForm));
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxOpen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.goodTextBoxPassword = new My_Film_List.GoodControls.GoodTextBox();
            this.goodTextBoxLogin = new My_Film_List.GoodControls.GoodTextBox();
            this.SignButt = new My_Film_List.GoodButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(100, 204);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(94, 25);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Пароль :";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(113, 158);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(81, 25);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин :";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(390, 204);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(39, 38);
            this.pictureBoxClose.TabIndex = 5;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Visible = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxOpen
            // 
            this.pictureBoxOpen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOpen.Image")));
            this.pictureBoxOpen.Location = new System.Drawing.Point(390, 204);
            this.pictureBoxOpen.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxOpen.Name = "pictureBoxOpen";
            this.pictureBoxOpen.Size = new System.Drawing.Size(39, 38);
            this.pictureBoxOpen.TabIndex = 6;
            this.pictureBoxOpen.TabStop = false;
            this.pictureBoxOpen.Click += new System.EventHandler(this.pictureBoxOpen_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxDelete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(138, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 103);
            this.panel1.TabIndex = 7;
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDelete.Image")));
            this.pictureBoxDelete.Location = new System.Drawing.Point(348, 14);
            this.pictureBoxDelete.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(64, 65);
            this.pictureBoxDelete.TabIndex = 1;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регестрация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 103);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // goodTextBoxPassword
            // 
            this.goodTextBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.goodTextBoxPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.goodTextBoxPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.goodTextBoxPassword.BorderSize = 2;
            this.goodTextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodTextBoxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.goodTextBoxPassword.Location = new System.Drawing.Point(198, 204);
            this.goodTextBoxPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.goodTextBoxPassword.MaxLength = 50;
            this.goodTextBoxPassword.Multiline = false;
            this.goodTextBoxPassword.Name = "goodTextBoxPassword";
            this.goodTextBoxPassword.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.goodTextBoxPassword.PasswordChar = true;
            this.goodTextBoxPassword.Size = new System.Drawing.Size(188, 29);
            this.goodTextBoxPassword.TabIndex = 4;
            this.goodTextBoxPassword.Texts = "";
            this.goodTextBoxPassword.UnderlinedStyle = false;
            // 
            // goodTextBoxLogin
            // 
            this.goodTextBoxLogin.BackColor = System.Drawing.SystemColors.Window;
            this.goodTextBoxLogin.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.goodTextBoxLogin.BorderFocusColor = System.Drawing.Color.HotPink;
            this.goodTextBoxLogin.BorderSize = 2;
            this.goodTextBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodTextBoxLogin.ForeColor = System.Drawing.Color.DimGray;
            this.goodTextBoxLogin.Location = new System.Drawing.Point(198, 158);
            this.goodTextBoxLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.goodTextBoxLogin.MaxLength = 50;
            this.goodTextBoxLogin.Multiline = false;
            this.goodTextBoxLogin.Name = "goodTextBoxLogin";
            this.goodTextBoxLogin.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.goodTextBoxLogin.PasswordChar = false;
            this.goodTextBoxLogin.Size = new System.Drawing.Size(188, 29);
            this.goodTextBoxLogin.TabIndex = 3;
            this.goodTextBoxLogin.Texts = "";
            this.goodTextBoxLogin.UnderlinedStyle = false;
            // 
            // SignButt
            // 
            this.SignButt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignButt.BackColor = System.Drawing.Color.Lavender;
            this.SignButt.BackgroundColor = System.Drawing.Color.Lavender;
            this.SignButt.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SignButt.BorderRadius = 16;
            this.SignButt.BorderSize = 2;
            this.SignButt.FlatAppearance.BorderSize = 0;
            this.SignButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignButt.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignButt.ForeColor = System.Drawing.Color.MediumOrchid;
            this.SignButt.Location = new System.Drawing.Point(210, 262);
            this.SignButt.Margin = new System.Windows.Forms.Padding(2);
            this.SignButt.Name = "SignButt";
            this.SignButt.Size = new System.Drawing.Size(168, 51);
            this.SignButt.TabIndex = 0;
            this.SignButt.Text = "Зарегистрироваться";
            this.SignButt.TextColor = System.Drawing.Color.MediumOrchid;
            this.SignButt.UseVisualStyleBackColor = false;
            this.SignButt.Click += new System.EventHandler(this.SignButt_Click);
            // 
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxOpen);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.goodTextBoxPassword);
            this.Controls.Add(this.goodTextBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.SignButt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignForm";
            this.Text = "Регестрация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GoodButton SignButt;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private GoodControls.GoodTextBox goodTextBoxLogin;
        private GoodControls.GoodTextBox goodTextBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace Client
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ShowProjectInfo = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.ShowProfitAbility = new System.Windows.Forms.Button();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.btnGetProfitAbility = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SendEmail = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFIO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // ShowProjectInfo
            // 
            this.ShowProjectInfo.Location = new System.Drawing.Point(250, 6);
            this.ShowProjectInfo.Name = "ShowProjectInfo";
            this.ShowProjectInfo.Size = new System.Drawing.Size(192, 36);
            this.ShowProjectInfo.TabIndex = 1;
            this.ShowProjectInfo.Text = "Показать информацию";
            this.ShowProjectInfo.UseVisualStyleBackColor = true;
            this.ShowProjectInfo.Click += new System.EventHandler(this.ShowProjectInfo_Click);
            // 
            // Connect
            // 
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Connect.Location = new System.Drawing.Point(553, 12);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(97, 37);
            this.Connect.TabIndex = 2;
            this.Connect.Text = "Вход";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(120, 12);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(427, 36);
            this.textBoxName.TabIndex = 3;
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBox.Location = new System.Drawing.Point(6, 63);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(622, 259);
            this.outputBox.TabIndex = 5;
            // 
            // ShowProfitAbility
            // 
            this.ShowProfitAbility.Location = new System.Drawing.Point(448, 6);
            this.ShowProfitAbility.Name = "ShowProfitAbility";
            this.ShowProfitAbility.Size = new System.Drawing.Size(180, 36);
            this.ShowProfitAbility.TabIndex = 6;
            this.ShowProfitAbility.Text = "Рентабельность";
            this.ShowProfitAbility.UseVisualStyleBackColor = true;
            this.ShowProfitAbility.Click += new System.EventHandler(this.ShowProfitAbility_Click);
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(104, 14);
            this.txtProfit.Multiline = true;
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(230, 32);
            this.txtProfit.TabIndex = 7;
            // 
            // txtExpense
            // 
            this.txtExpense.Location = new System.Drawing.Point(104, 65);
            this.txtExpense.Multiline = true;
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.Size = new System.Drawing.Size(230, 36);
            this.txtExpense.TabIndex = 8;
            // 
            // btnGetProfitAbility
            // 
            this.btnGetProfitAbility.Location = new System.Drawing.Point(356, 14);
            this.btnGetProfitAbility.Name = "btnGetProfitAbility";
            this.btnGetProfitAbility.Size = new System.Drawing.Size(175, 32);
            this.btnGetProfitAbility.TabIndex = 9;
            this.btnGetProfitAbility.Text = "Добавить";
            this.btnGetProfitAbility.UseVisualStyleBackColor = true;
            this.btnGetProfitAbility.Click += new System.EventHandler(this.btnGetProfitAbility_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Доход";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Затраты";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(642, 357);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ShowProfitAbility);
            this.tabPage1.Controls.Add(this.outputBox);
            this.tabPage1.Controls.Add(this.ShowProjectInfo);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Анализ рентабельности проекта";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGetProfitAbility);
            this.tabPage2.Controls.Add(this.txtExpense);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtProfit);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(634, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ввод данных";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SendEmail);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtComment);
            this.tabPage3.Controls.Add(this.txtEmail);
            this.tabPage3.Controls.Add(this.txtFIO);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(634, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отправка на почту";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SendEmail
            // 
            this.SendEmail.Location = new System.Drawing.Point(471, 266);
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.Size = new System.Drawing.Size(143, 38);
            this.SendEmail.TabIndex = 6;
            this.SendEmail.Text = "Отправить";
            this.SendEmail.UseVisualStyleBackColor = true;
            this.SendEmail.Click += new System.EventHandler(this.SendEmail_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Сводка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "ФИО";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(104, 112);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(510, 147);
            this.txtComment.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(104, 65);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(510, 39);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtFIO
            // 
            this.txtFIO.Location = new System.Drawing.Point(104, 18);
            this.txtFIO.Multiline = true;
            this.txtFIO.Name = "txtFIO";
            this.txtFIO.Size = new System.Drawing.Size(510, 39);
            this.txtFIO.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Пароль";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(120, 68);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(427, 34);
            this.txtPassword.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 486);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Учет рентабельности IT-проектов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ShowProjectInfo;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button ShowProfitAbility;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.Button btnGetProfitAbility;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button SendEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFIO;
    }
}


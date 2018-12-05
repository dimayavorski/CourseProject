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
            this.messageLabel = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.ShowProfitAbility = new System.Windows.Forms.Button();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.btnGetProfitAbility = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // ShowProjectInfo
            // 
            this.ShowProjectInfo.Location = new System.Drawing.Point(261, 67);
            this.ShowProjectInfo.Name = "ShowProjectInfo";
            this.ShowProjectInfo.Size = new System.Drawing.Size(172, 29);
            this.ShowProjectInfo.TabIndex = 1;
            this.ShowProjectInfo.Text = "Показать информацию";
            this.ShowProjectInfo.UseVisualStyleBackColor = true;
            this.ShowProjectInfo.Click += new System.EventHandler(this.ShowProjectInfo_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(667, 55);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 2;
            this.Connect.Text = "Conntect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(555, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(55, 146);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 17);
            this.messageLabel.TabIndex = 4;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(58, 232);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(327, 130);
            this.outputBox.TabIndex = 5;
            // 
            // ShowProfitAbility
            // 
            this.ShowProfitAbility.Location = new System.Drawing.Point(58, 190);
            this.ShowProfitAbility.Name = "ShowProfitAbility";
            this.ShowProfitAbility.Size = new System.Drawing.Size(180, 36);
            this.ShowProfitAbility.TabIndex = 6;
            this.ShowProfitAbility.Text = "Рентабельность";
            this.ShowProfitAbility.UseVisualStyleBackColor = true;
            this.ShowProfitAbility.Click += new System.EventHandler(this.ShowProfitAbility_Click);
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(615, 278);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(100, 22);
            this.txtProfit.TabIndex = 7;
            // 
            // txtExpense
            // 
            this.txtExpense.Location = new System.Drawing.Point(615, 319);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.Size = new System.Drawing.Size(100, 22);
            this.txtExpense.TabIndex = 8;
            // 
            // btnGetProfitAbility
            // 
            this.btnGetProfitAbility.Location = new System.Drawing.Point(615, 241);
            this.btnGetProfitAbility.Name = "btnGetProfitAbility";
            this.btnGetProfitAbility.Size = new System.Drawing.Size(100, 23);
            this.btnGetProfitAbility.TabIndex = 9;
            this.btnGetProfitAbility.Text = "Посчитать";
            this.btnGetProfitAbility.UseVisualStyleBackColor = true;
            this.btnGetProfitAbility.Click += new System.EventHandler(this.btnGetProfitAbility_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetProfitAbility);
            this.Controls.Add(this.txtExpense);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.ShowProfitAbility);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.ShowProjectInfo);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ShowProjectInfo;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button ShowProfitAbility;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.Button btnGetProfitAbility;
    }
}


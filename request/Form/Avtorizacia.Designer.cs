namespace request
{
    partial class Avtorizacia
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
            this.txtBxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnAvtorization = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.bttnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxLogin
            // 
            this.txtBxLogin.Location = new System.Drawing.Point(167, 123);
            this.txtBxLogin.Name = "txtBxLogin";
            this.txtBxLogin.Size = new System.Drawing.Size(100, 20);
            this.txtBxLogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // bttnAvtorization
            // 
            this.bttnAvtorization.Location = new System.Drawing.Point(177, 238);
            this.bttnAvtorization.Name = "bttnAvtorization";
            this.bttnAvtorization.Size = new System.Drawing.Size(75, 23);
            this.bttnAvtorization.TabIndex = 2;
            this.bttnAvtorization.Text = "Войти";
            this.bttnAvtorization.UseVisualStyleBackColor = true;
            this.bttnAvtorization.Click += new System.EventHandler(this.bttnAvtorization_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(167, 190);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '*';
            this.txtBxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBxPassword.TabIndex = 5;
            // 
            // bttnClose
            // 
            this.bttnClose.Location = new System.Drawing.Point(288, 288);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(75, 23);
            this.bttnClose.TabIndex = 6;
            this.bttnClose.Text = "Закрыть";
            this.bttnClose.UseVisualStyleBackColor = true;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // Avtorizacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 334);
            this.Controls.Add(this.bttnClose);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnAvtorization);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxLogin);
            this.MaximumSize = new System.Drawing.Size(400, 373);
            this.MinimumSize = new System.Drawing.Size(400, 373);
            this.Name = "Avtorizacia";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnAvtorization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Button bttnClose;
    }
}


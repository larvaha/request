namespace request
{
    partial class UserForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbBxEquip = new System.Windows.Forms.ComboBox();
            this.cmbBxIssue = new System.Windows.Forms.ComboBox();
            this.txtBxOpisanie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnAdded = new System.Windows.Forms.Button();
            this.bttnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(249, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // cmbBxEquip
            // 
            this.cmbBxEquip.FormattingEnabled = true;
            this.cmbBxEquip.Location = new System.Drawing.Point(249, 120);
            this.cmbBxEquip.Name = "cmbBxEquip";
            this.cmbBxEquip.Size = new System.Drawing.Size(200, 21);
            this.cmbBxEquip.TabIndex = 1;
            // 
            // cmbBxIssue
            // 
            this.cmbBxIssue.FormattingEnabled = true;
            this.cmbBxIssue.Location = new System.Drawing.Point(249, 173);
            this.cmbBxIssue.Name = "cmbBxIssue";
            this.cmbBxIssue.Size = new System.Drawing.Size(200, 21);
            this.cmbBxIssue.TabIndex = 2;
            // 
            // txtBxOpisanie
            // 
            this.txtBxOpisanie.Location = new System.Drawing.Point(249, 225);
            this.txtBxOpisanie.Multiline = true;
            this.txtBxOpisanie.Name = "txtBxOpisanie";
            this.txtBxOpisanie.Size = new System.Drawing.Size(200, 51);
            this.txtBxOpisanie.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип неисправности";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "тип оборудования";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Описаниее";
            // 
            // bttnAdded
            // 
            this.bttnAdded.Location = new System.Drawing.Point(295, 319);
            this.bttnAdded.Name = "bttnAdded";
            this.bttnAdded.Size = new System.Drawing.Size(75, 23);
            this.bttnAdded.TabIndex = 8;
            this.bttnAdded.Text = "отправить";
            this.bttnAdded.UseVisualStyleBackColor = true;
            this.bttnAdded.Click += new System.EventHandler(this.bttnAdded_Click);
            // 
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(460, 319);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(75, 23);
            this.bttnBack.TabIndex = 9;
            this.bttnBack.Text = "назад";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(245, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Заявка";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 377);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.bttnAdded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxOpisanie);
            this.Controls.Add(this.cmbBxIssue);
            this.Controls.Add(this.cmbBxEquip);
            this.Controls.Add(this.dateTimePicker1);
            this.MaximumSize = new System.Drawing.Size(582, 416);
            this.MinimumSize = new System.Drawing.Size(582, 416);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbBxEquip;
        private System.Windows.Forms.ComboBox cmbBxIssue;
        private System.Windows.Forms.TextBox txtBxOpisanie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnAdded;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Label label5;
    }
}
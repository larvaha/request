namespace request
{
    partial class ManagerForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbBxIsponitely = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnIspolnytel = new System.Windows.Forms.Button();
            this.bttnDate_End = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(858, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(761, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(761, 307);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(75, 23);
            this.bttnDelete.TabIndex = 2;
            this.bttnDelete.Text = "Удалить";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 320);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // cmbBxIsponitely
            // 
            this.cmbBxIsponitely.FormattingEnabled = true;
            this.cmbBxIsponitely.Location = new System.Drawing.Point(351, 319);
            this.cmbBxIsponitely.Name = "cmbBxIsponitely";
            this.cmbBxIsponitely.Size = new System.Drawing.Size(121, 21);
            this.cmbBxIsponitely.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата окончания ремонта\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Исполнитель";
            // 
            // bttnIspolnytel
            // 
            this.bttnIspolnytel.Location = new System.Drawing.Point(374, 355);
            this.bttnIspolnytel.Name = "bttnIspolnytel";
            this.bttnIspolnytel.Size = new System.Drawing.Size(75, 23);
            this.bttnIspolnytel.TabIndex = 7;
            this.bttnIspolnytel.Text = "Изменить";
            this.bttnIspolnytel.UseVisualStyleBackColor = true;
            this.bttnIspolnytel.Click += new System.EventHandler(this.bttnIspolnytel_Click);
            // 
            // bttnDate_End
            // 
            this.bttnDate_End.Location = new System.Drawing.Point(104, 355);
            this.bttnDate_End.Name = "bttnDate_End";
            this.bttnDate_End.Size = new System.Drawing.Size(75, 23);
            this.bttnDate_End.TabIndex = 8;
            this.bttnDate_End.Text = "Изменить";
            this.bttnDate_End.UseVisualStyleBackColor = true;
            this.bttnDate_End.Click += new System.EventHandler(this.bttnDate_End_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 406);
            this.Controls.Add(this.bttnDate_End);
            this.Controls.Add(this.bttnIspolnytel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxIsponitely);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(879, 445);
            this.MinimumSize = new System.Drawing.Size(879, 445);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbBxIsponitely;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnIspolnytel;
        private System.Windows.Forms.Button bttnDate_End;
    }
}
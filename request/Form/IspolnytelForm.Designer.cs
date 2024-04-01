namespace request
{
    partial class IspolnytelForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.cmbBxStatus = new System.Windows.Forms.ComboBox();
            this.txtBxOpisanye = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbBxIssue = new System.Windows.Forms.ComboBox();
            this.txtBxEquip = new System.Windows.Forms.TextBox();
            this.bttnDelet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 307);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(864, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(31, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbBxStatus
            // 
            this.cmbBxStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbBxStatus.FormattingEnabled = true;
            this.cmbBxStatus.Location = new System.Drawing.Point(31, 355);
            this.cmbBxStatus.Name = "cmbBxStatus";
            this.cmbBxStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbBxStatus.TabIndex = 3;
            // 
            // txtBxOpisanye
            // 
            this.txtBxOpisanye.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBxOpisanye.Location = new System.Drawing.Point(209, 339);
            this.txtBxOpisanye.Multiline = true;
            this.txtBxOpisanye.Name = "txtBxOpisanye";
            this.txtBxOpisanye.Size = new System.Drawing.Size(100, 51);
            this.txtBxOpisanye.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(198, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker1.Location = new System.Drawing.Point(393, 355);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.Location = new System.Drawing.Point(437, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "редактировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmbBxIssue
            // 
            this.cmbBxIssue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbBxIssue.FormattingEnabled = true;
            this.cmbBxIssue.Location = new System.Drawing.Point(818, 52);
            this.cmbBxIssue.Name = "cmbBxIssue";
            this.cmbBxIssue.Size = new System.Drawing.Size(121, 21);
            this.cmbBxIssue.TabIndex = 8;
            this.cmbBxIssue.SelectedIndexChanged += new System.EventHandler(this.cmbBxIssue_SelectedIndexChanged);
            // 
            // txtBxEquip
            // 
            this.txtBxEquip.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBxEquip.Location = new System.Drawing.Point(818, 145);
            this.txtBxEquip.Name = "txtBxEquip";
            this.txtBxEquip.Size = new System.Drawing.Size(121, 20);
            this.txtBxEquip.TabIndex = 9;
            this.txtBxEquip.TextChanged += new System.EventHandler(this.txtBxEquip_TextChanged);
            // 
            // bttnDelet
            // 
            this.bttnDelet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnDelet.Location = new System.Drawing.Point(864, 323);
            this.bttnDelet.Name = "bttnDelet";
            this.bttnDelet.Size = new System.Drawing.Size(75, 23);
            this.bttnDelet.TabIndex = 10;
            this.bttnDelet.Text = "Удалить";
            this.bttnDelet.UseVisualStyleBackColor = true;
            this.bttnDelet.Click += new System.EventHandler(this.bttnDelet_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(842, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Тип поломки";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(830, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Тип оборудования";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата Окончания ремонта";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Описание\r\n";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Статус";
            // 
            // IspolnytelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnDelet);
            this.Controls.Add(this.txtBxEquip);
            this.Controls.Add(this.cmbBxIssue);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtBxOpisanye);
            this.Controls.Add(this.cmbBxStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(967, 489);
            this.Name = "IspolnytelForm";
            this.Text = "IspolnytelForm";
            this.Load += new System.EventHandler(this.IspolnytelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbBxStatus;
        private System.Windows.Forms.TextBox txtBxOpisanye;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmbBxIssue;
        private System.Windows.Forms.TextBox txtBxEquip;
        private System.Windows.Forms.Button bttnDelet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
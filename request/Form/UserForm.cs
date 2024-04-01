
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace request
{
    public partial class UserForm : Form
    {
        private requestEntities1 dbContext;
        public UserForm()
        {
            InitializeComponent();
            dbContext = requestEntities1.GetContext();
        
        }

        

        private void UserForm_Load(object sender, EventArgs e)
        {
            var data = dbContext.Equipmnt.Select(x => x.EquipmntName).ToList();
            cmbBxEquip.DataSource = data;
            var data1 = dbContext.IssueType.Select(x => x.IssueTypeName).ToList();
            cmbBxIssue.DataSource = data1;
        }

        private void bttnAdded_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBxEquip.SelectedIndex == -1 || cmbBxIssue.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtBxOpisanie.Text))
                {
                    MessageBox.Show("Заполните все необходимые поля.");

                }
                else
                {
                    Request Addq = new Request();
                    Addq.date_added = dateTimePicker1.Value.Date;
                    Addq.equipmentId = cmbBxEquip.SelectedIndex + 1;
                    Addq.IssueTypeId = cmbBxIssue.SelectedIndex + 2;
                    Addq.Opisanie = txtBxOpisanie.Text;
                    Addq.ispolnitelId = null;
                    Addq.StatusId = 1;
                    Addq.date_end = null;
                    dbContext.Request.Add(Addq); 
                    dbContext.SaveChanges(); 
                    MessageBox.Show("Заявка добавленна");
                }
            }

            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            

        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            Avtorizacia avtorizacia = new Avtorizacia();
            avtorizacia.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace request
{
    public partial class ManagerForm : Form
    {
        private requestEntities1 dbContext;
        public ManagerForm()
        {
            InitializeComponent();
            dbContext = requestEntities1.GetContext();
            var Data = dbContext.Ispolnitel.Select(x => x.ispolnitelName).ToList();
            cmbBxIsponitely.DataSource = Data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Avtorizacia avtorizacia = new Avtorizacia();
            avtorizacia.Show();
            this.Close();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            var query = from request in dbContext.Request
                        join equipmnt in dbContext.Equipmnt on request.equipmentId equals equipmnt.id_Equipmnt into equipmntGroup
                        from equipmnt in equipmntGroup.DefaultIfEmpty()
                        join issueType in dbContext.IssueType on request.IssueTypeId equals issueType.id_IssueType into issueTypeGroup
                        from issueType in issueTypeGroup.DefaultIfEmpty()
                        join status in dbContext.Status on request.StatusId equals status.id_status into statusGroup
                        from status in statusGroup.DefaultIfEmpty()
                        join ispolnitel in dbContext.Ispolnitel on request.ispolnitelId equals ispolnitel.Id_ispolnitel into ispolnitelGroup
                        from ispolnitel in ispolnitelGroup.DefaultIfEmpty()
                        select new
                        {
                            ID = request.id_Request,
                            Дата_Добавления = request.date_added,
                            Оборудование = equipmnt != null ? equipmnt.EquipmntName : null,
                            Тип_Проблемы = issueType != null ? issueType.IssueTypeName : null,
                            Описание = request.Opisanie,
                            Исполнитель = ispolnitel != null ? ispolnitel.ispolnitelName : null,
                            Статус = status != null ? status.StatusName : null,
                            Дата_Окончания = request.date_end
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                object idValue = selectedRow.Cells["ID"].Value;

                int requestId = Convert.ToInt32(idValue);

                var requestToDelete = dbContext.Request.FirstOrDefault(r => r.id_Request == requestId);

                if (requestToDelete != null)
                {
                    // Удалит из базы 
                    dbContext.Request.Remove(requestToDelete);
                    dbContext.SaveChanges();
                    ManagerForm_Load(this, EventArgs.Empty);
                    MessageBox.Show("Запись успешно удалена.");

                }


                else
                {
                    MessageBox.Show("Ни одна строка не выбрана.");
                }
            }
        }

        private void bttnIspolnytel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                object idValue = selectedRow.Cells["ID"].Value;

                int requestId = Convert.ToInt32(idValue);

                var requestToUpdate = dbContext.Request.FirstOrDefault(r => r.id_Request == requestId);

                int NewIspontyle = cmbBxIsponitely.SelectedIndex + 1 ;

                requestToUpdate.ispolnitelId = NewIspontyle;

                try
                {

                    dbContext.SaveChanges();

                    ManagerForm_Load(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
                }
            }


            else
            {
                MessageBox.Show("Ни одна строка не выбрана.");
            }
        }

        private void bttnDate_End_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                object idValue = selectedRow.Cells["ID"].Value;

                int requestId = Convert.ToInt32(idValue);

                var requestToUpdate = dbContext.Request.FirstOrDefault(r => r.id_Request == requestId);

                DateTime NewDateEnd = dateTimePicker1.Value.Date;

                requestToUpdate.date_end = NewDateEnd;

                try
                {

                    dbContext.SaveChanges();

                    ManagerForm_Load(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
                }
            }


            else
            {
                MessageBox.Show("Ни одна строка не выбрана.");
            }
        }

    }
}

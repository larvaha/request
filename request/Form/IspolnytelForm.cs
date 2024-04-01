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
    public partial class IspolnytelForm : Form
    {
        private requestEntities1 dbContext;




        public IspolnytelForm()
        {
            InitializeComponent();


            dbContext = requestEntities1.GetContext();
            //var query = from request in dbContext.Request
            //            join equipmnt in dbContext.Equipmnt on request.equipmentId equals equipmnt.id_Equipmnt
            //            join issueType in dbContext.IssueType on request.IssueTypeId equals issueType.id_IssueType
            //            join status in dbContext.Status on request.StatusId equals status.id_status
            //            join ispolnitel in dbContext.Ispolnitel on request.ispolnitelId equals ispolnitel.Id_ispolnitel
            //            select new
            //            {
            //                ID = request.id_Request,
            //                Дата_Добавления = request.date_added,
            //                Оборудование = equipmnt.EquipmntName,
            //                Тип_Проблемы = issueType.IssueTypeName,
            //                Описание = request.Opisanie,
            //                Исполнитель = ispolnitel.ispolnitelName,
            //                Статус = status.StatusName,
            //                Дата_Окончания = request.date_end
            //            };
            //var query = from request in dbContext.Request
            //            join equipmnt in dbContext.Equipmnt on request.equipmentId equals equipmnt.id_Equipmnt into equipmntGroup
            //            from equipmnt in equipmntGroup.DefaultIfEmpty()
            //            join issueType in dbContext.IssueType on request.IssueTypeId equals issueType.id_IssueType into issueTypeGroup
            //            from issueType in issueTypeGroup.DefaultIfEmpty()
            //            join status in dbContext.Status on request.StatusId equals status.id_status into statusGroup
            //            from status in statusGroup.DefaultIfEmpty()
            //            join ispolnitel in dbContext.Ispolnitel on request.ispolnitelId equals ispolnitel.Id_ispolnitel into ispolnitelGroup
            //            from ispolnitel in ispolnitelGroup.DefaultIfEmpty()
            //            select new
            //            {
            //                ID = request.id_Request,
            //                Дата_Добавления = request.date_added,
            //                Оборудование = equipmnt != null ? equipmnt.EquipmntName : null,
            //                Тип_Проблемы = issueType != null ? issueType.IssueTypeName : null,
            //                Описание = request.Opisanie,
            //                Исполнитель = ispolnitel != null ? ispolnitel.ispolnitelName : null,
            //                Статус = status != null ? status.StatusName : null,
            //                Дата_Окончания = request.date_end
            //            };
            //var query = from request in dbContext.Request
            //            join equipmnt in dbContext.Equipmnt on request.equipmentId equals equipmnt.id_Equipmnt into equipmntGroup
            //            from equipmnt in equipmntGroup.DefaultIfEmpty()
            //            join issueType in dbContext.IssueType on request.IssueTypeId equals issueType.id_IssueType into issueTypeGroup
            //            from issueType in issueTypeGroup.DefaultIfEmpty()
            //            join status in dbContext.Status on request.StatusId equals status.id_status into statusGroup
            //            from status in statusGroup.DefaultIfEmpty()
            //            join ispolnitel in dbContext.Ispolnitel on request.ispolnitelId equals ispolnitel.Id_ispolnitel into ispolnitelGroup
            //            from ispolnitel in ispolnitelGroup.DefaultIfEmpty()
            //            where ispolnitel != null && ispolnitel.Id_ispolnitel == GlobalVariables.IdIsponitela
            //            select new
            //            {
            //                ID = request.id_Request,
            //                Дата_Добавления = request.date_added,
            //                Оборудование = equipmnt != null ? equipmnt.EquipmntName : null,
            //                Тип_Проблемы = issueType != null ? issueType.IssueTypeName : null,
            //                Описание = request.Opisanie,
            //                Исполнитель = ispolnitel != null ? ispolnitel.ispolnitelName : null,
            //                Статус = status != null ? status.StatusName : null,
            //                Дата_Окончания = request.date_end
            //            };
            //dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Avtorizacia avtorizacia = new Avtorizacia();
            avtorizacia.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получаем выбранную строку 
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Получаем значение ячейки с нужным ID 
                object idValue = selectedRow.Cells["ID"].Value;

                int requestId = Convert.ToInt32(idValue);

                var requestToUpdate = dbContext.Request.FirstOrDefault(r => r.id_Request == requestId);

                int NewStatusId = cmbBxStatus.SelectedIndex + 1;

                requestToUpdate.StatusId = NewStatusId;

                try
                {
                    // Сохран в базе данных
                    dbContext.SaveChanges();

                    IspolnytelForm_Load(this, EventArgs.Empty);
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

        private void IspolnytelForm_Load(object sender, EventArgs e)
        {
            var data = dbContext.Status.Select(x => x.StatusName).ToList();
            cmbBxStatus.DataSource = data;
            var data2 = dbContext.IssueType.Select(x => x.IssueTypeName).ToList();
            cmbBxIssue.DataSource = data2;


            var query = from request in dbContext.Request
                        join equipmnt in dbContext.Equipmnt on request.equipmentId equals equipmnt.id_Equipmnt into equipmntGroup
                        from equipmnt in equipmntGroup.DefaultIfEmpty()
                        join issueType in dbContext.IssueType on request.IssueTypeId equals issueType.id_IssueType into issueTypeGroup
                        from issueType in issueTypeGroup.DefaultIfEmpty()
                        join status in dbContext.Status on request.StatusId equals status.id_status into statusGroup
                        from status in statusGroup.DefaultIfEmpty()
                        join ispolnitel in dbContext.Ispolnitel on request.ispolnitelId equals ispolnitel.Id_ispolnitel into ispolnitelGroup
                        from ispolnitel in ispolnitelGroup.DefaultIfEmpty()
                        where ispolnitel != null && ispolnitel.Id_ispolnitel == GlobalVariables.IdIsponitela
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                
                object idValue = selectedRow.Cells["ID"].Value;

                int requestId = Convert.ToInt32(idValue);

                var requestToUpdate = dbContext.Request.FirstOrDefault(r => r.id_Request == requestId);

                string NewOpisanie = txtBxOpisanye.Text;

                requestToUpdate.Opisanie = NewOpisanie;

                try
                {
                    
                    dbContext.SaveChanges();

                    IspolnytelForm_Load(this, EventArgs.Empty);
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

        private void button4_Click(object sender, EventArgs e)
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

                    IspolnytelForm_Load(this, EventArgs.Empty);
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

        private void cmbBxIssue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIssueType = cmbBxIssue.SelectedItem.ToString();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Тип_Проблемы"].Value != null && row.Cells["Тип_Проблемы"].Value.ToString() == selectedIssueType)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow; 
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White; 
                }
            }
        }

        private void txtBxEquip_TextChanged(object sender, EventArgs e)
        {
            string equipmentNameToSort = txtBxEquip.Text.Trim();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Оборудование"].Value != null && row.Cells["Оборудование"].Value.ToString() == equipmentNameToSort)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow; 
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White; 
                }
            }

        }

        private void bttnDelet_Click(object sender, EventArgs e)
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
                    IspolnytelForm_Load(this, EventArgs.Empty);
                    MessageBox.Show("Запись успешно удалена.");

                }


                else
                {
                    MessageBox.Show("Ни одна строка не выбрана.");
                }
            }
        }
    }
}


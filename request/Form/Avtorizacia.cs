
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
    public partial class Avtorizacia : Form
    {
        public Avtorizacia()
        {
            InitializeComponent();
        }

        private void bttnAvtorization_Click(object sender, EventArgs e)
        {
            try
            {
                List<User> user = requestEntities1.GetContext().User.ToList();
                User u = user.FirstOrDefault(p => p.Login == txtBxLogin.Text && p.password == txtBxPassword.Text);

                if( u != null)
                {
                    GlobalVariables.IdIsponitela = u.Ispolnitel_id;
                    int roleId = u.RoleID;
                    
                    if ( roleId  == 1 )
                    {
                        UserForm userForm = new UserForm();
                        userForm.Show();
                        this.Hide();
                    }
                    else if( roleId == 2)
                    {
                        IspolnytelForm ispolnytelForm = new IspolnytelForm();
                        ispolnytelForm.Show();
                        this.Hide();
                    }
                    else if( roleId == 3)
                    {
                        ManagerForm managerForm = new ManagerForm();
                        managerForm.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

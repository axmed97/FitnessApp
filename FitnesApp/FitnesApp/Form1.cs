using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnesApp.Model;
using static FitnesApp.Extension;

namespace FitnesApp
{
    public partial class Form1 : Form
    {
        private readonly FitnesAppEntities _context;
        public Form1()
        {
            InitializeComponent();
            _context = new FitnesAppEntities();
        }

        private void CheckRemember()
        {
            if (checkRemember.Checked)
            {
                Properties.Settings.Default.Username = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.DefaultCheck = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.DefaultCheck = false;
                Properties.Settings.Default.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DefaultCheck)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
                checkRemember.Checked = true;
            }
            
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string[] UserInfo = { txtPassword.Text, txtUsername.Text };
            if (CheckAllField(UserInfo, string.Empty))
            {
                ShowMessage("Fill all inputs", "error");
                return;
            }
            User user = _context.Users.FirstOrDefault(u => u.Username == txtUsername.Text);
            if (user != null)
            {
                if (CheckHash(user.Password, txtPassword.Text))
                {
                    this.Visible = false;
                    CheckRemember();
                    switch (user.Role_Id)
                    {
                        case 1:
                            AdminForm adminForm = new AdminForm();
                            adminForm.ShowDialog();
                            break;
                        case 2:
                            WorkerForm workerForm = new WorkerForm();
                            workerForm.ShowDialog();
                            break;
                        default:
                            break;
                    }
                    this.Close();
                }
                else
                {
                    ShowMessage("Your password or username is wrong", "error");
                }
            }
            else
            {
                ShowMessage("Your password or username is wrong", "error");
            }
        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}

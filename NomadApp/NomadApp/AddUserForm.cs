using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NomadApp.DataAcces;
using NomadApp.Models;

namespace NomadApp
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            string userName=string.Empty;
            int zero = 0;

            if (UserTextBox.Text.Length==zero)
            {
                MessageBox.Show("Введите ваше полное имя");
                return;
            }
            else if (IsUserSubs(UserTextBox.Text))
            {
                MessageBox.Show("Подписка уже имеется!");
                return;
            }
            else
            {
                userName = UserTextBox.Text;
            }
        }

        private bool IsUserSubs(string name)
        {
            using (var context= new DataContext())
            {
                foreach (var user in context.Users)
                {
                    if (user.Fullname == name) return true;
                }
            }
                return false;
        }
    }
}

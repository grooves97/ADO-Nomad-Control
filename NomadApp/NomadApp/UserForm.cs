using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NomadApp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void SubscribeButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void UnSubscribeButton_Click(object sender, EventArgs e)
        {
            DeleteUserFormcs deleteUserFormcs = new DeleteUserFormcs();
            deleteUserFormcs.Show();
        }

        private void CommitButton_Click(object sender, EventArgs e)
        {
            CommitUserForm commitUserForm = new CommitUserForm();
            commitUserForm.Show();
        }
    }
}

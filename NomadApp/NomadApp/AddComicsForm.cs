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
    public partial class AddComicsForm : Form
    {
        public AddComicsForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void AddComicsButton_Click(object sender, EventArgs e)
        {
            string comicsName =string.Empty;
            int zero = 0;
            if (NameComicsBox.Text.Length == zero)
            {
                MessageBox.Show("Введите название комикса");
                return;
            }
            else if (Duplicates(NameComicsBox.Text))
            {
                MessageBox.Show("Журнал уже есть!");
                return;
            }
            else
            {
                comicsName += NameComicsBox.Text;
            }
            using (var context = new DataContext())
            {
                var comics = new Comics
                {
                    Name = comicsName,
                    AddDate = DateTime.Now
                };

                foreach (var user in context.Users)
                {
                    var order = new Order
                    {
                        ComicsId = comics.Id,
                        UserId = user.Id,
                        IsDelivered = false
                    };
                    context.Orders.Add(order);
                }
                context.Comics.Add(comics);
                context.SaveChanges();
            }
            MessageBox.Show("Журнал успешно добавлен!");
        }

        private bool Duplicates(string name)
        {
            using (var context = new DataContext())
            {
                foreach (var item in context.Comics)
                {
                    if (item.Name == name) return true;
                }
            }

                return false;
        }
    }
}

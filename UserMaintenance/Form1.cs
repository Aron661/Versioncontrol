using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();  //User.cs ->namespace UserMaintenance.Entities

        public Form1()
        {
            InitializeComponent();
            /*
            labelLastName.Text = Resource1.LastName;
            labelFirstname.Text = Resource1.FirstName;
            */
            labelFullName.Text = Resource1.FullName;

            buttonAdd.Text = Resource1.Add;
            buttonSave.Text = Resource1.Fájlbaírás;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var u = new User();
            /* {
                 LastName = textBoxLastName.Text,
                 FirstName = textBoxFirstname.Text
             };
            */
            u.FullName = textBoxFullName.Text;
            users.Add(u);

            //

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter stw = new StreamWriter(sfd.FileName))
                {
                    foreach (User item in users)
                    {
                        stw.WriteLine(item.ID + ";" + item.FullName);
                    }
                }
            }
        }
    }
}

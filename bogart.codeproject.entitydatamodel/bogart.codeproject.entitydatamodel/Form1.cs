using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gunter.roy.codeproject.entitydatamodel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codeprojectEntities db = new codeprojectEntities();
            var commands = from cmd in db.Commands
                           select new
                           {
                               Name = cmd.Command1
                           };
            dataGridView1.DataSource = commands.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox1.Text == "")
                {
                    return;
                }

                codeprojectEntities db = new codeprojectEntities();
                User user = new User();
                user.Name = textBox1.Text;
                db.Users.Add(user);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codeprojectEntities db = new codeprojectEntities();
            var commands = from cmd in db.Users
                           select new
                           {
                               Name = cmd.Name
                           };
            dataGridView1.DataSource = commands.ToList();
        }
    }
}

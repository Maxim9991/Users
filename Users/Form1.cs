using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users.Classes;

namespace Users
{
    public partial class Form1 : Form
    {
        MyContext context = new MyContext();
        public Form1()
        {
            InitializeComponent();
            MyContext context = new MyContext();
            Seeder.SeedDatabase(context);
            comboBox1.SelectedIndex = 0;
            btnAction.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowDataBase();
        }

        private void ShowDataBase()
        {
            DGV_AspNetRoles.Rows.Clear();
            foreach (var item in context.AspNetRoles)
            {
                object[] row = {
                    $"{item.Id}",
                    $"{item.Name}",
                    $"{item.NormalizedName}",
                    $"{item.ConcurrencyStamp}"
                };
                DGV_AspNetRoles.Rows.Add(row);
            }

            DGV_AspNetUsers.Rows.Clear();
            foreach (var item in context.AspNetUsers)
            {
                object[] row = {
                    $"{item.Id}",
                    $"{item.UserName}",
                    $"{item.NormalizedUserName}",
                    $"{item.Email}",
                    $"{item.PhoneNumber}"
                };
                DGV_AspNetUsers.Rows.Add(row);
            }

            DGV_AspNetUserRoles.Rows.Clear();
            foreach (var item in context.AspNetUserRoles)
            {
                object[] row = {
                    $"{item.UserId}",
                    $"{item.RoleId}"
                };
                DGV_AspNetUserRoles.Rows.Add(row);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DGV_AspNetRoles.Visible = true;
                DGV_AspNetUsers.Visible = false;
                DGV_AspNetUserRoles.Visible = false;

                cBoxAdd.Checked = false;
                cBoxDel.Checked = false;
                cBoxEdit.Checked = false;
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                lbl4.Visible = false;
                lbl5.Visible = false;

                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;

                btnAction.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DGV_AspNetRoles.Visible = false;
                DGV_AspNetUsers.Visible = true;
                DGV_AspNetUserRoles.Visible = false;

                cBoxAdd.Checked = false;
                cBoxDel.Checked = false;
                cBoxEdit.Checked = false;
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                lbl4.Visible = false;
                lbl5.Visible = false;

                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;

                btnAction.Visible = false;
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                DGV_AspNetRoles.Visible = false;
                DGV_AspNetUsers.Visible = false;
                DGV_AspNetUserRoles.Visible = true;

                cBoxAdd.Checked = false;
                cBoxDel.Checked = false;
                cBoxEdit.Checked = false;
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                lbl4.Visible = false;
                lbl5.Visible = false;

                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;

                btnAction.Visible = false;
            }
        }

        private void cBoxAdd_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxAdd.Checked)
            {
                cBoxDel.Checked = false;
                cBoxEdit.Checked = false;
                if (comboBox1.SelectedIndex == 0)
                {
                    btnAction.Visible = true;
                    btnAction.Text = "Додати";
                    lbl1.Visible = true;
                    lbl1.Text = "Name";
                    lbl2.Text = "Normalized Name";
                    lbl2.Visible = true;
                    lbl3.Text = "Concurrency Stamp";
                    lbl3.Visible = true;
                    lbl4.Visible = false;
                    lbl5.Visible = false;

                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = false;
                    textBox5.Visible = false;

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    btnAction.Visible = true;
                    btnAction.Text = "Додати";
                    lbl1.Text = "User Name";
                    lbl1.Visible = true;
                    lbl2.Text = "Normalized User Name";
                    lbl2.Visible = true;
                    lbl3.Text = "Email";
                    lbl3.Visible = true;
                    lbl4.Text = "Phone Number";
                    lbl4.Visible = true;
                    lbl5.Visible = false;

                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = false;

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    btnAction.Visible = true;
                    btnAction.Text = "Додати";
                    lbl1.Visible = true;
                    lbl1.Text = "UserId";
                    lbl2.Visible = true;
                    lbl2.Text = "RolesId";
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;

                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;

                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            else
            {
                btnAction.Visible = false;
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                lbl4.Visible = false;
                lbl5.Visible = false;

                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
            }
        }

        private void cBoxDel_CheckedChanged(object sender, EventArgs e)
        { 
            if(cBoxDel.Checked)
            {
                cBoxAdd.Checked = false;
                cBoxEdit.Checked = false;
                if (comboBox1.SelectedIndex == 0)
                {
                    btnAction.Visible = true;
                    btnAction.Text = "Видалити";
                    lbl1.Visible = true;
                    lbl1.Text = "Id";
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;

                    textBox1.Visible = true;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;

                    textBox1.Text = "";
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    btnAction.Visible = true;
                    btnAction.Text = "Видалити";
                    lbl1.Visible = true;
                    lbl1.Text = "Id";
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;

                    textBox1.Visible = true;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;

                    textBox1.Text = "";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    btnAction.Visible = false;
                    lbl1.Visible = true;
                    lbl1.Text = "NOT AVAILABLE";
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;

                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                }
            }
            else
            {
                btnAction.Visible = false;
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                lbl4.Visible = false;
                lbl5.Visible = false;

                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
            }
        }

        private void cBoxEdit_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxEdit.Checked)
            {
                cBoxAdd.Checked = false;
                cBoxDel.Checked = false;
                if (comboBox1.SelectedIndex == 0)
                {
                    btnAction.Visible = true;
                    btnAction.Text = "Редагувати";
                    lbl1.Visible = true;
                    lbl1.Text = "Id";
                    lbl2.Visible = true;
                    lbl2.Text = "Name";
                    lbl3.Visible = true;
                    lbl3.Text = "Normalized Name";
                    lbl4.Visible = true;
                    lbl4.Text = "Concurrency Stamp";
                    lbl5.Visible = false;

                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = false;

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    btnAction.Visible = true;
                    btnAction.Text = "Редагувати";
                    lbl1.Visible = true;
                    lbl1.Text = "Id";
                    lbl2.Visible = true;
                    lbl2.Text = "User Name";
                    lbl3.Visible = true;
                    lbl3.Text = "Normalized User Name";
                    lbl4.Visible = true;
                    lbl4.Text = "Email";
                    lbl5.Visible = true;
                    lbl5.Text = "Phone Number";

                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    btnAction.Visible = false;
                    lbl1.Visible = true;
                    lbl1.Text = "NOT AVAILABLE";
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;

                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                }
            }
            else
            {
                btnAction.Visible = false;
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                lbl4.Visible = false;
                lbl5.Visible = false;

                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if(cBoxAdd.Checked)
                {
                    AspNetRoles aspNetRoles = new AspNetRoles();
                    aspNetRoles.Name = textBox1.Text;
                    aspNetRoles.NormalizedName = textBox2.Text;
                    aspNetRoles.ConcurrencyStamp = textBox3.Text;
                    context.AspNetRoles.Add(aspNetRoles);
                    context.SaveChanges();
                }
                else if(cBoxDel.Checked)
                {
                    int id = int.Parse(textBox1.Text);
                    AspNetRoles aspNetRoles = context.AspNetRoles.SingleOrDefault(x => x.Id == id);

                    if(aspNetRoles != null)
                    {
                        context.AspNetRoles.Remove(aspNetRoles);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show($"Id {id} не знайдено");
                    }
                }
                else if(cBoxEdit.Checked)
                {
                    int id = int.Parse(textBox1.Text);
                    AspNetRoles aspNetRoles = context.AspNetRoles.SingleOrDefault(x => x.Id == id);

                    if(aspNetRoles != null)
                    {
                        aspNetRoles.Name = textBox2.Text;
                        aspNetRoles.NormalizedName = textBox3.Text;
                        aspNetRoles.ConcurrencyStamp = textBox4.Text;
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show($"Id {id} не знайдено");
                    }
                }
                ShowDataBase();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                if (cBoxAdd.Checked)
                {
                    AspNetUsers aspNetUsers = new AspNetUsers();
                    aspNetUsers.UserName = textBox1.Text;
                    aspNetUsers.NormalizedUserName = textBox2.Text;
                    aspNetUsers.Email = textBox3.Text;
                    aspNetUsers.PhoneNumber = textBox4.Text;
                    context.AspNetUsers.Add(aspNetUsers);
                    context.SaveChanges();
                }
                else if (cBoxDel.Checked)
                {
                    int id = int.Parse(textBox1.Text);
                    AspNetUsers aspNetUsers = context.AspNetUsers.SingleOrDefault(x => x.Id == id);

                    if (aspNetUsers != null)
                    {
                        context.AspNetUsers.Remove(aspNetUsers);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show($"Id {id} не знайдено");
                    }
                }
                else if (cBoxEdit.Checked)
                {
                    int id = int.Parse(textBox1.Text);
                    AspNetUsers aspNetUsers = context.AspNetUsers.SingleOrDefault(x => x.Id == id);

                    if (aspNetUsers != null)
                    {
                        aspNetUsers.UserName = textBox2.Text;
                        aspNetUsers.NormalizedUserName = textBox3.Text;
                        aspNetUsers.Email = textBox4.Text;
                        aspNetUsers.PhoneNumber = textBox5.Text;
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show($"Id {id} не знайдено");
                    }
                }
                ShowDataBase();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if(cBoxAdd.Checked)
                {
                    int user = int.Parse(textBox1.Text);
                    int roles = int.Parse(textBox2.Text);
                    AspNetUserRoles aspNetUserRoles = new AspNetUserRoles();
                    aspNetUserRoles.UserId = user;
                    aspNetUserRoles.RoleId = roles;
                    context.AspNetUserRoles.Add(aspNetUserRoles);
                    context.SaveChanges();
                }
                ShowDataBase();
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}

﻿using Shop_Store_System.BusinesLogic;
using Shop_Store_System.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Store_System.Design_Interfaces
{
    public partial class formUsers : Form
    {
        public formUsers()
        {
            InitializeComponent();
        }

        User user = new User();
        UserData userData = new UserData();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Взимане на данни от текстовите кутии
            try
            {
                user.FirstName = txtFirstName.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid first name! The name must 2 or more characters.");
                return;
            }
            try
            {
                user.LastName = txtLastName.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid last name! The name must 2 or more characters.");
                return;
            }
            try
            {
                user.Email = txtEmail.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid email! Try again.");
                return;
            }
            try
            {
                user.Username = txtUsername.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid username! The username must be 5 or more characters.");
                return;
            }
            try
            {
                user.Password = txtPassword.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid password! The password must be 6 or more characters.");
                return;
            }
            try 
            { 
            user.Contact = txtContact.Text;
            user.Address = txtAddress.Text;
            user.Gender = cmbGender.Text;
            user.UserType = cmbUserType.Text;
            user.AddedDate = DateTime.Now;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
                return;
            }
            //Вземане на името на влезналия потребител
            string loggedUser = formLogin.loggedIn;
            User usr = userData.GetIDFromUsername(loggedUser);

            user.AddedBy = usr.Id;
            user.AddedByName = loggedUser;

            //Вкарване на данни в базата данни
            bool success = userData.Insert(user);
            
            if (success == true)
            {
                MessageBox.Show("User successfully created.");
                Clear();
            }
            else
            {
                
                MessageBox.Show("Failed to add new user.");
            }

            //Обновяване на таблицата във формата за потребители
            DataTable dt = userData.Select();
            dgvUsers.DataSource = dt;
        }

        private void formUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = userData.Select();
            dgvUsers.DataSource = dt;
            dgvUsers.Columns[0].HeaderText = "User ID";
            dgvUsers.Columns[1].HeaderText = "First Name";
            dgvUsers.Columns[2].HeaderText = "Last Name";
            dgvUsers.Columns[3].HeaderText = "Email";
            dgvUsers.Columns[4].HeaderText = "Username";
            dgvUsers.Columns[5].HeaderText = "Password";
            dgvUsers.Columns[6].HeaderText = "Contact";
            dgvUsers.Columns[7].HeaderText = "Address";
            dgvUsers.Columns[8].HeaderText = "Gender";
            dgvUsers.Columns[9].HeaderText = "User Type";
            dgvUsers.Columns[10].HeaderText = "Added Date";
            dgvUsers.Columns[11].HeaderText = "Added By ID";
            dgvUsers.Columns[12].HeaderText = "Added By Name";


        }

        private void Clear()
        {
            txtUserID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
            cmbUserType.Text = "";
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Вземане на индекса за реда
            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
            cmbGender.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();
            cmbUserType.Text = dgvUsers.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Вземане на данните от текстовите кутии
            user.Id = int.Parse(txtUserID.Text);
            try
            {
                user.FirstName = txtFirstName.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid first name! The name must 2 or more characters.");
                return;
            }
            try
            {
                user.LastName = txtLastName.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid last name! The name must 2 or more characters.");
                return;
            }
            try
            {
                user.Email = txtEmail.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid email! Try again.");
                return;
            }
            try
            {
                user.Username = txtUsername.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid username! The username must be 5 or more characters.");
                return;
            }
            try
            {
                user.Password = txtPassword.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid password! The password must be 6 or more characters.");
                return;
            }
            try
            {
                user.Contact = txtContact.Text;
                user.Address = txtAddress.Text;
                user.Gender = cmbGender.Text;
                user.UserType = cmbUserType.Text;
                user.AddedDate = DateTime.Now;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
                return;
            }

            //---------------------------------------------------------------------------------------
            string loggedUser = formLogin.loggedIn;
            User usr = userData.GetIDFromUsername(loggedUser);

            user.AddedBy = usr.Id;
            user.AddedByName = loggedUser;
            //---------------------------------------------------------------------------------------

            //Редактиране на данните в базата данни
            bool success = userData.Update(user);

            
            if (success == true)
            {
                MessageBox.Show("User successfully updated.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update user.");
            }

            DataTable dt = userData.Select();
            dgvUsers.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Вземане на id-то за потребителя от формата
            user.Id = int.Parse(txtUserID.Text);

            bool success = userData.Delete(user);

            if (success == true)
            {
                MessageBox.Show("User deleted successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete user");

            }

            DataTable dt = userData.Select();
            dgvUsers.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Вземане на думата от текстовата кутия
            string keywords = txtSearch.Text;

            //Проверка дали има стойност
            if (keywords != null)
            {
                //Показване на потребителя
                DataTable dt = userData.Search(keywords);
                dgvUsers.DataSource = dt;
            }
            else
            {
                //Показване на всички потребители
                DataTable dt = userData.Select();
                dgvUsers.DataSource = dt;
            }
        }

        private void formUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
            //Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkPass.Checked ? '\0' : '*';
        }
    }
}

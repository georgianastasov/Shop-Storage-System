﻿using Shop_Store_System.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_Store_System.Interfaces;

namespace Shop_Store_System.DataAccess
{
    class logisticDataAccess: logisticBusinessLogic, ICrudLogistic
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Вземане на данните
        public DataTable Select()
        {
            //Създаване на връзка с базата данни
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Създаване на времена таблица за задържане на данните
            DataTable dt = new DataTable();

            try
            {
                //Създаване на query което да вземе всички данни от таблицата
                String sql = "SELECT * FROM table_logistic";

                //Създаване на команда която да изпълне query-то
                SqlCommand cmd = new SqlCommand(sql, conn);

                //създаване на адаптер за задържане на информацията и запълване в таблицата
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //Вмъкване на данни
        public bool Insert(logisticBusinessLogic logistic)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "INSERT INTO table_logistic (employee, first_name_employee, last_name_employee, address, contact, date, description, price, added_date, added_by) VALUES (@employee, @first_name_employee, @last_name_employee, @address, @contact, @date, @description, @price, @added_date, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@employee", logistic.Empleyee);
                cmd.Parameters.AddWithValue("@first_name_employee", logistic.FirstNameEmployee);
                cmd.Parameters.AddWithValue("@last_name_employee", logistic.LastNameEmployee);
                cmd.Parameters.AddWithValue("@address", logistic.Address);
                cmd.Parameters.AddWithValue("@contact", logistic.Contact);
                cmd.Parameters.AddWithValue("@date", logistic.Date);
                cmd.Parameters.AddWithValue("@description", logistic.Description);
                cmd.Parameters.AddWithValue("@price", logistic.Price);
                cmd.Parameters.AddWithValue("@added_date", logistic.AddedDate);
                cmd.Parameters.AddWithValue("@added_by", logistic.AddedBy);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        
        //Редактиране на данни
        public bool Update(logisticBusinessLogic logistic)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "UPDATE table_logistic SET employee=@employee, first_name_employee=@first_name_employee, last_name_employee=@last_name_employee, address=@address, contact=@contact, date=@date, description=@description, price=@price, added_date=@added_date, added_by=@added_by WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@employee", logistic.Empleyee);
                cmd.Parameters.AddWithValue("@first_name_employee", logistic.FirstNameEmployee);
                cmd.Parameters.AddWithValue("@last_name_employee", logistic.LastNameEmployee);
                cmd.Parameters.AddWithValue("@address", logistic.Address);
                cmd.Parameters.AddWithValue("@contact", logistic.Contact);
                cmd.Parameters.AddWithValue("@date", logistic.Date);
                cmd.Parameters.AddWithValue("@description", logistic.Description);
                cmd.Parameters.AddWithValue("@price", logistic.Price);
                cmd.Parameters.AddWithValue("@added_date", logistic.AddedDate);
                cmd.Parameters.AddWithValue("@added_by", logistic.AddedBy);
                cmd.Parameters.AddWithValue("@id", logistic.Id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        //Изтриване на данни
        public bool Delete(logisticBusinessLogic logistic)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "DELETE FROM table_logistic WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", logistic.Id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        //Търсене
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM table_logistic WHERE id LIKE '%" + keywords + "%' OR employee LIKE '%" + keywords + "%' OR date LIKE '%" + keywords + "%'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

    }
}

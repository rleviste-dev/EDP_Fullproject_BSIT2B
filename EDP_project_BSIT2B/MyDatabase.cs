using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_project_BSIT2B
{   
    internal class MyDatabase
    {

        string connectionString = "Server=localhost;Port=3306;Database='leviste_db';Uid='root';Pwd=''";




        public bool TestConnection()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
            public int ExecuteNoReturnQuery(string query, params MySqlParameter[] parameters)
        {
            int affectedRows = 0;
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, con);
                if (parameters != null)
                {
                    foreach (MySqlParameter param in parameters)
                    {
                        command.Parameters.Add(param);
                    }

                }
                try
                {
                    con.Open();
                    affectedRows = command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Execution failed: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return affectedRows;
            }
        }



        //execute return query. used for query SELECT.
        public DataTable ExecuteReturnQuery(string query, params MySqlParameter[] parameters)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, con);
                if (parameters != null)
                {
                    foreach (MySqlParameter param in parameters)
                    {
                        command.Parameters.Add(param);
                    }
                }
                DataTable dataTable = new DataTable();
                try
                {
                    con.Open();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Execution failed: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }

                return dataTable;
            }
        }
    }
    }


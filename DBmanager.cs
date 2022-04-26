﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace HospitalSystemGUI
{
    class DBmanager
    {
        string DBconnectingString = @"Data Source=localhost;Initial Catalog = HospitalSystem; Integrated Security = True";
        SqlConnection myConnection;

    
        public DBmanager()
        {
            myConnection = new SqlConnection(DBconnectingString);
            try
            {
                myConnection.Open(); //Open a connection with the DB
                Console.WriteLine("Successfully connected to the database!");
                //just for illustration when the database is opened, this should not be shown in GUI to the user
               // MessageBox.Show("Successfully connected to the database!");
            }
            catch (Exception e)
            {
                Console.WriteLine("The DB connection to :" + DBconnectingString + " failed!");
                MessageBox.Show("An error occurred while connecting to the database!");
            }

        }
         // part 1 
        public int ExecuteNonQuery(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        // part 2
        public DataTable ExecuteReader(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public object ExecuteScalar(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }




        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
};


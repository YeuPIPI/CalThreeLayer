using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalThreeLayer;
using System.Data.SqlClient;
using System.Data;
namespace CalThreeLayer.DAL_DataAL
{
    public class ConnectToSql
    {
        private string source = @"Data Source=DESKTOP-057N016\SQLEXPRESS;Initial Catalog=dbLogin;Integrated Security=True";
        private string name_Database = "DBEP";
        private Person a;

        public ConnectToSql(string source, string name_Database, Person a)
        {
            this.source = source;
            this.name_Database = name_Database;
            this.a = a;
        }
        public ConnectToSql() { }
        public string Source { get => source; set => source = value; }
        public string Name_Database { get => name_Database; set => name_Database = value; }
        internal Person A { get => a; set => a = value; }
        public int SELECT(Person a)
        {
            int check = 0;
            using (SqlConnection connection = new SqlConnection(Source))
            {                          
                   string query = "Select * from DBEP Where email = '" + a.Email + "' and password = '" + a.Password + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    DataTable ds = new DataTable();
                    sda.Fill(ds);
                    if (ds.Rows.Count == 1)
                    {
                        check = 1;
                    }
                
            }
            return check;
        }
        public int REGISTER(Person a)
        {

            int check = 1;
            
            using (SqlConnection connection = new SqlConnection(Source))
            {
                if(a.Email != "" && a.Password != "")
                {
                    string query = "Select * from DBEP Where email = '" + a.Email + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    DataTable ds = new DataTable();
                    sda.Fill(ds);
                    if (ds.Rows.Count == 1)
                    {
                        check = 0;
                        return check;
                    }
                    if(check == 1)
                    {
                        connection.Open();
                        string sql = "INSERT INTO DBEP(email,password)VALUES (";
                        sql += "N'" + a.Email + "',N'" + a.Password + "')";
                        SqlCommand cmd = new SqlCommand(sql, connection);
                        int v = (int)cmd.ExecuteNonQuery();
                        if (v > 0)
                        {
                            return check;
                        }
                        else
                        {
                            check = 0;
                            return check;
                            
                        }
                    }
                }
            }
            return check;
        }
        public int CHANGE_PASSWORD(Person a)
        {
            int check = 0;
            using (SqlConnection connection = new SqlConnection(Source))
            {
                connection.Open();
                string query = "UPDATE DBEP SET password = ' " + a.Password + " ' WHERE email = '" + a.Email + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                int v = (int)cmd.ExecuteNonQuery();
                if (v > 0)
                {
                    check = 1;
                    return check;
                }
                else
                {
                    return check;
                }
            }
            return check;
        }
    }
}

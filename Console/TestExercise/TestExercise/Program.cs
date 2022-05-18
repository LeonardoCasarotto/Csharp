using System;
using static System.Console;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text;
namespace System.Security.Cryptography;
using System.Security.Cryptography;
 
    class Program
    {

        static void Main()
        {

        WriteLine(ComputeSha256Hash("hello world!"));




        }
         static string ComputeSha256Hash(string rawData)  
        {  
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())  
            {  
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  
  
                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();  
                for (int i = 0; i < bytes.Length; i++)  
                {  
                    builder.Append(bytes[i].ToString("x2"));  
                }  
                return builder.ToString();  
            }  
        }
        static void MYSQL()
        {
            string connStr = "server=leosmysql.mysql.database.azure.com;" +
                    "user=Leonardo;" +
                    "database=main;" +
                    "port=3306;" +
                    "password=Database44?";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "SELECT * FROM uscite";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1] + rdr[2] + rdr[3]);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
        }

       


    
    }    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL_transaktion_Forms
{
    class DatabaseAccessor
    {
        static string strConn = @"Server = " + Environment.MachineName + ";Database = Fly; Trusted_Connection = True";
        static SqlConnection conn = new SqlConnection(strConn);

        public static bool canOpen()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static int[] Read(string table)
        {
            List<int> output = new List<int>();
            int index = 1;

            string sqlString = "SELECT * FROM " + table + ";";
            SqlCommand cmd = new SqlCommand(sqlString, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                output.Add(reader.GetInt32(index));
                index++;
            }
            reader.Close();

            return output.ToArray();
        }
        
        public static bool Update(string table, int seats, int flightNo)
        {
            string sqlString = "UPDATE " + table + " SET seatsFree = seatsFree - " + seats + " WHERE flightNo = " + flightNo;
            SqlCommand cmd = new SqlCommand(sqlString, conn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool Rollback()
        {
            return Transactions.Rollback(conn);
        }

        public static bool Commit()
        {
            return Transactions.Commit(conn);
        }
        public static bool BeginUncommited()
        {
            return Transactions.ReadUncommitted(conn);
        }

        public static bool BeginSerializable()
        {
            return Transactions.Serializable(conn);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL_transaktion_Forms
{
    internal class Transactions
    {
        public static bool ReadUncommitted(SqlConnection conn)
        {
            try
            {
                string sqlString = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;";
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();

                sqlString = "BEGIN TRANSACTION";
                cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool Serializable(SqlConnection conn)
        {
            try
            {
                string sqlString = "SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;";
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();

                sqlString = "BEGIN TRANSACTION";
                cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

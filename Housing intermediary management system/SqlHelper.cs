using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Housing_intermediary_management_system
{
    class SqlHelper
    {
        public static int Insert(string commandText)
        {
            int influencedLines;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = commandText;
                    conn.Open();
                    influencedLines=cmd.ExecuteNonQuery();
                }
            }
            return influencedLines;
        }

        public static int Update(string commandText)
        {
            int influencedLines;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = commandText;
                    influencedLines = cmd.ExecuteNonQuery();
                }
            }
            return influencedLines;
        }

        public static int Delete(string commandText)
        {
            int influencedLines;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = commandText;
                    influencedLines = cmd.ExecuteNonQuery();
                }
            }
            return influencedLines;
        }
        public static DataTable Select(string commandText)
        {
            DataTable dt=new DataTable();
            using (SqlDataAdapter adapter=new SqlDataAdapter(commandText, ConfigurationManager.ConnectionStrings["connStr"].ConnectionString))
            {
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}

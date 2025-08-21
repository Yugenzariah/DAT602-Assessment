using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAT602_Assessment
{
    public static class DataAccess
    {
        private static string ConnStr =>
            ConfigurationManager.ConnectionStrings["TheRazeDb"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(ConnStr);
            conn.Open();
            return conn;
        }

        // helpers for executing stored procedures
        public static int ExecNonQuery(string procName, params MySqlParameter[] args)
        {
            using var conn = GetConnection();
            using var cmd = new MySqlCommand(procName, conn) { CommandType = CommandType.StoredProcedure };
            if (args != null) cmd.Parameters.AddRange(args);
            return cmd.ExecuteNonQuery();
        }

        public static object? ExecScalar(string procName, params MySqlParameter[] args)
        {
            using var conn = GetConnection();
            using var cmd = new MySqlCommand(procName, conn) { CommandType = CommandType.StoredProcedure };
            if (args != null) cmd.Parameters.AddRange(args);
            return cmd.ExecuteScalar();
        }

        public static DataTable ExecTable(string procName, params MySqlParameter[] args)
        {
            using var conn = GetConnection();
            using var cmd = new MySqlCommand(procName, conn) { CommandType = CommandType.StoredProcedure };
            if (args != null) cmd.Parameters.AddRange(args);
            using var da = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
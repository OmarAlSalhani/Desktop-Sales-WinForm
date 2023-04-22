using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ClientApp.classes
{
    // this class used for perform commands in database like
    // connection , CRUD
    public class connection_class
    {
        public static SqlConnection connection2;
        // method used to set connection string , handle connection and open connection with database
        public static SqlConnection connection()
        {
            try
            {
                if (settings_files.database_settings.Default.trusted_connection == 1)
                {
                    connection2 = new SqlConnection($@"Server={settings_files.database_settings.Default.server_name}" +
                                                   $";Database=client_database" +
                                                   ";Trusted_Connection=true;MultipleActiveResultSets=true;Max Pool Size=10000;Pooling=true;Current Language=Arabic");
                }
                else
                {
                    connection2 = new SqlConnection($@"Server={settings_files.database_settings.Default.server_name}" +
                                                             ";Database=client_database" +
                                                            ";User Id="
                                                            + settings_files.database_settings.Default.username +
                                                            ";Password="
                                                            + settings_files.database_settings.Default.password +
                                                            ";MultipleActiveResultSets=true;Max Pool Size=10000;Pooling=true;Current Language=Arabic");
                }
                if (connection2.State != ConnectionState.Open)
                {
                    connection2.Open();
                }
                return connection2;
            }
            catch (Exception Ex)
            {
                classes.notifications_class.my_messageBox(Ex.Message);
                return null;
            }

        }
        public static bool check_connection()
        {
            if (connection() is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // method used to excute command on database
        // the command type is simple query with zero parameter
        // parameters :
        // query : the query statment
        public static int command(string query)
        {
            SqlCommand command = new SqlCommand(query, connection());
            return command.ExecuteNonQuery();

        }
        // method used to excute select command on database and return DataTable
        // the command type is simple query with zero parameter
        // parameters :
        // query : the query statment
        public static DataTable select(string query)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection());
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                return table;
            }
            catch (Exception Ex)
            {
                classes.notifications_class.my_messageBox(Ex.Message);
                return null;
            }
        }
        // method used to excute command on database
        // the command type is stored procedure with zero parameter
        // parameters :
        // stored_proc : the stored procedure name
        public static void sp_command_noPara(string stored_proc)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = connection(),
                CommandText = stored_proc,
                CommandType = CommandType.StoredProcedure
            };
            command.ExecuteNonQuery();

        }
    }
}

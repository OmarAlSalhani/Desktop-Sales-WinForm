using System;
using System.Data.SqlClient;
namespace ClientApp.classes
{
    ///what done :
    ///all banks
    ///add company
    ///all warehouses
    ///all users

    /// <summary>
    /// this class used for add logs to database about users events
    /// </summary>
    class logs_class
    {
        // method used to add log to logs table in database
        // parameters :
        // event_name : the event name that`s user make it
        public static void log_add(string event_name,int event_number,string event_screen)
        {
            connection_class.connection();
            SqlCommand command = new SqlCommand("insert into black_box_table values(@userID,@event_name,@event_date,@event_time,@event_screen)", connection_class.connection());
            command.Parameters.AddWithValue("@userID", classes.const_variables_class.userID);
            command.Parameters.AddWithValue("@event_name", event_name);
            command.Parameters.AddWithValue("@event_date", DateTime.Now.ToString("dd-MM-yyyy"));
            command.Parameters.AddWithValue("@event_time", DateTime.Now.ToString("hh:mm:ss tt"));
            command.Parameters.AddWithValue("@event_screen", event_screen);
            command.ExecuteNonQuery();
        }
    }
}
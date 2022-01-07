using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Elevator
{
    class Database
    {
        // Object of the Elevator class.
        private Elevator elevator;

        // Variables to establish a connection with the database and create queries.
        private OleDbConnection connection;
        private OleDbCommand command;
        private OleDbDataReader reader;

        // Delegates to establish the type of connection to the database (Insert/Retrieve).
        public delegate void DatabaseDelegate(string eventType, string details);
        public DatabaseDelegate databaseEvent;

        // Constructor to initialise the objects/variables.
        public Database(Elevator e)
        {
            // Instantiates the elevator object.
            elevator = e;

            // Establishes a connection to the access database.
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Elevator Log.accdb");
            // Instantiates the command object.
            command = connection.CreateCommand();

            // Instantiates the delegate object, with the EventHandler method.
            databaseEvent += new DatabaseDelegate(EventHandler);
        }

        // Method to help instantiate the database delegate.
        private void EventHandler(string eventType, string details)
        {
            // Retrieves the current date and concatenates it with the time of the current day.
            string dateTime = DateTime.Today.ToString("d") + " " + DateTime.Now.ToString("HH:mm:ss tt");
            // Switch statement to establish whether the variable of eventType contains Insert or Retrieve.
            switch (eventType)
            {
                // If 'Insert' return the method of logEvent.
                case "Insert": logEvent(dateTime, details);
                    break;
                // If 'Retrieve' return the method of retrieveEvent.
                case "Retrieve": retrieveEvent();
                    break;
            }
        }

        // A method that stores information of the date the button was pushed and the event type.
        private void logEvent(string datetime, string details)
        {
            // Opens a connection with the database.
            connection.Open();
            // Places a SQL query within the CommandText of the OleDbCommand called command.
            command.CommandText = "INSERT INTO `Logs`(`DateTime`, `Entry`) VALUES('" + datetime + "', '" + details + "');";
            // Executes the SQL query.
            command.ExecuteNonQuery();
            // Closes the connection with the database.
            connection.Close();

            // Calls the method that retrieves the data from the database and places it within the table.
            retrieveEvent();
        }

        // A method that gets the content of the database one by one and stores it within the table.
        private void retrieveEvent()
        {
            // Clears the current data of the table.
            elevator.getLogTable().Rows.Clear();
            // Stores a new query within the CommandText of command.
            command.CommandText = "SELECT * FROM `Logs`;";
            // Opens a connection with the database.
            connection.Open();
            // Executes the SQL query, then stores it within the object of reader.
            reader = command.ExecuteReader();
            // A while loop that runs as long as the contents of the object 'reader' runs true.
            while(reader.Read())
            {
                // A string array with the contents that is retrieved from the database.
                string[] data = new string[] { reader["ID"].ToString(), reader["DateTime"].ToString(), reader["Entry"].ToString() };
                // Stores the arrays as a row within the table.
                elevator.getLogTable().Rows.Add(data);
            }
            // Closes the connection.
            connection.Close();
        }
    }
}

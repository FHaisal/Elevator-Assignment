using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
    public partial class Elevator : Form
    {
        // Objects of the Database and Movement class.
        private Database database;
        private Movement movement;
        // Integer variable to delay the closing of doors.
        private int count;

        // Constructor to initialise the GUI.
        public Elevator()
        {
            InitializeComponent();
        }

        // Method to initialise variables/objects when the GUI loads.
        private void Elevator_Load(object sender, EventArgs e)
        {
            // Initialise the objects and provides this specific class as a parameter, to be using within the other classes.
            database = new Database(this);
            movement = new Movement(this);
            // Sets the initial value of the delay.
            count = 3;

            // Retrieves all the content of the database and uploads them to the table.
            database.databaseEvent("Retrieve", null);
        }

        // Method that handles the click of the button that requests to the ground floor.
        private void rqstGround_Click(object sender, EventArgs e)
        {
            // Utilising the database delegate to insert data to the database.
            database.databaseEvent("Insert", "Request to ground floor button pushed.");

            // Inserting 'Down' into the list of 'direction' to make the elevator move down.
            movement.direct("Down");

            // Change the colour of the buttons text to notify the user that it's been pressed.
            rqstGround.ForeColor = Color.LightGreen;
        }

        // Method that handles the request button for the first floor.
        private void rqstFirst_Click(object sender, EventArgs e)
        {
            // Utilising the database delegate to insert data to the database.
            database.databaseEvent("Insert", "Request to first floor button pushed.");

            // Inserting 'Up' into the list of 'direction' to make the elevator move up.
            movement.direct("Up");

            // Change the colour of the buttons text to notify the user that it's been pressed.
            rqstFirst.ForeColor = Color.LightGreen;
        }

        // Method that handles the control panel button for the ground floor.
        private void btnGround_Click(object sender, EventArgs e)
        {
            // Utilising the database delegate to insert data to the database.
            database.databaseEvent("Insert", "Ground button has been pushed.");

            // Inserting 'Up' into the list of 'direction' to make the elevator move down.
            movement.direct("Down");

            // Checks if the door is open, if so then forces the doors to close.
            if ((topLeft.Location.X <= -1 && topRight.Location.X >= 122) || (botLeft.Location.X <= -1 && botRight.Location.X >= 122))
            {
                // Changes the delay of the doors to 0, so the doors close instantly.
                count = 0;
            }
            // Change the colour of the buttons text to notify the user that it's been pressed.
            btnGround.ForeColor = Color.LightGreen;
        }

        // Method that handles the control panel button for the first floor.
        private void btnFirst_Click(object sender, EventArgs e)
        {
            // Utilising the database delegate to insert data to the database.
            database.databaseEvent("Insert", "First floor button has been pushed.");

            // Inserting 'Up' into the list of 'direction' to make the elevator move up.
            movement.direct("Up");

            // Checks if the door is open, if so then forces the doors to close.
            if((topLeft.Location.X <= -1 && topRight.Location.X >= 122) || (botLeft.Location.X <= -1 && botRight.Location.X >= 122))
            {
                // Changes the delay of the doors to 0, so the doors close instantly.
                count = 0;
            }
            // Change the colour of the buttons text to notify the user that it's been pressed.
            btnFirst.ForeColor = Color.LightGreen;
        }

        // Method that handles the control panel button to open the doors, depending on the current floor of the elevator.
        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Utilising the database delegate to insert data to the database.
            database.databaseEvent("Insert", "Request to open elevator doors button has been pushed.");

            // If the elevator is on the first floor, then open the first floor doors.
            if(insideEle.Location.Y <= 0)
            {
                // Inserting 'CloseTop' into the list of 'direction' to make the first floor doors open.
                movement.direct("OpenTop");
            }
            // Else if the elevator is located on the ground floor, then open the ground floor doors.
            else if(insideEle.Location.Y >= 346)
            {
                // Inserting 'CloseBot' into the list of 'direction' to make the ground floor doors open.
                movement.direct("OpenBot");
            }

            // Let's the user know that the button has been requested, by being changed to a different colour.
            btnOpen.ForeColor = Color.LightGreen;
        }

        // The method to close the doors, according to the floor.
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Utilising the database delegate to insert data to the database.
            database.databaseEvent("Insert", "Request to close elevator doors button has been pushed.");

            // Checks to see if the first floor door or the ground floor door is open, then closes accordingly.
            if ((topLeft.Location.X <= -1 && topRight.Location.X >= 122) || (botLeft.Location.X <= -1 && botRight.Location.X >= 122))
            {
                // Sets the delay counter to 0, so the doors start to close instantly.
                count = 0;
                // Changes the text of the buttons colour to green to let the user know the button as been requested.
                btnClose.ForeColor = Color.LightGreen;
            }
        }

        // Method that handles the emergency alert button.
        private void btnAlert_Click(object sender, EventArgs e)
        {
            // Utilising the database delegate to insert data to the database.
            database.databaseEvent("Insert", "Emergency Alert button has been pushed.");

            // Inserts the value of 'Emergency' to the 'direction' list as an index of 0, to prioritise over other elements of the list.
            movement.direct("Emergency", 0);

            // The colour of the button's text is permanently changed to red.
            btnAlert.ForeColor = Color.Red;
        }

        // Timer to run the methods of allowing the elevator to move and the doors to open/close.
        private void eleTimer_Tick(object sender, EventArgs e)
        {
            // Calls the methods from the Movement class.
            movement.moveElevator();
            movement.openDoor();
            // If the counter is less than or equal to 0 then start to close the doors.
            if (count <= 0)
            {
                movement.closeDoor();
            }

            // If the location of the elevator is on the first floor then reset the request buttons.
            if (insideEle.Location.Y <= 0)
            {
                // Changes the text colour of the request to the first floor buttons.
                rqstFirst.ForeColor = Color.Black;
                btnFirst.ForeColor = Color.Black;
            }
            // If the location of the elevator is on the ground floor then reset the request buttons.
            if (insideEle.Location.Y >= 346)
            {
                // Changes the text colour of the request to the ground floor buttons.
                rqstGround.ForeColor = Color.Black;
                btnGround.ForeColor = Color.Black;
            }
        }

        // Timer that counts down the 'count' variable every second.
        private void counter_Tick(object sender, EventArgs e)
        {
            // As the value of 'count' starts at 3, the 'count' variable will decrease to 0 in 3 seconds of the timer start.
            count--;
        }

        // Sets the value for all displays.
        public void setDisplay(string floor)
        {
            // Changes the text of all three labels according to the value of the string variable.
            groundDisplay.Text = floor;
            firstDisplay.Text = floor;
            controlDisplay.Text = floor;
        }

        // Sets the delay counter for closing the doors.
        public void setCounter(bool val)
        {
            // Enables the timer, to start the delay, according to the value of val.
            counter.Enabled = val;
            // If the value is false, the reset the delay to 3.
            if (!val)
            {
                // The count variable is changed to 3.
                count = 3;
            }
        }

        // Returns the DataGridView of the table.
        public DataGridView getLogTable()
        {
            return logTable;
        }

        // Returns the Label of the elevator label.
        public Label getElevator()
        {
            return insideEle;
        }

        // Returns the Label of the first floor left door.
        public Label getTopLeft()
        {
            return topLeft;
        }
        // Returns the Label of the first floor right door.
        public Label getTopRight()
        {
            return topRight;
        }

        // Returns the Label of the ground floor left door.
        public Label getBotLeft()
        {
            return botLeft;
        }
        // Returns the Label of the ground floor right door.
        public Label getBotRight()
        {
            return botRight;
        }

        // Returns the Button of the first floor request button.
        public Button getRqstFirst()
        {
            return rqstFirst;
        }
        // Returns the Button of the ground floor request button.
        public Button getRqstGround()
        {
            return rqstGround;
        }
        // Returns the Button of the control panel request to first floor.
        public Button getBtnFirst()
        {
            return btnFirst;
        }
        // Returns the Button of the control panel request to ground floor.
        public Button getBtnGround()
        {
            return btnGround;
        }
        // Returns the Button of the control panel to open the doors.
        public Button getBtnOpen()
        {
            return btnOpen;
        }
        // Returns the Button of the control panel to close the doors.
        public Button getBtnClose()
        {
            return btnClose;
        }
        // Returns the Button of the Emergency Alert on the control panel.
        public Button GetBtnAlert()
        {
            return btnAlert;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Elevator
{
    class Movement
    {
        // Variables and objects.
        private Elevator elevator;
        private Sound sound;
        private List<string> direction;
        private int elePos, leftX, rightX;

        // Constructor, to initialise the variables/objects.
        public Movement(Elevator e)
        {
            // Instantiate the object.
            elevator = e;
            sound = new Sound();
            // Instantiate a list of the string data type, to contain the direction of the elevator.
            direction = new List<string>();

            // Stores the integer values of the elevator and the doors.
            elePos = 346;
            leftX = 0;
            rightX = 122;
        }

        // Method to control the movement of the elevator itself.
        public void moveElevator()
        {
            // If the list of direction has content, then run the next statements.
            if(direction.Any())
            {
                // If the first item of direction is 'Up' then run the next statements.
                if(direction[0] == "Up")
                {
                    // If the elevators location is about 0 then move the elevator up.
                    if (elevator.getElevator().Location.Y >= 0)
                    {
                        // Minus the value of 'elePos' each time.
                        elePos--;
                        // Change the value accordingly.
                        elevator.getElevator().Location = new Point(0, elePos);
                    }
                    // Else remove the 'direction' of 'Up' and start opening the first floor doors.
                    else
                    {
                        // Plays a sound, notifying the users that they have reached the first floor.
                        sound.soundEvent("First");

                        // This will delete the 'Up' value within the direction list.
                        direction.RemoveAt(0);
                        // This will then insert a value to open the first floor doors.
                        direction.Insert(0, "OpenTop");
                        // Set the displays of every display window to the first floor.
                        elevator.setDisplay("1");

                        // Change the colour of the buttons, to indicate the request has been fulfilled.
                        elevator.getRqstFirst().ForeColor = Color.Black;
                        elevator.getBtnFirst().ForeColor = Color.Black;
                    }
                }
                // Else if the direction is 'Down' then do the opposite of 'Up'.
                else if(direction[0] == "Down")
                {
                    // If the position of the elevator is below 346 then move the elevator down.
                    if(elevator.getElevator().Location.Y <= 346)
                    {
                        // Increases the value of elePos each time.
                        elePos++;
                        // Relocates the position of the elevator.
                        elevator.getElevator().Location = new Point(0, elePos);
                    }
                    // Else start opening the door and reset values accordingly.
                    else
                    {
                        // Plays a sound, notifying the users that they have reached the ground floor.
                        sound.soundEvent("Ground");

                        // Removes the value of 'Down' within the list of 'direction'.
                        direction.RemoveAt(0);
                        // Insert 'OpenBot' within 'direction', so the bottom doors can start opening.
                        direction.Insert(0, "OpenBot");
                        // Set the displays to show the current floor of Ground.
                        elevator.setDisplay("G");

                        // Resets the requests of the buttons.
                        elevator.getRqstGround().ForeColor = Color.Black;
                        elevator.getBtnGround().ForeColor = Color.Black;
                    }
                }
                // Else if the first value of 'direction' is 'Emergency' then run the following lines of code.
                else if(direction[0] == "Emergency")
                {
                    // If the top door of the elevators are closed or open, then open them.
                    if (elevator.getTopLeft().Location.X >= -122 && elevator.getTopRight().Location.X <= 244)
                    {
                        // Starts to decrease the value of leftX.
                        leftX--;
                        // Changes the position of the left door according to the value of leftX.
                        elevator.getTopLeft().Location = new Point(leftX, 0);
                        // Increases the value of rightX.
                        rightX++;
                        // Changes the position of the right door according to the value of rightX.
                        elevator.getTopRight().Location = new Point(rightX, 0);
                    }
                    if (elevator.getBotLeft().Location.X >= -122 && elevator.getBotRight().Location.X <= 244)
                    {
                        // Starts to decrease the value of leftX.
                        leftX--;
                        // Changes the position of the left door according to the value of leftX.
                        elevator.getBotLeft().Location = new Point(leftX, 346);
                        // Increases the value of rightX.
                        rightX++;
                        // Changes the position of the right door according to the value of rightX.
                        elevator.getBotRight().Location = new Point(rightX, 346);
                    }
                }
            }
        }

        // A method to control the opening of doors, first or ground floor.
        public void openDoor()
        {
            // Checks to see if the 'direction' list contains anything.
            if (direction.Any())
            {
                // If the 'direction' list contains 'OpenTop' then start opening the first floor doors.
                if (direction[0] == "OpenTop")
                {
                    // Checks to see if the doors are currently open.
                    if (elevator.getTopLeft().Location.X >= -122 && elevator.getTopRight().Location.X <= 244)
                    {
                        // Decreases the value of leftX.
                        leftX--;
                        // Assigns the value of leftX to the first floor left door of the elevator.
                        elevator.getTopLeft().Location = new Point(leftX, 0);
                        // Increases the value of rightX.
                        rightX++;
                        // Assigns the value of rightX to the first floor right door of the elevator.
                        elevator.getTopRight().Location = new Point(rightX, 0);
                    }
                    else
                    {
                        // Remove the value of 'OpenTop' from the first index of 'direction'.
                        direction.RemoveAt(0);
                        // Insert the value of 'CloseTop' into 'direction' so the doors can start closing.
                        direction.Insert(0, "CloseTop");
                        // Enable the delay for the doors to start closing.
                        elevator.setCounter(true);

                        // Change the request to open the doors button back to normal.
                        elevator.getBtnOpen().ForeColor = Color.Black;
                    }
                }
                // Else if the 'direction' list contains 'OpenBot' then open the ground floor doors.
                else if(direction[0] == "OpenBot")
                {
                    // If the ground floor doors were closed then start opening them.
                    if(elevator.getBotLeft().Location.X >= -122 && elevator.getBotRight().Location.X <= 244)
                    {
                        // Decreases the value of leftX.
                        leftX--;
                        // Changes the location of the ground floor left door according to the value of leftX.
                        elevator.getBotLeft().Location = new Point(leftX, 346);
                        // Increase the value of rightX.
                        rightX++;
                        // Changes the location of the ground floor right door according to the value of rightx.
                        elevator.getBotRight().Location = new Point(rightX, 346);
                    }
                    // Else if the doors are fully open, start the process of closing the doors.
                    else
                    {
                        // Remove the value of 'OpenBot' from the 'direction' list.
                        direction.RemoveAt(0);
                        // Insert into the 'direction' list with the value of 'CloseBot' to run the closeDoor() method.
                        direction.Insert(0, "CloseBot");
                        // Starts the delay of when the doors should start closing.
                        elevator.setCounter(true);

                        // Changes the color of the button that requested to open the doors, if it was pressed.
                        elevator.getBtnOpen().ForeColor = Color.Black;
                    }
                }
            }
        }

        // Method that closes the doors according to the location of the elevator.
        public void closeDoor()
        {
            // If the 'direction' list has any elements within it, then the content within the if statement will run.
            if (direction.Any())
            {
                // If the 'direction' list contains 'CloseTop' then the doors will start to close.
                if (direction[0] == "CloseTop")
                {
                    // If the first floor elevator doors are open, then start the process of closing them.
                    if (elevator.getTopLeft().Location.X <= -1 && elevator.getTopRight().Location.X >= 122)
                    {
                        // Increase the value of leftX.
                        leftX++;
                        // Change the position of the first floor left door, with the value of leftX.
                        elevator.getTopLeft().Location = new Point(leftX, 0);
                        // Decrease the value of rightX.
                        rightX--;
                        // Change the position of the first floor right door, with the value of rightX.
                        elevator.getTopRight().Location = new Point(rightX, 0);
                    }
                    // Else once the elevator is closed, reset values accordingly.
                    else
                    {
                        // Remove the value of 'CloseTop' from the 'direction' list.
                        direction.RemoveAt(0);
                        // Reset the delay of doors closing.
                        elevator.setCounter(false);

                        // Reset the request of the close button to the default colour.
                        elevator.getBtnClose().ForeColor = Color.Black;
                    }
                }
                // Else if the first element of 'direction' is equal to 'CloseBot' then close the ground floor doors.
                else if (direction[0] == "CloseBot")
                {
                    // If the doors are currently open then close them.
                    if (elevator.getBotLeft().Location.X <= -1 && elevator.getBotRight().Location.X >= 122)
                    {
                        // Increase the value of leftX.
                        leftX++;
                        // Change the position of the ground floor left door according to the value of leftX.
                        elevator.getBotLeft().Location = new Point(leftX, 346);
                        // Decrease the value of rightX.
                        rightX--;
                        // Change the position of the ground floor right door according to the value of rightX.
                        elevator.getBotRight().Location = new Point(rightX, 346);
                    }
                    // Once the doors are close then reset values accordingly.
                    else
                    {
                        // Removes the value of 'CloseBot' by index.
                        direction.RemoveAt(0);
                        // Resets the delay counter.
                        elevator.setCounter(false);

                        // Changes the close buttons colour back to default.
                        elevator.getBtnClose().ForeColor = Color.Black;
                    }
                }
            }
        }

        // Inserts values into the 'direction' list according to the parameters.
        public void direct(string move)
        {
            // If the value is not already inside of the list then insert the contents of 'move'.
            if (!direction.Contains(move)) direction.Add(move);
        }
        // Inserts the value by index.
        public void direct(string move, int index)
        {
            // If the value is not already inside of the list then insert the contents of 'move' by 'index'.
            if (!direction.Contains(move)) direction.Insert(index, move);
        }

        // Method to get the list variable 'direction'
        public List<string> getDirection()
        {
            // Returns the variable 'direction'
            return direction;
        }
    }
}

/*
 * Chris Mcclure 
 * airline reservation
 * 10/21/2017
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Program_4
{
    public partial class Form1 : Form
    {
        List<Flight> flightArray;      
        Flight flight1;
        Flight flight2;
        List<Button> buttons;
        List<Label> labels;

        public Form1()
        {
            InitializeComponent();
            //Initialize objects in empty constructor
            buttons = new List<Button>();
            labels = new List<Label>();
            flightArray = new List<Flight>();
            flight1 = new Flight("Cessna 1137", "10:00AM", "Denver", 3, 4);
            flight2 = new Flight("Piper 6578", "11:00AM", "Kansas City", 3, 2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            flightArray.Add(flight1);
            flightArray.Add(flight2);

            //make some reservations
            flight1.MakeReservation("Bob", (4 - 1));
            flight1.MakeReservation("Jim", (3 - 1));
            flight1.MakeReservation("Jeb", (5 - 1));


            flight2.MakeReservation("David", (1 - 1));
            flight2.MakeReservation("Mike", (6 - 1));
            flight2.MakeReservation("Dustin", (3 - 1));
            flight2.MakeReservation("Jethro", (4 - 1));
        }       

        //Create button for each seat bassed on the string[] of names
        private void DisplaySeatingChart(string[] seatChart)
        {
            //Clean out of the array of buttons to clean the UI
            CleanUIUp();
            
            int numberOfButtons = seatChart.Count();
            int increasePerButton = 20;

            //Setting values for UI elements
            KeyValuePair<int, int> leftLabelTopCorner = new KeyValuePair<int, int>(600, 255);
            KeyValuePair<int, int> leftButtonTopCorner = new KeyValuePair<int, int>(670, 250);
            KeyValuePair<int, int> rightLabelTopCorner = new KeyValuePair<int, int>(790, 255);
            KeyValuePair<int, int> rightButtonTopCorner = new KeyValuePair<int, int>(860, 250);

                                        

            //Creating buttons and labels
            for (int i = 0; i < seatChart.Count(); i++)
            {
                //Make buttons
                Button button = new Button();
                button.Text = seatChart[i];
                button.Click += new EventHandler(MyHandler); // The button needs a click event handler. This wires up to the method MyHandler.
                button.Tag = i; // you can store all kinds of stuff in the tab property even objects. In this case it is just a number.                
                button.Height = 30;
                button.Width = 110;
                button.Name = "btnPass" + i;
                button.Tag = i;


                //Make label
                Label label = new Label();
                label.Font = new Font("Microsoft Sans Serif", 10);
                label.Text = $"Seat {i + 1} :";


                if ((i + 1) % 2 != 0) //Odd numbers on the left
                {
                    button.Location = new Point(leftButtonTopCorner.Key, leftButtonTopCorner.Value + (i * increasePerButton));
                    label.Location = new Point(leftLabelTopCorner.Key, leftLabelTopCorner.Value + (i * increasePerButton));
                }
                else //even numbers on the right
                {
                    button.Location = new Point(rightButtonTopCorner.Key, rightButtonTopCorner.Value + ((i - 1) * increasePerButton));
                    label.Location = new Point(rightLabelTopCorner.Key, rightLabelTopCorner.Value + ((i - 1) * increasePerButton));
                }

                //Add to lists
                buttons.Add(button);
                labels.Add(label);

                //Add it to the controls
                Controls.Add(button);
                Controls.Add(label);             
            }                        
        }


        //Cleans up all the controls on the ui so, buttons and labels don't overlap
        private void CleanUIUp()
        {
            if (buttons.Count > 0)
            {
                foreach (var button in buttons)
                {
                    Controls.Remove(button);
                    button.Dispose();
                }
                buttons.Clear();

                foreach (var label in labels)
                {
                    Controls.Remove(label);
                    label.Dispose();
                }
                labels.Clear();
            }              
        }

        //Clear the name text box.  After I wrote this I realzied that it's only used once, 
        //but hey it's reusable for later if I ever needed it
        private void ClearTextBox()
        {
            txtName.Text = string.Empty;
            txtName.Focus();
        }

        private void MyHandler(object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender;  // The sender needs to be cast into a button type
            int tagValue = (int)clickedButton.Tag; // Now cast the tag value into a integer
            string reservationName = txtName.Text;            

            //check to make sure the name is filled in
            if (reservationName != string.Empty)
            {
                if (clickedButton.Text.Equals("Open"))
                {                         
                    MakeReservation(tagValue, reservationName); //If the seat is open, make the reservation
                    ClearTextBox();
                }              
                else
                {
                    //Let user know someone is sitting there
                    lblStatusOut.Text = $"Sorry {clickedButton.Text} is sitting there.  Please select another seat";                   
                }
            }
            else
            {
                //validate there is a name
                lblStatusOut.Text = "Please enter your name is step 2.  Then you can select a seat.";           
            }
        }


        private void radDenver_CheckedChanged(object sender, EventArgs e)
        {

            if (radDenver.Checked)
            {
                piclogo.Load("Cessna.jpg");

                lblFlightInfoOut.Text = flight1.FlightInfo();

                string[] seatChart1 = flight1.GetReservationList();

                if (flight1.IsFull() == false)
                {

                    DisplaySeatingChart(seatChart1);
                }
                else
                {
                    DisplaySeatingChart(seatChart1);
                    lblStatusOut.Text = "Flight " + flight2.Plane + " to " + flight1.Destination + " Is Full";
                }
            }
        }    

        private void radKC_CheckedChanged(object sender, EventArgs e)
        {
            if (radKC.Checked)
            {
                piclogo.Load("Piper.jpg");
                

                //show the flight info

                lblFlightInfoOut.Text = flight2.FlightInfo();

                string[] seatChart2 = flight2.GetReservationList();

                DisplaySeatingChart(seatChart2);

                if (flight2.IsFull() == false)
                {

                    DisplaySeatingChart(seatChart2.ToArray());
                }
                else
                {
                    DisplaySeatingChart(seatChart2.ToArray());
                    lblStatusOut.Text = "Flight " + flight2.Plane + " to " + flight2.Destination + " Is Full";
                }
            }
        }

        //Take in seat number and name to make the reservation
        private void MakeReservation(int seat, string name)
        {
           
           if (radDenver.Checked == true)          
            {
                if (flight1.MakeReservation(name, seat) == true)
                {
                    lblStatusOut.Text = "Seat " + (seat + 1) + " is now Reserved for " + name;                
                    DisplaySeatingChart(flight1.GetReservationList());
                }         
            }
            else if (radKC.Checked == true)
            {

                if (flight2.MakeReservation(name, seat) == true)
                {
                    lblStatusOut.Text = "Seat " + (seat + 1) + " is now Reserved for " + name;
                    DisplaySeatingChart(flight2.GetReservationList());
                }
            }            
        }        
    }
}




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
        List<Flight> flightArray = new List<Flight>();
        //create a flight object 
        Flight flight1 = new Flight("Cessna 1137", "10:00AM", "Denver", 3, 4);
        Flight flight2 = new Flight("Piper 6578", "11:00AM", "Kansas City", 3, 2);
        Button[] buttonArray;

        public Form1()
        {
            InitializeComponent();
            
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
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Create button for each seat bassed on the string[] of names
        private void CreateButtons(string[] seatChart)
        {
            //Cleanr out of the array of buttons to clean the UI
            CleanUIOfButtons();

            //Setting values for UI elements
            int numberOfButtons = seatChart.Count();
            KeyValuePair<int, int> leftLabelTopCorner = new KeyValuePair<int, int>(1598, 624);
            KeyValuePair<int, int> leftButtonTopCorner = new KeyValuePair<int, int>(1776, 615);
            KeyValuePair<int, int> rightLabelTopCorner = new KeyValuePair<int, int>(2126, 615);
            KeyValuePair<int, int> rightButtonTopCorner = new KeyValuePair<int, int>(2303, 615);                        

            int increasePerButton = 40;            
            buttonArray = new Button[numberOfButtons];
            Label[] labelArray = new Label[numberOfButtons];


            //Creating buttons and labels
            for (int x = 0; x <= buttonArray.GetUpperBound(0); x++)
            {   
                //Set properties for button
                buttonArray[x] = new Button();  // This creates a new button and placed it in the array
                buttonArray[x].Text = seatChart[x]; // This adds the text that goes on the button.
                buttonArray[x].Click += new EventHandler(MyHandler); // The button needs a click event handler. This wires up to the method MyHandler.
                buttonArray[x].Tag = x; // you can store all kinds of stuff in the tab property even objects. In this case it is just a number.                
                buttonArray[x].Height = 60;
                buttonArray[x].Width = 350;

                //Set properties for label
                labelArray[x] = new Label();
                labelArray[x].Font = new Font("Microsoft Sans Serif", 10);
                labelArray[x].Text = $"Seat {x + 1} :";
                              
                if ((x + 1) % 2 != 0) //Odd numbers on the left
                {
                    buttonArray[x].Location = new Point(leftButtonTopCorner.Key, leftButtonTopCorner.Value + (x * increasePerButton));
                    labelArray[x].Location = new Point(leftLabelTopCorner.Key, leftLabelTopCorner.Value + (x * increasePerButton));
                }
                else //even numbers onthe right
                {
                    buttonArray[x].Location = new Point(rightButtonTopCorner.Key, rightButtonTopCorner.Value + ((x -1) * increasePerButton));
                    labelArray[x].Location = new Point(rightLabelTopCorner.Key, rightLabelTopCorner.Value + ((x -1) * increasePerButton));
                }
                // Controls.Add(buttonArray[x]); // this adds the button to the controls colection of the form.
            }
           Controls.AddRange(buttonArray);
           Controls.AddRange(labelArray);


            //********* I need something better than this *****///
            this.Refresh();        
        }


        private void CleanUIOfButtons()
        {
            if (buttonArray != null)
            {
                foreach (var button in buttonArray)
                {
                    Controls.Remove(button);
                    button.Dispose();
                }
                Array.Clear(buttonArray, 0, buttonArray.Length);
            }

        }

        private void MyHandler (object sender, EventArgs e)
        {
            Button clickedButton;  // This is a local instance variable for the button that was clicked.
            int tagValue;          // This will hold what we stuffed in the tag of the button.
            string reservationName;

            clickedButton = (Button)sender;  // The sender needs to be cast into a button type
            tagValue = (int)clickedButton.Tag; // Now cast the tag value into a integer
            reservationName = txtName.Text;
            //MessageBox.Show(reservationName+tagValue);

            if (reservationName != string.Empty)
            {
                if (clickedButton.Text.Equals("Open"))
                {
                    lblStatusOut.Text = "This seat is open.  Let's make a reservation";
                    //MessageBox.Show("This seat is open.  Let's make a reservation");
                    MakeReservation(tagValue, reservationName);
                }              
                else
                {
                    lblStatusOut.Text = $"Sorry {clickedButton.Text} is sitting there.  Please select another seat";
                    MessageBox.Show($"Sorry {clickedButton.Text} is sitting there.  Please select another seat");
                }
            }
            else
            {
                lblStatusOut.Text = "Please enter your name is step 2.  Then you can select a seat.";
                MessageBox.Show("Please enter your name is step 2.  Then you can select a seat.");
            }
        }


        private void radDenver_CheckedChanged(object sender, EventArgs e)
        {
            piclogo.Load("Cessna.jpg");
            lblFlightInfoOut.Text = "";
            lblStatusOut.Text = "";
            //show the flight info

            lblFlightInfoOut.Text = flight1.FlightInfo();


            string[] seatChart1 = flight1.GetReservationList();


            if (radDenver.Checked)
            {
                CreateButtons(seatChart1);
            }
                                       
            if (flight1.IsFull() == false)
            {

                CreateButtons(seatChart1);
            }
            else
            {
                CreateButtons(seatChart1);
                lblStatusOut.Text = "Flight " + flight2.Plane + " to " + flight1.Destination + " Is Full";
            }
        }    

        private void radKC_CheckedChanged(object sender, EventArgs e)
        {
            piclogo.Load("Piper.jpg");
            lblStatusOut.Text = "";
            lblFlightInfoOut.Text = "";

            //show the flight info

            lblFlightInfoOut.Text = flight2.FlightInfo();

            string[] seatChart2 = flight2.GetReservationList();
            if(radKC.Checked)
            {
                CreateButtons(seatChart2);
            }
           
            
            if (flight2.IsFull() == false)
            {

                CreateButtons(seatChart2.ToArray());
            }
            else
            {
                CreateButtons(seatChart2.ToArray());
                lblStatusOut.Text = "Flight " + flight2.Plane + " to " + flight2.Destination + " Is Full";
            }
        }

        private void MakeReservation(int seat, string name)
        {
           
           // if (radDenver.Checked == true)
           if(true)
            {
                if (flight1.MakeReservation(name, seat) == true)
                {
                    lblStatusOut.Text = "Seat " + (seat + 1) + " is now Reserved for " + name;
                    MessageBox.Show("Seat " + (seat + 1) + " is now Reserved for " + name) ;
                    CreateButtons(flight1.GetReservationList());
                }
                //if (ValidSelect(lstSeatBox.SelectedIndex) == true)
                //{
                //    seatNum = lstSeatBox.SelectedIndex;
                //    if (flight1.MakeReservation(name, seatNum) == true)
                //    {
                //        lblStatusOut.Text = "Seat " + (seatNum + 1) + " is now Reserved for " + name;
                //        DisplayReservations(flight1.GetReservationList());
                //    }
                //    else
                //    {
                //        lblStatusOut.Text = "Sorry " + name + " Seat " + (seatNum + 1) + " is Taken";
                //    }
                //}

            }
            else if (radKC.Checked == true)
            {
                //if (ValidSelect(lstSeatBox.SelectedIndex) == true)
                //{
                //    seatNum = lstSeatBox.SelectedIndex;
                //    if (flight2.MakeReservation(name, seatNum) == true)
                //    {
                //        lblStatusOut.Text = "Seat " + (seatNum + 1) + " is now Reserved for " + name;
                //        DisplayReservations(flight2.GetReservationList());
                //    }
                //    else
                //    {
                //        lblStatusOut.Text = "Sorry " + name + " Seat " + (seatNum + 1) + " is Taken";
                //    }
                //}
            }
            
        }

        private bool ValidSelect(int SelectedIndex)
        {
            //if (lstSeatBox.SelectedIndex == -1)
            //{
            //    lblStatusOut.Text = "Please Choose a seat from the List";
            //    return false; 
            //}
            return true;
        }

        private bool CheckText(string nameTest)
        {
            if (nameTest.Equals("") || nameTest == null)
            {
                lblStatusOut.Text = "Please Enter your Name";
                return false;
            }
            return true;
        }

      
    }
}




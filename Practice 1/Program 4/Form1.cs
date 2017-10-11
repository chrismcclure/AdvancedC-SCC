/*
 * Chris McClure
 * airline reservation
 * 10/11/17
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program_4
{
    public partial class Form1 : Form
    {
        List<Flight> flightArray = new List<Flight>();
        //create a flight object 
        Flight flight1 = new Flight("Cessna 1137", "10:00AM", "Denver", 3, 4);
        Flight flight2 = new Flight("Piper 6578", "11:00AM", "Kansas City", 3, 2);

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

        public void DisplayReservations(String[] seating)
        {

            //Craete the list of boxes 
            //The coordinates for the lstSeatBox were 1605, 444
            //The Size was 964, 438

            //lstSeatBox.Items.Clear();
            //for (int seat = 0; seat <= seating.GetUpperBound(0); seat++)
            //{

            //    lstSeatBox.Items.Add("Seat: " + (seat + 1) + " " + seating[seat]);
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radDenver_CheckedChanged(object sender, EventArgs e)
        {
            piclogo.Load("Cessna.jpg");
            lblFlightInfoOut.Text = "";
            lblStatusOut.Text = "";
            //show the flight info

            lblFlightInfoOut.Text = flight1.FlightInfo();


            string[] seatChart1 = flight1.GetReservationList();

            if (flight1.IsFull() == false)
            {

                DisplayReservations(seatChart1);
            }
            else
            {
                DisplayReservations(seatChart1);
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

            if (flight2.IsFull() == false)
            {

                DisplayReservations(seatChart2);
            }
            else
            {
                DisplayReservations(seatChart2);
                lblStatusOut.Text = "Flight " + flight2.Plane + " to " + flight2.Destination + " Is Full";
            }
        }

        private void btnNameSubmit_Click(object sender, EventArgs e)
        {
            string name = "";
            int seatNum;
            if (CheckText(txtName.Text) == true)
            {
                name = txtName.Text;


                if (radDenver.Checked == true)
                {
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
                else
                {
                    lblStatusOut.Text = "Please Select a destination at Step 1";
                }
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




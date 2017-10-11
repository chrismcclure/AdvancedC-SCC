
/*
 * Chris McClure
 * airline reservation
 * 10/11/17
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_4
{
    class Flight
    {
        private string mPlane;
        private string mDeparture;
        private string mDestination;
        private int mRows;
        private int mSeatsPerRow;
        private string[] mSeatChart;

        public Flight()
        {

        }
        public Flight(string planeType, string departure, string destination, int numberOfRows, int seatsPerRow)
        {
            this.Plane = planeType;
            this.Departure = departure;
            this.Destination = destination;
            this.NumOfRows = numberOfRows;
            this.SeatsPerRow = seatsPerRow;

            //create the seat chart array
            mSeatChart = new string[NumOfRows * SeatsPerRow];

            //set the seats to open
            for (int seat = 0; seat <= mSeatChart.GetUpperBound(0); seat++)
            {
                mSeatChart[seat] = "Open";
            }
        }
        public bool MakeReservation(string name, int seat)
        {
            if (IsSeatTaken(seat) == false)
            {
                SeatChart[seat] = name;
                
                return true;
            }
            else
            {
                
                return false;
            }

        }

        public bool IsFull()
        {
            for(int x = 0; x <= SeatChart.GetUpperBound(0);x++)
            {
                if(SeatChart[x].Equals("Open"))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsSeatTaken(int seat)
        {
            if(SeatChart[seat].Equals("Open"))
            {
                return false;
            }
            return true;
        }

        public string[] GetReservationList()
        {
            //return the seat chart
            return SeatChart;
        }

        public string FlightInfo()
        {
            string outString = "";
            outString += "Departures:";
            outString += "\n" + Plane + " To " + Destination + " at " + Departure;
            return outString;
        }



        public string Plane
        {
            get { return mPlane; }
            set { mPlane = value; }
        }

        public string Departure
        {
            get { return mDeparture; }
            set { mDeparture = value; }
        }

        public string Destination
        {
            get { return mDestination; }
            set { mDestination = value; }
        }

        public int NumOfRows
        {
            get { return mRows; }
            set { mRows = value; }
        }

        public int SeatsPerRow
        {
            get { return mSeatsPerRow; }
            set { mSeatsPerRow = value; }
        }

        public string[] SeatChart
        {
            get { return mSeatChart; }
            set { mSeatChart = value; }
        }

    }
}


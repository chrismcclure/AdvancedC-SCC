using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_Battle_Ship
{

 /*
* Chris Mcclure
* 11-19-2017
* Battle Ship Program
*/

    #region Enum
    
     //List of all the ships.  Easier than strings and uses intellisense
    public enum ShipType 
    {
        Carrier,
        Battleship,
        Submarine,
        Destroyer,
        Destroyer2
    }

    #endregion


    public class Ship
    {

        #region properties

        public ShipType ShipClass { get; private set; }
        public int Spaces { get; private set; }
        public int Hits { get; private set; }
        public bool Sunk { get; private set; }
        public bool Vertical { get; private set; }     

        #endregion

        #region class fields

        private static readonly Random rand = new Random();

        #endregion

        #region constructor
        //when creating a ship, the name is required
        public Ship(ShipType shipName)
        {
            ShipClass = shipName;
            Hits = 0;
            Sunk = false;
            SetSpaces();
            SetVerticalAlignment();          
        }

        #endregion

        #region public methods

        public void Hit()
        {
            Hits++; //Add one hit
            DidItSink(); //Check to see if the hit sunk it
        }

        #endregion

        #region private methods

        private void DidItSink()
        {
            if (Hits == Spaces)
            {
                Sunk = true;
            }
        }

        private void SetVerticalAlignment()
        {          
            //Generates either 1 or 0. 
            //1 = vertical and 0 = horizontal   
            Vertical = rand.Next(0, 2) == 1;
        }

        private void SetSpaces() //Set the number of hits based on the name
        {
            switch (ShipClass)
            {
                case ShipType.Carrier:
                    Spaces = 5;                 
                    break;
                case ShipType.Battleship:
                    Spaces = 4;
                    break;
                case ShipType.Submarine:
                    Spaces = 3;
                    break;
                case ShipType.Destroyer:
                    Spaces = 2;
                    break;
                case ShipType.Destroyer2:
                    Spaces = 2;
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_Battle_Ship
{
    public class Ship
    {

        #region properties

        public string ShipName { get; private set; }
        public int Spaces { get; private set; }
        public int Hits { get; private set; }
        public bool Sunk { get; private set; }

        #endregion


        #region constructor
        //when creating a ship, the name is required
        public Ship(string shipName)
        {
            shipName = ShipName;
            Hits = 0;
            Sunk = false;
            SetSpaces();
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

        private void SetSpaces() //Set the number of hits based on the name
        {
            switch (ShipName)
            {
                case "Carrier":
                    Spaces = 5;                 
                    break;
                case "BattleShip":
                    Spaces = 4;
                    break;
                case "Submarine":
                    Spaces = 3;
                    break;
                case "Destroyer":
                    Spaces = 2;
                    break;
                default:
                    break;
            }
        }

        #endregion


    }
}

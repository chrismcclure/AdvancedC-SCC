using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/*
* Chris Mcclure
* 11-19-2017
* Battle Ship Program
*/

namespace Project_2_Battle_Ship
{
    public class Sea
    {
        #region propetries
       
        public List<Button> Buttons { get; private set; } //Should be accesable by the form, but not setable
        public List<Ship> Ships { get; private set; } //Should be accesable by the form, but not setable

        public delegate void ShipSunkEventHandler(object source, Ship ship);

        public event ShipSunkEventHandler ShipSunk;

        #endregion


        #region class fields

        private readonly int _numberOfButtons = 400;
        private IDictionary<int, string> _buttonsWithShips;
        private static readonly Random rng = new Random();

        #endregion


        #region constructors

        public Sea(List<Ship> ships)
        {
            Ships = ships;
            Buttons = new List<Button>();
            _buttonsWithShips = new Dictionary<int, string>();
            PlaceTheShips();
            CreateButtons();
        }

        #endregion

        #region public methods

        public void ShowGameBoard()
        {
            for (int i = 0; i < _numberOfButtons; i++)
            {
                //Comment out. This is for testing
                if (DoesButtonHaveShip(i))
                {
                    Buttons[i].Text = "X";              
                }
                else
                {
                    Buttons[i].Text = "";
                }

                Buttons[i].Enabled = false;
            }        
        }
        #endregion


        #region private methods

        //The hard part place the ships on the screen
        private void PlaceTheShips()
       {
            //Place each ship, one by one ¯\_(ツ)_/¯
            foreach (var ship in Ships)
            {                
                //Create a list of purposed spots.  
                List<int> possibleSpots = new List<int>();

                do
                {
                    //random number between 0 and 399
                    int startingSpot = rng.Next(0, _numberOfButtons);

                    //Clear the list in the event this is not the first time through
                    possibleSpots.Clear();

                    //Start with the random spot
                    possibleSpots.Add(startingSpot);
               
                    if (ship.Vertical)
                    {
                        for (int i = 0; i < ship.Spaces -1; i++)
                        {
                            possibleSpots.Add(startingSpot += 20);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < ship.Spaces -1; i++)
                        {
                            possibleSpots.Add(startingSpot += 1);
                        }
                    }
                }
                //Check to see if the spots work, if not, the do it again
                while (IsThePositionGood(possibleSpots, ship) == false);


                //It's good add it to the dictionary of ship positions and move on with life
                foreach (var spot in possibleSpots)
                {
                    _buttonsWithShips.Add(spot, ship.ShipClass.ToString());
                }            
            }
        }


        //Long list of things to make sure the spots of the ships are good
        private bool IsThePositionGood(List<int> possbileSpots, Ship ship)
        {               

            foreach (var spot in possbileSpots)
            {
                //If the spot is take OR is the spot is off the board
                if (_buttonsWithShips.Keys.Contains(spot)  || spot > _numberOfButtons)
                {                 
                    return false;
                }

                //prevent the ship from wrapping around the edges
                //Make sure the ship is horizontal AND the spot doesn't divide by 20 AND it's not the last
                //THEN the numbers are trying to wrap around the edge
                if (ship.Vertical == false && (spot + 1) % 20 == 0 && possbileSpots.Last() != spot)
                {
                    return false;
                }
            }          
            return true; //That means it's good and we can finally move on to the next ship
        }


        //Make all the buttons on the UI
        private void CreateButtons()
        {

            //Where the first buttons goes, each button will build on this
            KeyValuePair<int, int> locationOfButtons = new KeyValuePair<int, int>(10, 10);
            int addToX = 30;
            int addToY = 0;
            int counter = 0;
            for (int i = 0; i < _numberOfButtons; i++)
            {
                //Make all the buttons and give them properties
                Button button = new Button();

                //UNcomment to see all the ships when testing
                //if (DoesButtonHaveShip(i))
                //{
                //    button.Text = "O";
                //}
                //else
                //{
                //    button.Text = "";
                //}

                button.Click += new EventHandler(MyHandler); // The button needs a click event handler. This wires up to the method MyHandler.                
                button.Height = 22;
                button.Width = 22;
                button.Name = "btnSpace" + i.ToString();
                button.BackColor = Control.DefaultBackColor;
                button.Font = new Font(button.Font.FontFamily, 8);
                button.TabStop = false;
                button.Tag = i;


                //Every 20 buttons add to the y location and reset the counter
                if (counter % 20 == 0 && counter != 0)
                {
                    addToY += 28;
                    counter = 0;
                }

                button.Location = new Point(locationOfButtons.Key + (counter * addToX), locationOfButtons.Value + addToY);
                
                Buttons.Add(button);

                counter++;         
            }
        }

        private void MyHandler(object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender;  // The sender needs to be cast into a button type
            int spotClicked = (int)clickedButton.Tag;

            
            //THIS IS THE MEAT.  The ship has been hit. Do stuff!!!
            if (DoesButtonHaveShip(spotClicked))
            {
                //Get the name of the ship in that spot 
                var shipName = _buttonsWithShips.First(x => x.Key == spotClicked).Value;

                //Get the ship objects
                var ship = Ships.First(x => x.ShipClass.ToString() == shipName);     

                //Register hit for shit
                ship.Hit();

                clickedButton.BackColor = Color.Red;

                //Did that sink the ship?  If so, call event
                if (ship.Sunk)
                {
                    //Sent the ship to th UI to list
                    OnShipSunk(ship);                    
                }

                //check to see if all the ships are sunk
                if (Ships.All(x => x.Sunk == true))
                {
                    MessageBox.Show("The game is over! You sank all the ships.");
                }
               
            }
            else
            {
                clickedButton.BackColor = Color.Blue;
            }

            clickedButton.Enabled = false;
            
        }
        

        private bool DoesButtonHaveShip(int spot)
        {
            //Check to see if a ship exists on this spot
            return _buttonsWithShips.Keys.Contains(spot);          
        }


        protected virtual void OnShipSunk(Ship ship)
        {
            //Check to see if there are any subsribers
            if(ShipSunk != null)
            {
                //Send the event
                ShipSunk(this, ship);
            }
        }

        #endregion
    }
}

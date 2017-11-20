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

        #region private methods

        //The hard part place the ships on the screen
        private void PlaceTheShips()
       {           

            foreach (var ship in Ships)
            {                
                //Create a list of purposed spots.  Initiallize with the first purposed spot
                List<int> purposedSpots = new List<int>();
                do
                {
                    int startingSpot = rng.Next(0, 401);
                    purposedSpots.Clear();
                    purposedSpots.Add(startingSpot);
               
                    if (ship.Vertical)
                    {
                        for (int i = 0; i < ship.Spaces -1; i++)
                        {
                            purposedSpots.Add(startingSpot += 20);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < ship.Spaces -1; i++)
                        {
                            purposedSpots.Add(startingSpot += 1);
                        }
                    }
                }
                //Check to see if the spots work, if not, the do it again
                while (IsThePositionGood(purposedSpots, ship) == false);


                //It's good add it to the dictionary of ship positions and move on with life
                foreach (var spot in purposedSpots)
                {
                    _buttonsWithShips.Add(spot, ship.ShipClass.ToString());
                }

                //degbuging spots
                Debug.WriteLine($"{ship.ShipClass} is vertical:{ship.Vertical}with spaces {String.Join(",", purposedSpots.ToArray())}");             

            }
        }


        //Long list of things to make sure the spots of the ships are good
        private bool IsThePositionGood(List<int> purposedSpots, Ship ship)
        {               

            foreach (var spot in purposedSpots)
            {
                //If the spot is take OR is the spot is off the board
                if (_buttonsWithShips.Keys.Contains(spot)  || spot > 399)
                {                 
                    return false;
                }

                //prevent the ship from wrapping around the edges
                //Make sure the ship is horizontal AND the spot doesn't divide by 20 AND it's not the last
                //THEN the numbers are trying to wrap around the edge
                if (ship.Vertical == false && spot % 20 == 0 && purposedSpots.Last() != spot)
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
                button.Text = i.ToString();
                button.Click += new EventHandler(MyHandler); // The button needs a click event handler. This wires up to the method MyHandler.
                
                button.Height = 22;
                button.Width = 22;
                button.Name = "btnSpace" + i.ToString();
                button.BackColor = Control.DefaultBackColor;
                button.Font = new Font(button.Font.FontFamily, 5);

                //This is where I should 
                button.Tag = "notclicked";


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
            string appName = clickedButton.Text;

            //If the button is not clicked then change it to clicked 
            if (clickedButton.Tag.Equals("notclicked"))
            {
                clickedButton.BackColor = Color.ForestGreen;
                clickedButton.Tag = "clicked";


            }
            else
            {
                clickedButton.BackColor = Control.DefaultBackColor;
                clickedButton.Tag = "notclicked";
            }

        }

        #endregion
    }
}

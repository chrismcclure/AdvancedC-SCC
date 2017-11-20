using System;
using System.Collections.Generic;
using System.Windows.Forms;
/*
* Chris Mcclure
* 11-19-2017
* Battle Ship Program
*/


namespace Project_2_Battle_Ship
{
    public partial class Form1 : Form
    {    

        #region class fields

        private Sea _sea;

        #endregion

        #region constructor

        public Form1()
        {
            InitializeComponent();                      
        }

        #endregion


        #region event handlers

        private void btnStart_Click(object sender, EventArgs e)
        {

            //Clears the sunk ship list
            rtbSunkShips.Text = string.Empty;

            //Clears the game board
            CleanUpUI();

            //Create a list of ships
            List<Ship> ships = MakeListOfShips();

            //Initalize sea class and throw the shps into the constructor
            _sea = new Sea(ships);
         
            MakeBoard();

            //Subscribe to the event for the duration of the game
            _sea.ShipSunk += UpdateUIOnShipSunk;
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            //Unsubcribe at the end of the game
            _sea.ShipSunk -= UpdateUIOnShipSunk;

            CleanUpUI();

            //Change the properties of the buttons on the UI
            _sea.ShowGameBoard();

            MakeBoard();
        }

        #endregion


        #region private methods

        private void MakeBoard()
        {
                    
            //Create buttons will all the propteries on the UI
            pnlButtons.Controls.AddRange(_sea.Buttons.ToArray());

        }

        private void CleanUpUI()
        {
            //Clears all the buttson
            pnlButtons.Controls.Clear();
      
        }

        private void UpdateUIOnShipSunk(object source, Ship ship)
        {
            rtbSunkShips.Text += $"{ship.ShipClass} \n";
        }


        private List<Ship> MakeListOfShips()
        {
            //Checks the checkboxes on UI and makes a ship if it is checked
            List<Ship> ships = new List<Ship>();
            if (cbxCarrier.Checked)
            {                           
                ships.Add(new Ship(ShipType.Carrier));         
            }
            if (cbxBattleShip.Checked)
            {
                ships.Add(new Ship(ShipType.Battleship));
            }
            if (cbxSubmarine.Checked)
            {
                ships.Add(new Ship(ShipType.Submarine));
            }
            if (cbxDestroyer1.Checked)
            {
                ships.Add(new Ship(ShipType.Destroyer));
            }
            if (cbxDestroyer2.Checked)
            {
                ships.Add(new Ship(ShipType.Destroyer2));
            }
            return ships;
        }

        #endregion

    
    }
}

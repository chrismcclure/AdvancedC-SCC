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
        #region fields

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
            //Create a list of ships
            List<Ship> ships = MakeListOfShips();

            //Initalize sea class and throw the shps into the constructor
            _sea = new Sea(ships);    

            //Create buttons will all the propteries on the UI
            pnlButtons.Controls.AddRange(_sea.Buttons.ToArray());      
          
        }

        #endregion


        #region private methods

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
                ships.Add(new Ship(ShipType.Destroyer));
            }
            return ships;
        }

        #endregion

    }
}

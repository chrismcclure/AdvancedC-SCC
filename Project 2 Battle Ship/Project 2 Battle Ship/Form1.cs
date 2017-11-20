using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

             _sea = new Sea();      //Initalize sea class    
            pnlButtons.Controls.AddRange(_sea.Buttons.ToArray());      //add the buttons from see class to panel               
        }

        #endregion


        #region event handlers

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Check and see what ships are select
            //Make a list of ships
            //Inject the ship into the constructor of sea to make game board
        }

        #endregion


        #region private methods


        private L

        #endregion

    }
}

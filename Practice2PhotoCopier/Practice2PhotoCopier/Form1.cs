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
 *Chris Mcclure 
 * Photo Copies - practice 2
 * 11-6-17
 */

namespace Practice2PhotoCopier
{
    public partial class Form1 : Form
    {

        private PhotoCopier _photoCopier;

        public Form1()
        {
            InitializeComponent();           
            _photoCopier = new PhotoCopier();// Create new photo copier

            //Set the initial values on UI
            SetTheValuesOnUI();
            btnFixJam.Visible = false;
            txtNumberOfCopies.Focus();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string textBoxInput = txtNumberOfCopies.Text;
            
            //First check to make sure the user input value is a real int
            if (IsValidTextboxForInt(textBoxInput))
            {

                int copies = int.Parse(textBoxInput);
                                
                //I couldn't decide if I should do logic like this in the photocopy class or not? 
                //How much logic should be done on the form vs. in the class?
                int tonersToTake = copies * 5; 

                if (!AreThatManyLeft(copies, _photoCopier.PaperCount))
                {
                    rtbMessages.Text = $"Sorry, you tried to print {copies} copies and there are only {_photoCopier.PaperCount} papers left in the copier.  Add more paper and try again.";
                
                }
                else if (!AreThatManyLeft(tonersToTake, _photoCopier.TonerLevel))
                {
                    rtbMessages.Text = $"Sorry, you tried to use {tonersToTake} toner units and there are only {_photoCopier.TonerLevel} toner units left in the copier.  Replace the toner and try again.";
                }
                else
                {
                    //Everything worked.  Time to do real stuff
                    _photoCopier.MakeCopies(copies);
                    SetTheValuesOnUI();

                    //check to see if it's jammed
                    if (_photoCopier.Jammed)                    
                        JamPrinterUI();                         
                }              
            }
            else
            {
                rtbMessages.Text = "Sorry, you need to input a whole number into number of copies.  Please try again";
                txtNumberOfCopies.SelectAll();
                txtPaperToAdd.Focus();
            }          
        }

        
        private void btnAddPaper_Click(object sender, EventArgs e)
        {                 
            string textBoxInput = txtPaperToAdd.Text;

            //Make sure the number is valid before I try to do stuff with it
            if (IsValidTextboxForInt(textBoxInput))
            {
               
                    _photoCopier.AddPaper(int.Parse(textBoxInput));
                    SetTheValuesOnUI();                                                
            }
            else
            {
                rtbMessages.Text = "Sorry, you need to input a whole number into paper to add.  Please try again";
                txtPaperToAdd.SelectAll();
                txtPaperToAdd.Focus();
            }
        }


        private void btnReplaceToner_Click(object sender, EventArgs e)
        {
            _photoCopier.ReplaceToner();
            SetTheValuesOnUI();
        }

        //Updates values on the UI to match properties of the class
        private void SetTheValuesOnUI()
        {
            lblPaper.Text = _photoCopier.PaperCount.ToString();
            lblToner.Text = _photoCopier.TonerLevel.ToString();
            rtbMessages.Text = _photoCopier.Message;
        }

        private bool IsValidTextboxForInt(string textBoxText)
        {
            string text = textBoxText;
            int number;
            return int.TryParse(text, out number);   
        }

        //Is it possible to take that many away from the current count
        //Make sure that I don't make more copies that I have paper, etc.
        private bool AreThatManyLeft(int take, int from)
        {
            return from - take >= 0 ? true : false;   
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _photoCopier = new PhotoCopier();
            SetTheValuesOnUI();
        }

        //when there is a jam.  Lock up UI and reveal magic fix button 
        private void JamPrinterUI()
        {
            btnReset.Enabled = false;
            btnStart.Enabled = false;
            btnAddPaper.Enabled = false;
            btnReplaceToner.Enabled = false;
            btnFixJam.Visible = true;
            txtPaperToAdd.Text = "";
        }

        //reset the UI and solve all problems
        private void UnJamPrinterUI()
        {
            btnReset.Enabled = true;
            btnStart.Enabled = true;
            btnAddPaper.Enabled = true;
            btnReplaceToner.Enabled = true;
            btnFixJam.Visible = false;
            _photoCopier.Message = "The paper jam is fixed.  Try to make some copies";
            _photoCopier.Jammed = false;
            SetTheValuesOnUI();
            txtNumberOfCopies.SelectAll();
            txtNumberOfCopies.Focus();
        }

        private void btnFixJam_Click(object sender, EventArgs e)
        {
            UnJamPrinterUI();
        }
    }
}

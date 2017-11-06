using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *Chris Mcclure 
 * Photo Copies - practice 2
 * 11-6-17
 */

namespace Practice2PhotoCopier
{
    public class PhotoCopier
    {

        #region properites

        public string Message { get; set; } //Message to show the user
        public int TonerLevel { get; set; }
        public int PaperCount { get; set; }
        public bool Jammed { get; set; } //If the printer is jammed

        #endregion


        #region contructors

        public PhotoCopier()
        {
            //Set the starting levels for the photocopies
            //These could have been passed in via contructor.
            TonerLevel = 2500;
            PaperCount = 500;
        }

        #endregion


        #region public methods

        public void MakeCopies(int copies)
        {
            //Check to see if it works before trying to make copies
            if (IsItJammed())
            {
                Jammed = true;
                Message = $"Opps! Printer is jammed. Hit the magic fix button below to solve all the problems and try printing again.";
                CheckLevels();
            }
            else
            {
                //No jam, do stuff
                DecreaseToner(copies);
                DecreasePaper(copies);
                Message = $"You have successfully made {copies} copies. ";
                CheckLevels();
            }
     
        }

        public void ReplaceToner()
        {
            TonerLevel = 2500;
            Message = $"You have successfully replaced the toner level to {TonerLevel} toner units. ";
            CheckLevels();
        }

        public void AddPaper(int paper)
        {
            IncreasePaper(paper);

            if (paper > 1)            
                Message = $"You have successfully added {paper} papers.";                     
            else
                Message = $"You have successfully added {paper} piece of paper.";

            CheckLevels();
        }

        #endregion


        #region private methods

        private void DecreaseToner(int copies)
        {
            ///Remove 5 units of toner for each piece of paper. That sounds about right ¯\_(ツ)_/¯
            int tonerToRemove = copies * 5;
            TonerLevel -= tonerToRemove;
        }

        //Probably didn't need to be it's own method.  But it is easy to read
        private void DecreasePaper(int copies)
        {
            PaperCount -= copies;
        }

        //Probably didn't need to be it's own method.  But it is easy to read
        private void IncreasePaper(int paper)
        {
            PaperCount += paper;
        }

        //Check the levels.   Don't know how I feel about the hard coded 25%. 
        //I could have used a class level field to set that
        private void CheckLevels()
        {
            if (TonerLevel < 625)
            {
                Message += "\nToner level is less than 25%. Please consider replacing toner!";
            }
            if (PaperCount < 125)
            {
                Message += "\nPaper count is less than 25%. Please consider adding more paper!";
            }
        }

        //In in five chances it will be jammed.  Return if jammed or not
        private bool IsItJammed()
        {
            Random r = new Random();

            //Create a random number between 1 and 5
            int number = r.Next(1, 6); 
         
            //Not a very good printer
            return number % 5 == 0 ? true : false;
        }

        #endregion

    }
}

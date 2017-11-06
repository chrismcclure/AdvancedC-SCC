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
        public bool Jammed { get; set; }

        #endregion


        #region contructors

        public PhotoCopier()
        {
            //Set the starting levels for the photocopies
            TonerLevel = 2500;
            PaperCount = 500;
        }

        #endregion


        #region public methods

        public void MakeCopies(int copies)
        {
            DecreaseToner(copies);
            DecreasePaper(copies);
            Message = $"You have successfully made {copies}. ";
        }

        public void ReplaceToner()
        {
            TonerLevel = 2500;
            Message = $"You have successfully replaced the toner level to {TonerLevel}. ";
        }

        public void AddPaper(int paper)
        {
            IncreasePaper(paper);

            if (paper > 1)            
                Message = $"You have successfully added {paper} papers.";                     
            else
                Message = $"You have successfully added {paper} piece of paper.";       
        }

        #endregion


        #region private methods

        private void DecreaseToner(int copies)
        {
            ///Remove 5 units of toner for each piece of paper. That sounds about right ¯\_(ツ)_/¯
            int tonerToRemove = copies * 5;
            TonerLevel -= tonerToRemove;
        }

        //Depending on how I use it.  I might get rid of this method
        private void DecreasePaper(int copies)
        {
            PaperCount -= copies;
        }

        private void IncreasePaper(int paper)
        {
            PaperCount += paper;
        }
        #endregion

    }
}

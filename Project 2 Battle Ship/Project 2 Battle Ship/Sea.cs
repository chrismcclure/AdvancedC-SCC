using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public class Sea
    {
        public List<Button> Buttons { get; private set; } //Should be accesable by the form, but not setable

        #region constructors

        public Sea()
        {
            Buttons = new List<Button>();
            CreateButtons();
        }
        #endregion

        //Make all the buttons on the UI
        private void CreateButtons()
        {

            //Where the first buttons goes, each button will build on this
            KeyValuePair<int, int> locationOfButtons = new KeyValuePair<int, int>(10, 10);
            int addToX = 30;
            int addToY = 0;
            int counter = 0;
            for (int i = 0; i < 400; i++)
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
    }
}

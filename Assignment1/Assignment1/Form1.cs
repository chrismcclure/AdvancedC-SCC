using Assignment1.CalculationsOfPower;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        //List of all apps
        List<Appliance> applicances;

        //List of all running apps
        //I could have done this a couple different ways, but this seemed easy to manage
        //and easy for someone reading my code to understand
        List<Appliance> running;
        

        public Form1()
        {
            //Get everything in order when the form loads
            InitializeComponent();
            applicances = ApplianceDA.GetApplianceData();
            running = new List<Appliance>();
            CreateButtonsOnUI();
            txtPricePerKWh.Focus();
        }


        //Make all the buttons on the UI
        private void CreateButtonsOnUI()
        {
            //Check to make my list of object is good to go
            if (applicances != null)
            {
                //Where the first buttons goes, each button will build on this
                KeyValuePair<int, int> locationOfButtons = new KeyValuePair<int, int>(25, 25);
                int addToX = 200;
                int addToY = 0;
                int counter = 0;
                foreach (var appliance in applicances)
                {
                  
                    //Make all the buttons and give them properties
                    Button button = new Button();
                    button.Text = appliance.ApplicanceName;
                    button.Click += new EventHandler(MyHandler); // The button needs a click event handler. This wires up to the method MyHandler.

                    //This seemed kind of hacky to me and wish I could have thought of a better way to do this
                    //Tried to use a bool, but 
                    //intellisense thought this should be a string in the event handler ¯\_(ツ)_/¯
                    button.Tag = "notclicked";           
                    button.Height = 30;
                    button.Width = 175;                    
                    button.Name = "btnAppliance-" + applicances.IndexOf(appliance);
                    button.BackColor = Control.DefaultBackColor;

                    //Create new tool tip and set it
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(button, $"{appliance.Watts.ToString()} Watts");

                    //Every 3 buttons add to the y location and reset the counter
                    if (counter % 3 ==  0 && counter != 0)
                    {
                        addToY += 50;
                        counter = 0;
                    }                   
                    button.Location = new Point(locationOfButtons.Key + (counter * addToX), locationOfButtons.Value + addToY);
                                 
                    //Add to the panel
                    pnlButtonHolder.Controls.Add(button);
                    counter++;

                    //for testing locations
                    Debug.WriteLine($"Counter {counter} button X:{button.Location.X} button Y: {button.Location.Y}");
                }
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

                //add the applicance to list of running applicances
                AddToListOfRunningApps(appName);

            }
            else
            {
                clickedButton.BackColor = Control.DefaultBackColor;
                clickedButton.Tag = "notclicked";

                //Remove from running apps
                RemoveFromListOfRunningApps(appName);
            }

            //Change the text in the UI
            DisplayOutputInTextboxes();
        }
        private void DisplayOutputInTextboxes()
        {
            //Get the input from the users for Price Per Killowatt
            string userInput = txtPricePerKWh.Text;
            double cost;
            bool isValidInput = Double.TryParse(userInput, out cost);

            if (isValidInput)
            {

                //Create an output object and send the running app to the calculation class for business
                Output output = new Calculation().CalculateOutput(running, cost);


                //Set the values of all the text boxes on UI    
                txtCurrentWatage.Text = output.CurrentWattage.ToString();
                txtCostPerHour.Text = output.CostPerHour.ToString("C");
                txtCostPerDay.Text = output.CostPerDay.ToString("C");
                txtCostPerYear.Text = output.CostPerYear.ToString("C");

            }

            else
            {
                MessageBox.Show("Please input a valid double format.");
                txtPricePerKWh.Focus();
            }
        }

      

        private void AddToListOfRunningApps(string appName)
        {
            running.Add(applicances.Where(x => x.ApplicanceName.Equals(appName))
                              .FirstOrDefault());
        }
        private void RemoveFromListOfRunningApps(string appName)
        {
            running.Remove(applicances.Where(x => x.ApplicanceName.Equals(appName))
                              .FirstOrDefault());
        }
    }
}

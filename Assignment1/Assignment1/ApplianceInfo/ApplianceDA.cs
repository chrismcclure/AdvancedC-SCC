using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

/*
 * Chris Mcclure
 * 10-29-2017
 * Appliance Power Program
 */

namespace Assignment1
{
    public static class  ApplianceDA
    {
        //return appliances in a list of objects
        public static List<Appliance> GetApplianceData()
        {
            List<Appliance> appliancesObjects = new List<Appliance>();
            string filePath = @"..\..\ApplianceInfo\Watts.csv";

            try
            {
                //get all the applicances into a list of strings
                List<string> appliances = File.ReadAllLines(filePath).ToList();                        

                foreach (string appliance in appliances)
                {
                    //loop through the applicance and create Appliance objects from strings
                    appliancesObjects.Add(new Appliance()
                    {
                        ApplicanceName = appliance.Split(',').FirstOrDefault(),
                        Watts = int.Parse(appliance.Split(',').LastOrDefault())
                    });
                }
          
            }
            //Catch the system IO error. Display error to user and if we were logging errors that would be done.
            //Instead I just logged it to the debug console
            //set the list to null
            catch (IOException e)
            {
                System.Windows.Forms.MessageBox.Show("Unable to access document of appliances.  Please check file path in ApplianceDA");
                Debug.WriteLine("Error Message: " + e.Message);
                appliancesObjects = null;
            }
            
            return appliancesObjects;
        }
    }
}

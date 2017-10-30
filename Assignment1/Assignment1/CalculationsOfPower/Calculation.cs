using System.Collections.Generic;
using System.Linq;

namespace Assignment1.CalculationsOfPower
{

    /*
 * Chris Mcclure
 * 10-29-2017
 * Appliance Power Program
 */

    public class Calculation
    {

        public Output CalculateOutput(List<Appliance> runningApps, double pricePerKWattHour)
        {            
            if (runningApps.Count > 0 && pricePerKWattHour != 0)
            {
                //Do math.  Hopefully I did it right
                int totalWatts = runningApps.Sum(x => x.Watts);
                double pricePerWattHour = (pricePerKWattHour / 10) * (totalWatts / 100);      
                double pricePerDay = pricePerWattHour * 24;
                double pricePerYear = pricePerDay * 365;

                //return a brand new output object with final numbers
                return new Output()
                {          
                    CurrentWattage = totalWatts,
                    CostPerHour = pricePerWattHour,
                    CostPerDay = pricePerDay,
                    CostPerYear = pricePerYear
                };
            }
            else
            {
                //If the list is empty all calcuations are 0
                return new Output()
                {                  
                    CurrentWattage = 0,
                    CostPerHour = 0,
                    CostPerDay = 0,
                    CostPerYear = 0
                };
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Chris McClure
 * Pizza Store
 * 12-10-17
 */

namespace PizzaStore_Project.ProductClasses
{
    class Promotional : Product
    {

        public Promotional()
        {
            SetPrice();
            SetDescription();
        }

        protected override void SetDescription()
        {
            Description = "Pizza is Cheesy - T-shirt";
        }

        protected override void SetPrice()
        {
            Price = 19.99m;
        }    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_Project.ProductClasses
{
    class Special : Product
    {

        public Special()
        {
            SetPrice();
            SetDescription();
        }

        protected override void SetDescription()
        {
            Description = "Large Pizza with Green Peppers, Drink, and Salad";
        }

        protected override void SetPrice()
        {
            Price = 19.99m;
        }
    }
}

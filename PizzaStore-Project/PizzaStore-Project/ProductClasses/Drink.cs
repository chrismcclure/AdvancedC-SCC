using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_Project.ProductClasses
{
    class Drink : Product
    {

        public Drink()
        {
            SetPrice();
            SetDescription();
        }

        protected override void SetDescription()
        {
            Description = "Drink";
        }

        protected override void SetPrice()
        {
            Price = 1.99m;
        }
    }
}

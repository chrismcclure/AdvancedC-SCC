using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_Project.ProductClasses
{
    class Salad : Product
    {

        public Salad()
        {
            SetPrice();
            SetDescription();
        }

        protected override void SetDescription()
        {
            Description = "Salad";
        }

        protected override void SetPrice()
        {
            Price = 9.99m;
        }
    }    
}


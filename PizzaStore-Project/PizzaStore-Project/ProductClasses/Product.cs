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

namespace PizzaStore_Project
{
    public abstract class Product
    {
        #region Properties

        public string  Description { get; set; }
        public decimal Price { get; set; }
        public int ProductID { get; set; }

        #endregion

        #region Constructor

        public static int id = 1;

        public Product()
        {
            ProductID = id;
            id++;            
        }
        #endregion


        #region protect abstract methods

        protected abstract void SetPrice();            
        protected abstract void SetDescription();

        #endregion

        #region vitrual methods     

        public virtual string GetFinalOutput()
        {
            return $"{Description} is ${Price}";
        }
        #endregion

    }
}

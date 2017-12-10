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
    interface IOrder
    {

        #region Methods

        decimal CalculateSubTotal();
        decimal CalculateTax();
        decimal TotalOrder();
        void AddItem(Product product);
        void DeleteItem(int indexToRemove);
        void SaveOrder();

        #endregion

    }
}

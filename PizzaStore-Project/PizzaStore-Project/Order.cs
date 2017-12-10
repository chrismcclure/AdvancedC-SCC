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
    public class Order :IOrder
    {

        #region Properties

        public List<Product> products { get; private set; }     

        #endregion

        #region Fields

        private readonly decimal _taxRate = .0725m;
        #endregion

        #region Contructor

        public Order()
        {
            products = new List<Product>();
        }
        #endregion


        #region public methods
      
        public void AddItem(Product product)
        {
            products.Add(product);   
        }

        public void DeleteItem(int indexToRemove)
        {
            products.RemoveAt(indexToRemove);
        }

        public decimal CalculateTax()
        {          
            return Math.Round(products.Sum(x => x.Price) * _taxRate, 2);
        }
      
        public void SaveOrder()
        {
            new DAClass()
                .Save(new InvoiceItem()
                {
                    OrderTotal = TotalOrder(),
                    DateOfInvoice = DateTime.Now
                });   
        }

        public decimal CalculateSubTotal()
        {
            return products.Sum(x => x.Price);
        }

        public decimal TotalOrder()
        {
            return  products.Sum(x => x.Price) + CalculateTax();
        }

       

        #endregion
    }
}

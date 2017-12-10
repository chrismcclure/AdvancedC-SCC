using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Chris McClure
 * Pizza Store
 * 12-10-17
 */

namespace PizzaStore_Project.ProductClasses
{
    class Pizza : Product
    {
        #region fields
        private string _size;
        private List<string> _toppings;
        private GroupBox _groupBox;

        //50 cents a topping
        private decimal _toppingCost = .5m;
        #endregion

        #region Constructor
        public Pizza(GroupBox groupBox)
        {
            _groupBox = groupBox;         
            SetPrice();
            SetDescription();
  
        }
        #endregion


        protected override void SetDescription()
        {
            if (!_toppings.Any())
            {
                Description = $"Pizza, size {_size}, toppings: None";
            }
            else
            {
                Description = $"Pizza, size {_size}, toppings: {String.Join(",", _toppings)}";
            }
           
        }

        protected override void SetPrice()
        {
            GetToppings();
            GetSize();
            //Set base price for size
            switch (_size)
            {
                case "Small":
                    Price = 10.00m;
                    break;
                case "Medium":
                    Price = 11.00m;
                    break;
                case "Large":
                    Price = 12.00m;
                    break;
                default:
                    break;
            }

            //Add the cost of toppings
            Price += _toppings.Count * _toppingCost;
        }

        private void  GetToppings()
        {
            List<string> toppings = new List<string>();
            foreach (Control c in _groupBox.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                    toppings.Add(c.Text);
            }
            _toppings = toppings;
        }

        private void GetSize()
        {
            foreach (Control c in _groupBox.Controls)
            {
                if ((c is RadioButton) && ((RadioButton)c).Checked)
                    _size = c.Text;
            }          
        }
    }
}

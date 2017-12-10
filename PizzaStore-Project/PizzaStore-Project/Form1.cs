using PizzaStore_Project.ProductClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Chris McClure
 * Pizza Store
 * 12-10-17
 */

namespace PizzaStore_Project
{
    public partial class Form1 : Form
    {

        Order order;

        public Form1()
        {
            InitializeComponent();
            order = new Order();

        }

        #region event handlers

        private void btnAdd_Click(object sender, EventArgs e)
        {      
            var product = GetSelectedProduct();

            if (product != null)
            {
                order.AddItem(GetSelectedProduct());
                UpdateUI();
            }          
        }

        private void btnRemoveFromOrder_Click(object sender, EventArgs e)
        {

            int numberToBeRemove = lbxOrderedItems.SelectedIndex;

            if (numberToBeRemove != -1)
            {
                order.DeleteItem(numberToBeRemove);
                UpdateUI();
            }
            else
            {
                MessageBox.Show("Please select an item from the list to remove!");
            }
        }
        #endregion



        #region private methods

        private void UpdateUI()
        {
            ClearUIElements();
            lblSubTotal.Text = $"${order.CalculateSubTotal().ToString()}";
            LblTax.Text = $"${order.CalculateTax().ToString()}";
            lblTotal.Text = $"${order.TotalOrder().ToString()}";
            lbxOrderedItems.DataSource = null;
            lbxOrderedItems.DataSource = order.products.Select(x => x.GetFinalOutput()).ToList();
        }
       

        private Product GetSelectedProduct()
        {
            if (rbPizza.Checked)
                return new Pizza(grpPizza);
            else if (rbDrinks.Checked)
                return new Drink();
            else if (rbSalads.Checked)
                return new Salad();
            else if (rbCoolStuff.Checked)
                return new Promotional();
            MessageBox.Show("Please select an item before adding it to the order.");
            return null;
        }         

        private void ClearUIElements()
        {
            foreach (Control c in grpPizza.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                    ((CheckBox)c).Checked = false;
            }
            rbSmall.Checked = true;
        }

        #endregion

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            order.SaveOrder();
            //Make a new order now
            order = new Order();
            UpdateUI();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
    public class DAClass
    {
       
        public void Save(InvoiceItem invoiceItem)
        {
            //Using entity framework. So easy
            var row = new Invoice();

            row.Date = invoiceItem.DateOfInvoice;
            row.BranchName = invoiceItem.BranchName;
            row.OrderTotal = invoiceItem.OrderTotal;

            using (ProductsEntities db = new ProductsEntities())
            {

                db.Invoices.Add(row);
                db.SaveChanges();
            }                
        }
       
    }
}

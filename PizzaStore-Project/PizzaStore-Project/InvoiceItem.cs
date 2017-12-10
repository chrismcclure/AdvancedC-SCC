using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_Project
{
    public class InvoiceItem
    {
        public DateTime DateOfInvoice { get; set; }
        public string BranchName { get; set; } = "Chris McClure Pizza";
        public decimal OrderTotal { get; set; }
    }
}

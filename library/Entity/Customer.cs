using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Entity
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }

        public int CustomerTypeId { get; set; }
        public string CustomerName { get; set; }
        public string Sex { get; set; }
        public DateTime DoB {  get; set; }
        public string PoB { get; set; }
        
        public string Phone { get; set; }
        public string Address { get; set; }
        public int IsHidden { get; set; }
    }
}

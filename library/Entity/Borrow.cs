using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Entity
{
    public class Borrow
    {
        public int BorrowId { get; set; }
        public int IsHidden { get; set; }
        public int CustomerId { get; set; }
        public int LibrarianId { get; set; }
        public DateTime BorrowDate { get; set; }
        public string BorrowCode { get; set; }
        public int DepositAmount { get; set; }
        public DateTime DueDate { get; set; }
        public double FineAmount { get; set; }
        public string MeMo {  get; set; }

    }
}

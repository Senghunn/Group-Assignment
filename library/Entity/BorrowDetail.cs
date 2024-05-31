using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Entity
{
        public class BorrowDetail
        {
            public int BorrowDetailId { get; set; }
            public int BorrowId { get; set; }
            public int BookId { get; set; }
            public string Note { get; set; }
            public int? IsReturn { get; set; }

            public DateTime? ReturnDate { get; set; }
        }
}

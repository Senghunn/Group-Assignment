using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Entity
{
    public class Book
    {
        public int BookId { get; set; }
        public int IsHidden {  get; set; }
        public int CatalogId { get; set; }
        public string BookCode { get; set; }
        public string BookDescription { get; set; }
    }
}

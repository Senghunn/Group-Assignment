using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Entity
{
    public class Catalog
    {
        public int CatalogId { get; set; }
        public int IsHidden { get; set; }
        public string CatalogCode { get; set; }
        public string CatalogName { get; set; }
        public string Isbn { get; set; }
        public string AuthorName { get; set; }
        public string Publisher {  get; set; }
        public string PublishYear { get; set; }
        public string PublishEdition { get; set; }


    }
}

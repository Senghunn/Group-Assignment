using System;

namespace library.Data
{
    public class Librarian
    {
        public int LibrarianId { get; set; }
        public string LibrarianName { get; set; }
        public string LibrarianCode { get; set; }
        public string Sex { get; set; }
        public DateTime DoB { get; set; }
        public string PoB { get; set; }
        public string Phone { get; set; }

        public int IsHidden { get; set; }

       
    }
}

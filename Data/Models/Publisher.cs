using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace books.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation propertie
        public List<Book> Books { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitaplik_2.Entities
{
    public class Category
    {
        internal static Category category;

        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Book> Books { get; set; }
    }
}

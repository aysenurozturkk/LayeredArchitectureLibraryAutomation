using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitaplik_2.Entities
{
  public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int  AuthorId { get; set; }
        public Author Author { get; set; }
        public int  PublisherId { get; set; }
        public Publisher Publisher { get; set; }

    }
}

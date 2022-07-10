﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models.DataModels
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}

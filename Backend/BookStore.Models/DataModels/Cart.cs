using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models.DataModels
{
    public partial class Cart
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public int Bookid { get; set; }
        public int Quantity { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}

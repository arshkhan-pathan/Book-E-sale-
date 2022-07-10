using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models.DataModels
{
    public partial class Book
    {
        public Book()
        {
            Carts = new HashSet<Cart>();
            Orderdtls = new HashSet<Orderdtl>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Base64image { get; set; }
        public int Categoryid { get; set; }
        public int? Publisherid { get; set; }
        public int? Quantity { get; set; }

        public virtual Category Category { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Orderdtl> Orderdtls { get; set; }
    }
}

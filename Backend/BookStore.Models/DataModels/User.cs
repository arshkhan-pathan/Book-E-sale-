using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models.DataModels
{
    public partial class User
    {
        public User()
        {
            Carts = new HashSet<Cart>();
            Ordermsts = new HashSet<Ordermst>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Roleid { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Ordermst> Ordermsts { get; set; }
    }
}

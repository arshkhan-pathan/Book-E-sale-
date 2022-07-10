using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models.DataModels
{
    public partial class Ordermst
    {
        public Ordermst()
        {
            Orderdtls = new HashSet<Orderdtl>();
        }

        public int Id { get; set; }
        public int? Userid { get; set; }
        public DateTime? Orderdate { get; set; }
        public decimal? Totalprice { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Orderdtl> Orderdtls { get; set; }
    }
}

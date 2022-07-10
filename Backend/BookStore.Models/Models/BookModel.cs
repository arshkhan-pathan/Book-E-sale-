using BookStore.Models.DataModels;

namespace BookStore.Models.Models
{
    public class BookModel
    {
        public BookModel() { }
        public BookModel(Book book)
        {
            Id = book.Id;
            Name = book.Name;
            Price = book.Price;
            Description = book.Description;
            //Base64image = book.Base64image;
            Categoryid = book.Categoryid;
            Publisherid = book.Publisherid;
            Quantity = book.Quantity;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Base64image { get; set; }
        public int Categoryid { get; set; }
        public int? Publisherid { get; set; }
        public int? Quantity { get; set; }
    }
}

using BookStore.Models.DataModels;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Models
{
    public class CategoryModel
    {
        public CategoryModel() { }
        public CategoryModel(Category category)
        { 
            Id = category.Id;
            Name = category.Name;
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}

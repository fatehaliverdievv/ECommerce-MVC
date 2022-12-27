namespace Aspnetsiu.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Img { get; set;   }
        public int CategoryId { get; set; }
        public Category Category { get; set; }  
        public ICollection<Size> Sizes { get; set; }
        public ICollection<Color> Colors { get; set; }
    }
}

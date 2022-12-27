namespace Aspnetsiu.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}

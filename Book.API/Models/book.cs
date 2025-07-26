namespace Book.API.Models
{
    public class book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CoverUrl { get; set; }
        public int Stock { get; set; }

        // Foreign Keys
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}

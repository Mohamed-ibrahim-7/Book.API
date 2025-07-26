namespace Book.API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<book> Books { get; set; }
    }
}

namespace Book.API.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        public ICollection<book> Books { get; set; }
    }
}

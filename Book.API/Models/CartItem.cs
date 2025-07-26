namespace Book.API.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int BookId { get; set; }
        public book Book { get; set; }

        public int Quantity { get; set; }
    }
}

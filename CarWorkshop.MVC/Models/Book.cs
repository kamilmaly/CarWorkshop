namespace CarWorkshop.MVC.Models
{
    public class Book
    {
        public string? Title { get; set; }
        public string? Description { get; set; }

        public List<string> Tags { get; set; } 
    }
}

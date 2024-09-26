namespace BooksApplication.WebAPI.DTOs.Book
{
    public class BookDTO
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public string Year { get; set; }
        public BookDTO()
        {
            
        }
    }
}

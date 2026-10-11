namespace library_tracking_system.Entities
{

    public class Book
    {
        public required string BookTitle { get; set; }
        public required string BookAuthor { get; set; }
        public required string BookGenre { get; set; }

        public int BookPageNumber { get; set; }
        public bool IsAvailable { get; set; }

        public override string ToString()
        {
            return $"{BookTitle} | {BookAuthor} | {BookGenre} | {BookPageNumber} pages | {(IsAvailable ? "Available" : "Borrowed")}";
        }
    }
}

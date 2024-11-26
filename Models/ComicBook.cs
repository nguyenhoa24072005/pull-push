using System;

namespace ComicRentalSystem.Models
{
    public class ComicBook
    {
        public int ComicBookID { get; set; }

        // Đảm bảo thuộc tính Title và Author không được null
        public required string Title { get; set; }
        public required string Author { get; set; }

        public decimal Price { get; set; }
    }
}

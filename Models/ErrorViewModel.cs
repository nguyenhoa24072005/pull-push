namespace ComicRentalSystem.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; } = string.Empty;

        public ErrorViewModel()
        {
            // Đảm bảo RequestId có giá trị mặc định khi đối tượng được khởi tạo
            RequestId = string.Empty;
        }
    }
}

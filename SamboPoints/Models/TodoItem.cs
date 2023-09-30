namespace SamboPoints.Models
{
    public class TodoItem
    {
        public string Todo { get; set; } = string.Empty;
        public DateTime? DateAndTime { get; set; } = DateTime.Now;
    }
}

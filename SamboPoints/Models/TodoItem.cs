namespace SamboPoints.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Todo { get; set; } = string.Empty;
        public DateTime? DateAndTime { get; set; } = DateTime.Now;
    }
}

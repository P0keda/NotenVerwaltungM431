namespace NotenVerwaltung.Frontend.DTOs
{
    public class MarkAdjustmentDTO
    {
        public int Id { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public double OldMark { get; set; }
        public double NewMark { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime RequestDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Ausstehend";
    }
}
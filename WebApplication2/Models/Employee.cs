namespace WebApplication2.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string EmployeeName { get; set; }
        public DateTime StarTimeUtc { get; set; }
        public DateTime EndTimeUtc { get; set; }
        public string EntryNotes { get; set; }
        public DateTime? DeletedOn { get; set; }

        // Calculated property for total time worked
        public double TotalTimeWorked => (EndTimeUtc - StarTimeUtc).TotalHours;
    }
}

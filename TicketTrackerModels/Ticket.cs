using System.ComponentModel.DataAnnotations;

namespace TicketTrackerModels
{
    public class Ticket
    {
        [Required, Key]
        public int Id { get; set; }
        [Required, StringLength(250)]
        public string Issue { get; set; }
        [Required, StringLength(3000)]
        public string Description { get; set; }
        [Required, StringLength(3000)]
        public string Resolution { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        [Required]
        public Priority Priority { get; set; }
        [Required]
        public Status Status { get; set; }
        [Required, StringLength(64)]
        public string TicketCreatedBy { get; set; }
        public string TechAssigned { get; set; }
        [Required, Range(0,500)]
        public double HoursOfLabor { get; set; }
        [Required]
        public string StakeholderEmails { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace TaskManagementApp.Models
{
    public enum TaskStatus
    {
        Pending,
        InProgress,
        Completed
    }

    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public string Status { get; set; }

        public string Remarks { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? LastUpdatedOn { get; set; }

        public int CreatedById { get; set; }

        public string? CreatedByName { get; set; }

        public int? LastUpdatedById { get; set; }

        public string? LastUpdatedByName { get; set; }
    }
}
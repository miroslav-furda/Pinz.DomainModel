using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Pinzonline.DomainModel
{
    public interface ITask
    {
        [Key]
        Guid TaskId { get; set; }

        [Required]
        string TaskName { get; set; }

        string Body { get; set; }

        bool IsComplete { get; set; }

        [Required]
        DateTime CreationTime { get; set; }

        DateTime? DateCompleted { get; set; }

        DateTime? StartDate { get; set; }

        DateTime? DueDate { get; set; }

        int ActualWork { get; set; }

        [Required]
        TaskStatus Status { get; set; }

        TaskPriority Priority { get; set; }

        [Required]
        Guid CategoryId { get; set; }

        Guid UserId { get; set; }
    }
}

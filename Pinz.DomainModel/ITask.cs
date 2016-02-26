using System;

namespace com.Pinzonline.DomainModel
{
    public interface ITask
    {
        Guid TaskId { get; set; }

        string TaskName { get; set; }

        string Body { get; set; }

        bool IsComplete { get; set; }

        string Owner { get; set; }

        DateTime CreationTime { get; set; }

        DateTime? DateCompleted { get; set; }

        DateTime? StartDate { get; set; }

        DateTime? DueDate { get; set; }

        int ActualWork { get; set; }

        TaskStatus Status { get; set; }

        string Priority { get; set; }

        string Companies { get; set; }

        Guid CategoryId { get; set; }

        ICategory Category { get; set; }

    }
}

using System;
using System.Collections.Generic;

namespace com.Pinzonline.DomainModel
{
    public interface ICategory
    {
        Guid CategoryId { get; set; }

        string CategoryName { get; set; }

        List<ITask> Tasks { get; set; }
    }
}

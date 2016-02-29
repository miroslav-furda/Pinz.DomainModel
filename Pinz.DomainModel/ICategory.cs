using System;

namespace com.Pinzonline.DomainModel
{
    public interface ICategory
    {
        Guid CategoryId { get; set; }

        string CategoryName { get; set; }

        Guid ProjectId { get; set; }
        IProject Project { get; set; }
    }
}

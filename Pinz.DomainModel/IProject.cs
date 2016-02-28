using System;
using System.Collections.Generic;

namespace com.Pinzonline.DomainModel
{
    public interface IProject
    {
        Guid ProjectId { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        List<ICategory> Categories { get; set; }
    }
}

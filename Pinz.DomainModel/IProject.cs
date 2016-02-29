﻿using System;

namespace com.Pinzonline.DomainModel
{
    public interface IProject
    {
        Guid ProjectId { get; set; }
        string Name { get; set; }
        string Description { get; set; }

        Guid WorkGroupId { get; set; }
        IWorkGroup WorkGroup { get; set; }
    }
}

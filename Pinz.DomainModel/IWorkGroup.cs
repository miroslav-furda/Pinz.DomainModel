using System;

namespace com.Pinzonline.DomainModel
{
    public interface IWorkGroup
    {
        Guid WorkGroupId { get; set; }

        string Name { get; set; }
        string Description { get; set; }

        Guid CompanyId { get; set; }
        ICompany Company { get; set; }
    }
}

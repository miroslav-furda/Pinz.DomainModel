using System;

namespace com.Pinzonline.DomainModel
{
    public interface IUser
    {
        Guid UserId { get; set; }
        string Name { get; set; }

        Guid WorkGroupId { get; set; }
        IWorkGroup WorkGroup { get; set; }
    }
}

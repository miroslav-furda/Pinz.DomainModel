using System;

namespace Com.Pinz.DomainModel
{
    public interface IProjectUser : IUser
    {
        Boolean IsProjectAdmin { get; set; }
    }
}

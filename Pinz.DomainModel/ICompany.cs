using System;

namespace com.Pinzonline.DomainModel
{
    public interface ICompany
    {
        Guid ComapnyId { get; set; }
        string Name { get; set; }
    }
}

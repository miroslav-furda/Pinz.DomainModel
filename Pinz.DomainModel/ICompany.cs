using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Pinzonline.DomainModel
{
    public interface ICompany
    {
        [Key]
        Guid ComapnyId { get; set; }

        [Required]
        string Name { get; set; }
    }
}

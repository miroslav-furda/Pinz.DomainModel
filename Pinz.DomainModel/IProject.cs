using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Pinzonline.DomainModel
{
    public interface IProject
    {
        [Key]
        Guid ProjectId { get; set; }

        [Required]
        string Name { get; set; }

        string Description { get; set; }

        [Required]
        Guid CompanyId { get; set; }
    }
}

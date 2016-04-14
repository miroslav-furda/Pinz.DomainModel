using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Pinz.DomainModel
{
    public interface ICategory
    {
        [Key]
        Guid CategoryId { get; set; }

        [Required]
        string Name { get; set; }

        [Required]
        Guid ProjectId { get; set; }
    }
}


using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Pinzonline.DomainModel
{
    public interface IProjectStaff
    {
        [Key]
        string EMail { get; set; }

        [Key]
        Guid ProjectId { get; set; }
        
        [Required]
        Boolean IsProjectAdmin { get; set; }
    }
}

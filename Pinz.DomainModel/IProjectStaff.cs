
using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Pinz.DomainModel
{
    public interface IProjectStaff
    {
        [Key]
        Guid UserId { get; set; }

        [Key]
        Guid ProjectId { get; set; }
        
        [Required]
        Boolean IsProjectAdmin { get; set; }
    }
}

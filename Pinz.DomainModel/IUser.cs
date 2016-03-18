using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Pinzonline.DomainModel
{
    public interface IUser
    {
        [Key]
        string EMail { get; set; }

        string FirstName { get; set; }

        string FamilyName { get; set; }

        [Required]
        Guid CompanyId { get; set; }
    }
}

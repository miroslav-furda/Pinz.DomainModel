using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Pinz.DomainModel
{
    public interface IUser
    {
        [Key]
        Guid UserId { get; set; }

        [Required]
        string EMail { get; set; }

        string FirstName { get; set; }

        string FamilyName { get; set; }

        [Required]
        Guid CompanyId { get; set; }
    }
}

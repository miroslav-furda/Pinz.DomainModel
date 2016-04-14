using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Pinz.DomainModel
{
    public interface ICompany
    {
        [Key]
        Guid CompanyId { get; set; }

        [Required]
        string Name { get; set; }
    }
}

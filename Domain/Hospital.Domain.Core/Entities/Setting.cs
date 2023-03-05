using Hospital.Domain.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain.Core.Entities
{
    [Table("Setting", Schema = "Gnr")]
    public class Setting : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Key { get; set; }

        [Required]
        [MaxLength(200)]
        public string Value { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }


    }
}

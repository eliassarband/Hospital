using Hospital.Domain.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Entities
{
    [Table("Room", Schema = "Gnr")]
    public class Room : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [ForeignKey("RoomTypeId")]
        public int? RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }

        [Required]
        public int Rest { get; set; }

        [Required]
        public int Cost { get; set; }

        public bool NotInUse { get; set; }

        public virtual ICollection<IPDRegisteration> IPDRegisterations { get; set; }

        public virtual ICollection<Bed> Beds { get; set; }

    }
}

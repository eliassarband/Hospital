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
    [Table("Bed", Schema = "Gnr")]
    public class Bed : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [ForeignKey("RoomId")]
        public int? RoomId { get; set; }
        public virtual Room Room { get; set; }
                
        public bool NotInUse { get; set; }

        public virtual ICollection<IPDRegisteration> IPDRegisterations { get; set; }

        public virtual ICollection<IPDRegisterationRoom> IPDRegisterationRooms { get; set; }

    }
}

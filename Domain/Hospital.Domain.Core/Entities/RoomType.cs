﻿using Hospital.Domain.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Entities
{
    [Table("RoomType", Schema = "Gnr")]
    public class RoomType : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Floor { get; set; }

        [Required]
        [ForeignKey("WardId")]
        public int? WardId { get; set; }
        public virtual BasicInformation Ward { get; set; }

        public bool NotInUse { get; set; }

        public virtual ICollection<IPDRegisteration> IPDRegisterations { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }

    }
}

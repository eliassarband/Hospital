using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Domain.Core.Entities.Base;

namespace Hospital.Domain.Core.Entities
{
    [Table("Attachment", Schema = "Gnr")]
    public class Attachment : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(10)]
        public string Extension { get; set; }

        [MaxLength(50)]
        public string ContentType { get; set; }

        public byte[] Content { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
    }
}

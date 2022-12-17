using Hospital.Domain.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Entities
{
    [Table("BasicInformation", Schema = "Gnr")]
    public class BasicInformation : BaseEntity
    {
        public int Code { get; set; }

        [MaxLength(50)]
        public string StrCode { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public virtual BasicInformationCategory Category { get; set; }

        public int Priority { get; set; }

        [ForeignKey("RelatedBasicInformationId")]
        public int? RelatedBasicInformationId { get; set; }
        public virtual BasicInformation RelatedBasicInformation { get; set; }

        public bool Active { get; set; }

        public bool IsDeleted { get; set; }

        public bool AllowChange { get; set; }

        public bool AllowDelete { get; set; }

        public virtual ICollection<BasicInformation> BasicInformations { get; set; }
    }
}

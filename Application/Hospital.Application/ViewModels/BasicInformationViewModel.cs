using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.ViewModels
{
    public class BasicInformationViewModel
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string StrCode { get; set; }
        public string Name { get; set; }
        public BasicInformationCategoryViewModel Category { get; set; }
        public int CategoryId { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public int Priority { get; set; }
        public int RelatedBasicInformationId { get; set; }
        public int RelatedBasicInformationCode { get; set; }
        public string RelatedBasicInformationStrCode { get; set; }
        public string RelatedBasicInformationName { get; set; }
        public BasicInformationViewModel RelatedBasicInformation { get; set; }
        public bool Active { get; set; }
        public bool IsDeleted { get; set; }
        public bool AllowChange { get; set; }
        public bool AllowDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
        public virtual ICollection<BasicInformationViewModel> BasicInformations { get; set; }
    }
}

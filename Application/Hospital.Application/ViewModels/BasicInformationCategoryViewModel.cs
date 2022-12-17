using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.ViewModels
{
    public class BasicInformationCategoryViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Viewable { get; set; }
        public BasicInformationCategoryViewModel RelatedCategory { get; set; }
        public int RelatedCategoryId { get; set; }
        public string RelatedCategoryCode { get; set; }
        public string RelatedCategoryName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
        public virtual ICollection<BasicInformationCategoryViewModel> BasicInformationCategories { get; set; }
        public virtual ICollection<BasicInformationViewModel> BasicInformations { get; set; }
    }
}

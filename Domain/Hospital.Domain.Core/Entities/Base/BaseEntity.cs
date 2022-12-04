namespace Hospital.Domain.Core.Entities.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public string? CreatedUser { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string? ModifiedUser { get; set; }

        public BaseEntity()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }
}

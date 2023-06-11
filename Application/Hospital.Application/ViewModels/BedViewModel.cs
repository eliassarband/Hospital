using Hospital.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.ViewModels
{
    public class BedViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int RoomId { get; set; }
        public string RoomCode { get; set; }
        public string RoomName { get; set; }
        public virtual RoomViewModel? Room { get; set; }

        public int RoomTypeId { get; set; }
        public string RoomTypeCode { get; set; }
        public string RoomTypeName { get; set; }
        public virtual RoomTypeViewModel? RoomType { get; set; }

        public int WardId { get; set; }
        public int WardCode { get; set; }
        public string WardName { get; set; }
        public virtual BasicInformationViewModel? Ward { get; set; }

        public bool NotInUse { get; set; }

        public virtual ICollection<IPDRegisterationRoomViewModel> IPDRegisterationRooms { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedUser { get; set; }
    }
}

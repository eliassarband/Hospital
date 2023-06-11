using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Application.ViewModels
{
    public class FreeBedViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int FreeBeds { get; set; } = 0;
        public int BusyBeds { get; set; } = 0;
        public bool Busy { get; set; } = false;
    }
}

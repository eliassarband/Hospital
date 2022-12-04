using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Domain.Core.Entities;

namespace Hospital.Application.Responses
{
    
    public class CommandResponse
    {
        public int Id { get; set; }
        public ResultType ResultType { get; set; }
        public string ResultMessage { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dtos.Request
{
    public class MovieReq
    {
       
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Title { get; set; }

        public float Score { get; set; }

        public int Year { get; set; }

        public int Duration { get; set; }

        public required string Country { get; set; }

        public required string Director { get; set; }
    }
}

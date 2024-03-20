using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dtos.Response
{
    public class GetAllMovieResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public float Score { get; set; }

        public int Year { get; set; }

        public int Duration { get; set; }

        public string Country { get; set; }

        public string Director { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }




    }
}

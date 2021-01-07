using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE.Models
{    public class RatingEntry
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieId { get; set; }
        public int UserRating { get; set; }
        public double Rated { get; set; }
        public int Votes { get; set; }

    }
}

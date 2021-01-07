using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE.Models
{
    public class Movie
    {
        public string Id { get; set; }
        public string Rank { get; set; }
        public string Title { get; set; }
        public List<string> Genre { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public List<string> Actors { get; set; }
        public int Year { get; set; }
        public int Runtime { get; set; }
        public double Rating { get; set; }
        public int Votes { get; set; }
        public string Poster { get; set; }
    }
}

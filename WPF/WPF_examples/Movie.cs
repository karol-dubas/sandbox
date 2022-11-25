using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_examples
{
    public class Movie
    {
        public string Name { get; set; } = "Matrix";
        public short Year { get; set; } = 1999;
        public List<string> Cast { get; set; } = new List<string> { "Keanu Reeves", "Laurence Fishburne", "Carrie-Anne Moss" };
        public long HoursWatched { get; set; } = 20000;
    }
}

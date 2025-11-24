using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ass_1.Model
{
    internal class Route
    {
        public int Id { get; set; }
        public string Classification { get; set; }

        public string Origin { get; set; }
        public string Destination { get; set; }
        public double Distance { get; set; }


        public ICollection<AssignedRoute> AssignedRoutes { get; set; } = new HashSet<AssignedRoute>();
    }

}

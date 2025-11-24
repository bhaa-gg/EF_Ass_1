using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ass_1.Model
{
    internal class AirCraft
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }



        [ForeignKey(nameof(Airline))]
        public int AirlineId { get; set; } 
        public Airline Airline { get; set; } = null!;

        public Crew Crew { get; set; } = null!;

        public ICollection<AssignedRoute> AssignedRoutes { get; set; } = new HashSet<AssignedRoute>();

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ass_1.Model
{
    [PrimaryKey(nameof(AirCraftId) , nameof(RouteId))]
    internal class AssignedRoute
    {

        [ForeignKey(nameof(AirCraft))]
        public int AirCraftId { get; set; }
        public AirCraft AirCraft { get; set; } = null!;


        [ForeignKey(nameof(Route))]
        public int RouteId { get; set; } 
        public Route Route { get; set; } = null!;



        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public double Duration { get; set; }
        public double Price { get; set; }
        public int NumOfPassengers { get; set; }

    }
}

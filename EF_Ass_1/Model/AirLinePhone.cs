using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ass_1.Model
{
    internal class AirLinePhone
    {
        public int Id { get; set; }

        public string PhoneNumber { get; set; } = null!;

        [ForeignKey(nameof(Airline))]
        public int AirlineId { get; set; }

        public Airline Airline { get; set; } = null!;
    }
}

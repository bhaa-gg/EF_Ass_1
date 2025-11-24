using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ass_1.Model
{
    internal class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public string Description { get; set; }
        public decimal Amount { get; set; }

        public int AirlineId { get; set; }
        public Airline Airline { get; set; } = null!;


        public override string? ToString()
        {
            return $"Transaction Id: {Id}, Date: {Date:yyyy-MM-dd}, Description: {Description}, " +
                   $"Amount: {Amount:C}, AirlineId: {AirlineId}";
        }
    }
}

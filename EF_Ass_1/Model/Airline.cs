using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ass_1.Model
{
    internal class Airline
    {
        public int Id { get; set; }

        public string ?Address { get; set; }
        public string Name { get; set; }
        public string ? ContactPerson { get; set; }
        public ICollection<AirLinePhone> Phones { get; set; } = new HashSet<AirLinePhone>();



        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

        public ICollection<Transaction> Transactions { get; set; } = new HashSet<Transaction>();

        public ICollection<AirCraft> AirCrafts { get; set; } = new HashSet<AirCraft>();

    }


}

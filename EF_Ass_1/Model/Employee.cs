using EF_Ass_1.Constant;
using EF_Ass_1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ass_1
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public string  Position { get; set; }
        public string Gender { get; set; }
        public string? Address { get; set; }
        public string ? Qualifications{ get; set; }


        public  Birthday Birthday { get; set; } = null!;

        [ForeignKey(nameof(Airline))]
        public int AirlineId { get; set; }
        public Airline Airline { get; set; } = null!;


        public override string? ToString()
        {
            return $"Employee Id: {Id}, Name: {Name}, Position: {Position}, Gender: {Gender}, " +
                   $"Address: {Address}, Qualifications: {Qualifications}, " +
                   $"Birthday: {Birthday.Day}/{Birthday.Month}/{Birthday.Year}, AirlineId: {AirlineId}";
        }

    }
}

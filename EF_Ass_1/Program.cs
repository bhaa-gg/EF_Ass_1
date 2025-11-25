using EF_Ass_1.Constant;
using EF_Ass_1.DbContexts;
using EF_Ass_1.Model;
using Microsoft.EntityFrameworkCore;

namespace EF_Ass_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                using AirlineDbContext DbContext = new AirlineDbContext();


            #region Q1
            //Airline airline = new Airline()
            //{
            //    Name = "EgyptAir",
            //    ContactPerson = "Ahmed Ali",
            //    Address = "Cairo",
            //    Phones = new HashSet<AirLinePhone>{
            //        new AirLinePhone { PhoneNumber = "0123456789" },
            //        new AirLinePhone { PhoneNumber = "0113654789" },
            //        }
            //};

            //DbContext.AirLines.Add(airline);
            //DbContext.SaveChanges();
            #endregion

            #region Q2
            //try { 
            //AirCraft airCraft = new AirCraft()
            //{
            //    Model= "Model01",
            //    Capacity=180,
            //    AirlineId= 22
            //};
            //DbContext.AirCrafts.Add(airCraft);
            //DbContext.SaveChanges();
            //}catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion


            #region Q3
            //try
            //{
            //    Transaction transaction = new Transaction()
            //    {
            //        Amount = 5000,
            //        Description = "Tickets",
            //        AirlineId = 2,
            //        Date = DateTime.Now
            //    };
            //    DbContext.Transactions.Add(transaction);
            //    DbContext.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Q4

            //var employees = new List<Employee>
            //{
            //    new Employee
            //    {
            //        Name = "Ahmed Ali",
            //        Position = "Pilot",
            //        Gender = Gender.Male.ToString(),
            //        Address = "123 Cairo St.",
            //        Qualifications = "Commercial Pilot License",
            //        Birthday = new Birthday { Day = 15, Month = 5, Year = 1985 },
            //        AirlineId = 2
            //    },
            //    new Employee
            //    {
            //        Name = "Sara Mahmoud",
            //        Position = "Flight Attendant",
            //        Gender = Gender.Female.ToString(),
            //        Address = "45 Alexandria Rd.",
            //        Qualifications = "Cabin Crew Certification",
            //        Birthday = new Birthday { Day = 20, Month = 8, Year = 1992 },
            //        AirlineId = 2
            //    },
            //    new Employee
            //    {
            //        Name = "Omar Hossam",
            //        Position = "Engineer",
            //        Gender = Gender.Male.ToString(),
            //        Address = "77 Giza Blvd.",
            //        Qualifications = "Aerospace Engineering",
            //        Birthday = new Birthday { Day = 3, Month = 12, Year = 1988 },
            //        AirlineId = 2
            //    }
            //};
            //try
            //{
            //    //DbContext.Employees.AddRange(employees);
            //    //DbContext.SaveChanges();

            //    var  airline = DbContext.AirLines
            //        .Include(a => a.Employees)
            //        .FirstOrDefault(a => a.Name == "EgyptAir");

            //    Console.WriteLine(string.Join("\n-----------------\n" , airline?.Employees));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("General error: " + ex.Message);
            //}
            #endregion

            #region Q5
            //try
            //{
            //     var transactions = DbContext.Transactions
            //.Where(t => t.Airline.Name == "EgyptAir")
            //.Select(t => new
            //{
            //    t.Id,
            //    t.Description,
            //    t.Amount
            //});
            //Console.WriteLine(string.Join("\n-----------------\n" , transactions));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("General error: " + ex.Message);
            //}
            #endregion


            #region Q6
            //try
            //{

            //    var data = DbContext.Employees.GroupBy(E => E.Airline.Name)
            //    .Select(d => new {
            //        Airline  =d.Key,
            //        EmployeeCount = d.Count()
            //    });

            //    Console.WriteLine(string.Join("\n-----------------\n", data));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("General error: " + ex.Message);
            //}
            #endregion


            #region Q7
            //try
            //{
            // var  aircraft= DbContext.AirCrafts.FirstOrDefault(t => t.Model== "Model01");

            //    if( aircraft is not null)
            //    {
            //        aircraft.Capacity = 200;
            //        DbContext.SaveChanges();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("General error: " + ex.Message);
            //}
            #endregion

            #region Q8
            //try
            //{

            //    var transactions = DbContext.Transactions.Where(T => T.Date.Year < 2020);
            //    if (transactions.Any())
            //    {
            //    DbContext.Transactions.RemoveRange(transactions);
            //    DbContext.SaveChanges();
            //    Console.WriteLine("DeletedSucces");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("General error: " + ex.Message);
            //}
            #endregion


            #region Q9

            //try {    
            //    DbContext.Routes.Add(new Route
            //    {
            //        Classification = "International",
            //        Origin = "Cairo",
            //        Destination = "Dubai",
            //        Distance = 2400
            //    });
            //    DbContext.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("General error: " + ex.Message);
            //}

            #endregion

            #region Q10
            //var assignedRoute1 = 

            //try
            //{
            //    DbContext.AssignedRoutes.Add(new AssignedRoute
            //    {
            //        AirCraftId = 1,
            //        RouteId = 1,
            //        Departure = DateTime.Now,
            //        Arrival = new DateTime(2026, 1, 15, 12, 45, 0),
            //        Duration = 4,
            //        Price = 3000,
            //        NumOfPassengers = 120
            //    });
            //    DbContext.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("General error: " + ex.Message);
            //}



            #endregion
        }
    }
}

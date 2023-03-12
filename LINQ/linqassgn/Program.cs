using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqassgn
{
    class Employee
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public string Title;
        public DateTime DOB;
        public DateTime DOJ;
        public string City;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee{ EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title="Manager", DOB=DateTime.Parse("16/11/1984"), DOJ=DateTime.Parse("8/6/2011"), City="Mumbai"},
                new Employee{ EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title="AsstManager", DOB=DateTime.Parse("20/08/1984"), DOJ=DateTime.Parse("7/7/2012"), City="Mumbai"},
                new Employee{ EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title="Consultant", DOB=DateTime.Parse("14/11/1987"), DOJ=DateTime.Parse("12/4/2015"), City="Pune"},
                new Employee{ EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title="SE", DOB=DateTime.Parse("3/6/1990"), DOJ=DateTime.Parse("2/2/2016"), City="Pune"},
                new Employee{ EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title="SE", DOB=DateTime.Parse("8/3/1991"), DOJ=DateTime.Parse("2/2/2016"), City="Mumbai"},
                new Employee{ EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title="Consultant", DOB=DateTime.Parse("7/11/1989"), DOJ=DateTime.Parse("8/8/2014"), City="Chennai"},
                new Employee{ EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title="Consultant", DOB=DateTime.Parse("2/12/1989"), DOJ=DateTime.Parse("1/6/2015"), City="Mumbai"},
                new Employee{ EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title="Associate", DOB=DateTime.Parse("11/11/1993"), DOJ=DateTime.Parse("6/11/2014"), City="Chennai"},
                new Employee{ EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title="Associate", DOB=DateTime.Parse("12/8/1992"), DOJ=DateTime.Parse("3/12/2014"), City="Chennai"},
                new Employee{ EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title="Manager", DOB=DateTime.Parse("12/4/1991"), DOJ=DateTime.Parse("2/1/2016"), City="Pune"}
            };

         
            var mydata = from a in emplist
                         select a;
            Console.WriteLine("********************************** Q3.(A).Display detail of all the employee ***************************************\n");
            Console.WriteLine(" ");
            foreach (Employee e in mydata)
            {
                Console.WriteLine($"Employee id: {e.EmployeeID} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB.ToString("dd-MMM-yyyy")} | DOJ: {e.DOJ.ToString("dd-MMM-yyyy")} | City: {e.City}");
            }
            //Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("************************ Q3.(B).Display details of all the employee whose location is not Mumbai *********************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            
            Console.WriteLine(" ");
            IEnumerable<Employee> linqoperation = from a in emplist
                                                  where a.City != "Mumbai"
                                                  select a;
            foreach (Employee e in linqoperation)
            {
                Console.WriteLine($"Employee id: {e.EmployeeID} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB.ToString("dd-MMM-yyyy")} | DOJ: {e.DOJ.ToString("dd-MMM-yyyy")} | City: {e.City}");
            }
            //Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("************************ Q3.(C). Display details of all the employee whose title is AsstManager *********************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine(" ");
            linqoperation = from a in emplist
                            where a.Title == "AsstManager"
                            select a;
            foreach (Employee e in linqoperation)
            {
                Console.WriteLine($"Employee id: {e.EmployeeID} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB.ToString("dd-MMM-yyyy")} | DOJ: {e.DOJ.ToString("dd-MMM-yyyy")} | City: {e.City}");
            }

            //Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("************************ Q3.(D). Display details of all the employee whose Last Name start with S *********************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine(" ");
            linqoperation = from a in emplist
                            where a.LastName.StartsWith("S")
                            select a;
            foreach (Employee e in linqoperation)
            {
                Console.WriteLine($"Employee id: {e.EmployeeID} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB.ToString("dd-MMM-yyyy")} | DOJ: {e.DOJ.ToString("dd-MMM-yyyy")} | City: {e.City}");
            }

            //Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("************************ Q3.(E). Display a list of all the employee who have joined before 1/1/2015 *********************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            linqoperation = from a in emplist
                            where a.DOJ < DateTime.Parse("1/1/2015")
                            select a;
            foreach (Employee e in linqoperation)
            {
                Console.WriteLine($"Employee id: {e.EmployeeID} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB.ToString("dd-MMM-yyyy")} | DOJ: {e.DOJ.ToString("dd-MMM-yyyy")} | City: {e.City}");
            }

            //Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("************************ Q3.(F). Display a list of all the employee whose date of birth is after 1/1/1990 *********************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            linqoperation = from a in emplist
                            where a.DOB > DateTime.Parse("1/1/1990")
                            select a;
            foreach (Employee e in linqoperation)
            {
                Console.WriteLine($"Employee id: {e.EmployeeID} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB.ToString("dd-MMM-yyyy")} | DOJ: {e.DOJ.ToString("dd-MMM-yyyy")} | City: {e.City}");
            }

            //Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("************************ Q3.(G). Display a list of all the employee whose designation is Consultant and Associate *********************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            linqoperation = from a in emplist
                            where a.Title == "Consultant" || a.Title == "Associate"
                            select a;
            foreach (Employee e in linqoperation)
            {
                Console.WriteLine($"Employee id: {e.EmployeeID} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB.ToString("dd-MMM-yyyy")} | DOJ: {e.DOJ.ToString("dd-MMM-yyyy")} | City: {e.City}");
            }

            //Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("************************ Q3.(H). Display total number of employees *********************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            var res = from a in emplist
                      select a;
            Console.WriteLine($"Total Employee : {res.Count()}");

            //Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("************************ Q3.(I).  Display total number of employees belonging to “Chennai” *********************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            res = from a in emplist
                  where a.City == "Chennai"
                  select a;
            Console.WriteLine($"total : {res.Count()}");

            //Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("************************ Q3.(J). Display highest employee id from the list *********************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            var highest = emplist.Max(e => e.EmployeeID);
            Console.WriteLine(highest);

            //Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("************************ Q3.(K). Display total number of employee who have joined after 1/1/2015 *********************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            res = from a in emplist
                  where a.DOJ > DateTime.Parse("1/1/2015")
                  select a;
            Console.WriteLine($"Total : {res.Count()}");

            //Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("************************ Q3.(L).Display total number of employee whose designation is not “Associate” *********************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            res = from a in emplist
                  where a.Title != "Associate"
                  select a;
            Console.WriteLine($"Total : {res.Count()}");

            //Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("************************ Q3.(M).Display total number of employee based on City *********************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            var groups = from a in emplist.GroupBy(a => a.City)
                         select new
                         {
                             Cityname = a.First().City,
                             citycount = a.Count()
                         };
            foreach (var e in groups)
            {
                Console.WriteLine($"city name : {e.Cityname} | total employee {e.citycount}");
            }

            //Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("************************ Q3.(N).Display total number of employee based on city and title *********************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            var groupcity = from a in emplist.GroupBy(a => a.City)
                            select new
                            {
                                Cityname = a.First().City,
                                title = a.First().Title,
                                count = a.Count()
                            };

            foreach (var e in groupcity)
            {
                Console.WriteLine($"cityname: {e.Cityname} | title: {e.title} | count: {e.count}");
            }

            //Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("************************ Q3.(O).Display total number of employee who is youngest in the list *********************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            res = from a in emplist
                  where a.DOB > DateTime.Parse("1/1/1992")
                  select a;
            Console.WriteLine($"total {res.Count()}");

            Console.ReadLine();



















        }

    }

}
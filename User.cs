using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
     public class User
    {
        private static int id = 1;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
        public string NotRobotCode { get; set; }
       
        public enum RegistrationMonth { January,February,March,April,May,June,July,August,September,October,November,December}
        public RegistrationMonth Month { get; set; }
        public User(string name, string surname, string notRobotCode,RegistrationMonth month)
        {
            Name = name;
            Surname = surname;
            Id = id++;
            NotRobotCode = notRobotCode;
            Month = month;
        }
        public (int,string,string,RegistrationMonth) GetDetails()

    {
            if (Extension.CheckNotRobotCode(NotRobotCode))
            {
                return (Id, Surname, Name, Month);
            }
            else
            {
                Console.WriteLine("not correct");
                {
                    return (Id, Surname, Name, Month);
                }
            }

    }
  }
}

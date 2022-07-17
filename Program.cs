using System;
namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Madina", "Novruzova", "S4FL", User.RegistrationMonth.January);
            User user2 = new User("Aysel", "Orucova", "D2NB", User.RegistrationMonth.October);
            User user3 = new User("Huseyn", "Ahmedov", "AFD3", User.RegistrationMonth.March);
            User user4 = new User("Aysu", "Aliyeva", "H2FB", User.RegistrationMonth.November);
            User user5 = new User("Murad", "Agayev", "SJ5X", User.RegistrationMonth.December);

            Console.WriteLine(user1.GetDetails());
            Console.WriteLine(user2.GetDetails());
            Console.WriteLine(user3.GetDetails());
            Console.WriteLine(user4.GetDetails());
            Console.WriteLine(user5.GetDetails());
            
        }
    }
}
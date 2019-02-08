using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, mobileNumber, address, dateOfBirth;
            int age;

            Console.WriteLine("Please give you Information");
            Console.WriteLine("============================");
            Console.Write("First Name                : ");
            firstName = Console.ReadLine();
            Console.Write("Last Name                 : ");
            lastName = Console.ReadLine();
            Console.Write("Age                       : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Date of Birth(DD/MM/YYYY) : ");
            dateOfBirth = Console.ReadLine();
            Console.Write("Mobile Number             : ");
            mobileNumber = Console.ReadLine();
            Console.Write("Address                   : ");
            address = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine(firstName+" "+lastName+"'s Personal Information");
            Console.WriteLine("================================");
            Console.WriteLine("Full Name     : "+firstName+" "+lastName);
            Console.WriteLine("Age           : "+age);
            Console.WriteLine("Date of Birth : "+dateOfBirth);
            Console.WriteLine("Mobile Number : "+mobileNumber);
            Console.WriteLine("Address       : "+address);

            Console.ReadKey();
        }
    }
}

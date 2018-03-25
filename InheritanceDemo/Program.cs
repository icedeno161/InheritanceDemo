using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Worker("Bob", 35.00);
            var joe = new Manager("Joe", true);
            var sally = new Worker("Sally", 27.50);

            var employees = new List<Employee>()
            {
                bob,
                joe,
                sally
            };

            foreach (var item in employees)
            {
                item.TakeVacation();
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Collection3
    {

       public  static void Main(String [] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Name = "Shivam", Salary = 10000 });
            list.Add(new Employee() { Name = "Jay", Salary = 10000 });
            list.Add(new Employee() { Name = "Ajay", Salary = 10000 });
            list.Add(new Employee() { Name = "Banti", Salary = 500000 });
            list.Add(new Employee() { Name = "Lucy", Salary = 8000 });

            // Uses IComparable.CompareTo()
            list.Sort();

            // Uses Employee.ToString
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.Read();
        }

        class Employee : IComparable<Employee>
        {
            public int Salary { get; set; }
            public string Name { get; set; }

            public int CompareTo(Employee other)
            {
                // Alphabetic sort if salary is equal. [A to Z]
                if (this.Salary == other.Salary)
                {
                    return this.Name.CompareTo(other.Name);
                }
                // Default to salary sort. [High to low]
                return other.Salary.CompareTo(this.Salary);
            }

            public override string ToString()
            {
                // String representation.
                return  this.Name + " , " + this.Salary.ToString() ;
            }

        }
    }
}

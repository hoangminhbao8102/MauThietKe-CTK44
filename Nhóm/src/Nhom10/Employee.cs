using System;

namespace Nhom10
{
    public class Employee : IUser
    {
        public string Name { get; set; }

        public void DisplayRole()
        {
            Console.WriteLine($"{Name} is an Employee.");
        }
    }
}

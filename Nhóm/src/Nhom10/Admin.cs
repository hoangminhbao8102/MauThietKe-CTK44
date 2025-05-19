using System;

namespace Nhom10
{
    public class Admin : IUser
    {
        public string Name { get; set; }

        public void DisplayRole()
        {
            Console.WriteLine($"{Name} is an Admin.");
        }
    }
}

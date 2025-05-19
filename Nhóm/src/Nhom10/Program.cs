using System;

namespace Nhom10
{
    class Program
    {
        static void Main()
        {
            var subject = new Subject();
            var logger = new Logger();
            subject.Attach(logger);

            var userService = new UserService(subject);

            Console.WriteLine("Adding Admin...");
            userService.AddUser("Admin", "Alice");

            Console.WriteLine("Adding Employee...");
            userService.AddUser("Employee", "Bob");

            Console.ReadKey();
        }
    }
}

using System;

namespace Nhom10
{
    public class UserFactory
    {
        public static IUser CreateUser(string type, string name)
        {
            switch (type)
            {
                case "Admin":
                    return new Admin { Name = name };
                case "Employee":
                    return new Employee { Name = name };
                default:
                    throw new ArgumentException("Invalid user type");
            }
        }
    }
}

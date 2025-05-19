using System;

namespace Nhom10
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private static readonly object _lock = new object();

        private DatabaseConnection()
        {
            Console.WriteLine("Database connected.");
        }

        public static DatabaseConnection GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new DatabaseConnection();
                }
            }
            return _instance;
        }

        public void SaveUser(IUser user)
        {
            Console.WriteLine($"User {user.Name} saved to database.");
        }
    }
}

using System;

namespace Nhom10
{
    public class Logger : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
}

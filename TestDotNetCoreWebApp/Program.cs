using System;

namespace TestDotNetCoreWebApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello CIBS World!");

            new CriticalTests().MyIntegrationTest();
        }
    }
}

using System;

namespace CSharpTraits
{
    class Program
    {
        static void Main()
        {
            var lc = new LoggableClass()
                .FirstOperation()
                .SecondOperation();

            Console.ReadLine();
        }
    }
}

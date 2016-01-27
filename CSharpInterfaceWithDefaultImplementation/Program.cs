using System;

namespace CSharpInterfaceWithDefaultImplementation
{
    public interface ILogger
    {
        void Log(object @object);
    }

    public static class LoggerTrait
    {
        public static void Log(this ILogger logger, object @object, bool @default)
        {
            Console.WriteLine("Default: " + @object);
        }
    }


    class DefaultLogger : ILogger
    {
        public void Log(object @object)
        {
            this.Log(@object, @default: true);
        }
    }

    class RedefinedLogger : ILogger
    {
        public void Log(object @object)
        {
            Console.WriteLine("Redefinedlogger: " + @object);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var logger = new DefaultLogger();
            logger.Log("1");

            var redef = new RedefinedLogger();
            redef.Log("2");

            Console.ReadLine();
        }
    }
}


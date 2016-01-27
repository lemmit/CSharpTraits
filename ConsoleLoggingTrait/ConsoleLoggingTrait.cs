using System;

namespace 
    LoggingTrait
{
    public static class ConsoleLoggingTrait
    {
        public static void Log(this ILoggingTrait @this, object @object)
        {
            Console.WriteLine(@object);
        }
    }
}

using System.Diagnostics;

namespace LoggingTrait
{
    public static class DummyLoggingTrait
    {
        public static void Log(this ILoggingTrait @this, object @object)
        {
            Debug.WriteLine(@object);
        }
    }
}

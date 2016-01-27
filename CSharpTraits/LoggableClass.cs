using LoggingTrait;

namespace CSharpTraits
{
    public class LoggableClass : ILoggingTrait
    {
        public LoggableClass()
        {
            this.Log("LoggableClass created");
        }

        public LoggableClass FirstOperation()
        {
            this.Log("LoggableClass firstOperation");
            return this;
        }

        public LoggableClass SecondOperation()
        {
            this.Log("LoggableClass secondOperation");
            return this;
        }
    }
}

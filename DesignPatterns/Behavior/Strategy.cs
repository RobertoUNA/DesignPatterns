using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior
{
    public interface Logger
    {
        void Write(string message);
    }

    public class ConsoleLog : Logger
    {
        public void Write(string message)
        {
           Console.WriteLine(message);
        }
    }

    public class APILog : Logger
    {
        public void Write(string message)
        {
            //Api logic
        }
    }
}

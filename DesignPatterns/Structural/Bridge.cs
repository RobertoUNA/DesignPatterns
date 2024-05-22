using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural
{
    // Logic Implementations
    public interface ISendingMethod
    {
        void SendMessage();
    }

    public class Email : ISendingMethod
    {
        public void SendMessage() { Console.WriteLine("Sent by email"); }
    }

    public class Fax : ISendingMethod
    {
        public void SendMessage() { Console.WriteLine("Sent by Fax"); }
    }

    // Abstractions 
    public abstract class Message
    {
        public ISendingMethod sendingMethod;
        public Message(ISendingMethod sendingMethod)
        {
            this.sendingMethod = sendingMethod;
        }
        // here the object will call the method 
        // according with the implementation that we have decided
        public abstract void Send();
    }

    public class PdfFile : Message
    {
        public PdfFile(ISendingMethod sendingMethod) : base(sendingMethod) { }
        public override void Send()
        {
           sendingMethod.SendMessage();
        }
    }

    public class WorldFile : Message
    {
        public WorldFile(ISendingMethod sendingMethod) : base(sendingMethod) { }
        public override void Send()
        {
            sendingMethod.SendMessage();
        }
    }

}

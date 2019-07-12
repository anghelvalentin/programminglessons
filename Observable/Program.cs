using System;

namespace Observable
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel();
            Computer computer = new Computer();
            Person person = new Person();
            channel.AddObserver(computer);
            channel.AddObserver(person);

            channel.Notify(new Message() { Text = "Hello World", Importance = 10 });
        }
    }
}

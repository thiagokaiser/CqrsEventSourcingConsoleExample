using System;
using System.Collections.Generic;

namespace CqrsEventSourcing
{
    public class Person
    {
        private int age;

    }
    public class EventBroker
    {
        public IList<Event> AllEvents = new List<Event>();

    }
    public class Event
    {

    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var p = new Person();
            
        }
    }
}

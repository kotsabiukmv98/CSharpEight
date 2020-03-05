/*
 * You can now add members to interfaces and provide an implementation for those members.
 * Often use-case: post factum adding new members to exicting API
 */
 using System;

namespace DefaultInterfaceMethods
{
    public interface IHuman
    {
        string Name { get; set; }

        void SayHello()
        {
            Console.WriteLine($"Hello, I am {Name}");
        }
    }

    public interface IFriendlyHuman : IHuman
    {
        void IHuman.SayHello()
        //new void SayHello()
        {
            Console.WriteLine($"Greeting, my name is {Name}");
        }
    }

    public class Human : IFriendlyHuman
    {
        public string Name { get; set; }
    }

    public class DefaultInterfaceMethods
    {
        public static void Demo()
        {
            var human = new Human() { Name = "John" };
            //human.SayHello(); // Will not compile

            IHuman human1 = new Human() { Name = "John" };
            human1.SayHello();

            ((IHuman)human).SayHello();


            //var h = new NewHuman();
            //(h as IHuman).SayHello();
        }
    }
    //public interface IHumbleHuman : IHuman
    //{
    //    void IHuman.SayHello()
    //    {
    //        Console.WriteLine($"Hello");
    //    }
    //}
    //public class NewHuman : IFriendlyHuman, IHumbleHuman
    //{
    //    public string Name { get; set; }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

using System;

namespace CastingBetweenTypes
{
    class Program
    {
        static void Main(string[] args)
        {// object is the highest level in C# of the hierachry
            Object apple = new Apple("Granny Smith", 0.6);
            Apple granny = (Apple)apple;// assign the apple to an object which is the top level of a base class
            //Apple apple = new Apple("Macintosh", .5); previous option new option above created an object
            Console.WriteLine("Type: {0}, cost per dozen: {1}{2}", granny.Kind, granny.GetCost(), Environment.NewLine);
        }
    }
    abstract class Fruit // base class - top hierachry
    {
        public string Kind { get; protected set; }
        public double Cost { get; protected set; }
        abstract public string GetCost();
    }
    class Apple : Fruit // Derived class - apple is also a fruit , fruit is not always an apple ;)
    {
        public Apple(string k, double c)
        {
            Kind = k;
            Cost = c;
        }
        public override string GetCost()
        {
            return "$" + Cost * 12;
        }
    }
}

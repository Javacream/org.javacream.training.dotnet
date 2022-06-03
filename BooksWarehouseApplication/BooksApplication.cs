using System;
using System.Collections.Generic;
using Javacream.BooksWarehouse.Api;
namespace BooksWarehouse.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string startMessage = "Starting Books Application...";
            var endMessage = "Books Application finished";
            //startMessage = 42; -> Compiler-Fehler
            //endMessage = 42; -> Compiler-Fehler, var bedeutet nicht "Irgendwas"
            Console.WriteLine(startMessage);
            List<string> names = new List<string>();
            names.Add("Hugo");
            names.Add("Emil");
            names.Add("Fritz");
            names.Add("Hugo");
            Action<string> loopStep = (string element) => Console.WriteLine(element);
            names.ForEach(loopStep);
            Console.WriteLine("######################");
            names.ForEach((string element) => Console.WriteLine(element));
            Console.WriteLine("######################");
            Action<string> loopStep2 = Console.WriteLine;
            names.ForEach(loopStep2);
            Console.WriteLine("######################");
            names.ForEach(Console.WriteLine);
            Console.WriteLine("######################");
            names.ForEach(Demo.X);
            Demo d = new Demo();
            names.ForEach(d.Y);

            Console.WriteLine(endMessage);
        }
    }

public class Demo{
    public static void X(string p){
        Console.WriteLine("in static X: " + p);
    }
    public void Y(string p){
        Console.WriteLine("in non-static Y: " + p);
    }
}
}

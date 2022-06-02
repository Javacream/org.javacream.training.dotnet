using System;

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
            Console.WriteLine(endMessage);
        }
    }
}

using System;

namespace Javacream.Training.Ef
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PeopleDbContext()) {

                var p = new Person()
                {
                     Name = "Emil"
                };

                context.People.Add(p);
                context.SaveChanges();
            }
        }
    }
}


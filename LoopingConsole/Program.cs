using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var children = new List<Child>
            {
                new Child  { Name = "Suzie", Sick = false },
                new Child  { Name = "Ralph", Sick = true }
            };


            //for (var i=0; i  <children.Count -1; i++)
            //{
            //    var child = children[i];
            //    Console.WriteLine($"{child.Name} is {(child.Sick ? "sick" : "healthy")}");
            //    Console.WriteLine(child.ForgeASickNote());
            //}

            foreach (var child in children)
            {
                //    if (child.Name == "Suzie")
                //    {
                //        continue; //continue the loop and stop executing this iteration of the loop skip this one
                //break break out of the loop and move on
                //}

                Console.WriteLine($"{child.Name} is {(child.Sick ? "sick" : "healthy")}");
                Console.WriteLine(child.ForgeASickNote());
            }

         
            Console.WriteLine("This is our second time talking about the same thing.");
            Console.ReadLine();
        }
    }
}

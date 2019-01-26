using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human(); // when creating a new object you must use the new keyword to show that it is a new object 
            Console.WriteLine("Please enter your firstname");
            human1.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your lastname");
            human1.LastName = Console.ReadLine();

            Console.WriteLine("Please enter your Age");
            human1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your Height");
            human1.Height = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your Haircolour");
            human1.HairColour = Console.ReadLine();

            Console.WriteLine("Please enter your Weight");
            human1.Weight = double.Parse(Console.ReadLine());


            //Console.WriteLine("Your fullname is " + human1.FullName + System.Environment.NewLine + "you are " + human1.Age +" years old"+ 
            //System.Environment.NewLine + "Your Height is  " + human1.Height + " cm" + System.Environment.NewLine + "Your haircolour is " 
            //+ human1.HairColour + System.Environment.NewLine + "you weigh " + human1.Weight);

           Console.WriteLine($"FullName is {human1.FullName+Environment.NewLine} " +
                $"Your age is {human1.Age+Environment.NewLine} " +
                $"Your Height is {human1.Height+Environment.NewLine}cm " +
                $"Your haircolour is {human1.HairColour +Environment.NewLine}" +
                $"Your weight is {human1.Weight +Environment.NewLine}cm" ); 

            Console.ReadLine();

            Human Eve = new Human("Eve", "Ketchup");
            Console.WriteLine(Eve.FullName);
        }
        
    }

}

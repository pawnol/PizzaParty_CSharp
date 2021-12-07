/*
 * Pizza Party
 * Pawelski
 * 12/6/2021
 * Read the code and run the program serveal times so that you understand
 * how the program currently works. Once you understand the code, modify
 * program so that is also calcualtes the perimeter of a rectnagle with the 
 * length and width given by the user. Lastly, answer any questions on the
 * activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaParty
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize constants and variables.
            const int SLICES_PER_PIZZA = 8;
            int numberOfStudents;
            int slicesPerStudent;
            double pizzas;

            // Get input from the console.
            Console.Write("Please enter the number of students " +
                "attending the pizza party >> ");
            numberOfStudents = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the number of slices " +
                "each student will eat >> ");
            slicesPerStudent = Convert.ToInt32(Console.ReadLine());

            // Calculate the number of pizzas and display.
            pizzas = (double) numberOfStudents * slicesPerStudent / SLICES_PER_PIZZA;
            pizzas = Math.Ceiling(pizzas);
            Console.WriteLine("You will need to buy " + pizzas + " pizzas.");

            // Add your code here!
            
        }
    }
}

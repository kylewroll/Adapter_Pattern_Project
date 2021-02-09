/* Author: Kyle Rolland
 * Date: 2/9/2021
 * File: main.cs
 * Description: Driver for program, creates instance of each interface/class and tests their functions, then creates an adapter to test if it works properly
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_Project
{
    class main
    {
        static void Main(string[] args)
        {
            //Testing Grizzly functionality
            Console.WriteLine("Testing Grizzly functions: ");

            Bear B = new Grizzly();

            B.hibernate();
            B.maul();

            //Separates Grizzly fronm next tests
            Console.WriteLine();



            //Testing Toy Bear functionality
            Console.WriteLine("Testing Toy Bear functions: ");

            Toy_Bear T = new Teddy_Bear();

            T.hug();

            //Separates Teddy Bear from next tests
            Console.WriteLine();



            //Testing Bear Adapter functionality
            Console.WriteLine("Testing Bear Adapter functions: ");

            //Previously created Grizzly, B, passed to constructor
            Toy_Bear A = new Bear_Adapter(B);

            //Should call maul(), if everything works properly
            A.hug();

            //Allows user to read output without window disappearing
            Console.ReadKey();
        }
    }
}

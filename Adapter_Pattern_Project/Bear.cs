/* Author: Kyle Rolland
 * Date: 2/9/2021
 * File: Bear.cs
 * Description: File containing Bear interface and its related class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_Project
{
    interface Bear
    {
        //Prototype for maul function that will be implemented in related class
        void maul();

        //Prototype for hibernate function that will be implemented in related class
        void hibernate();
    }

    class Grizzly : Bear
    {
        //Implementation of maul prototype from interface
        void Bear.maul()
        {
            Console.WriteLine("The bear is coming in for a mean left hook, watch out!");
            //Print extra line for readability
            Console.WriteLine();
        }

        //Implementation of hibernate prototype from interface
        void Bear.hibernate()
        {
            Console.WriteLine("Aw, look, the bear has a little sleeping cap on, I guess it's time for bed.");
            //Print extra line for readability
            Console.WriteLine();
        }
    }
}

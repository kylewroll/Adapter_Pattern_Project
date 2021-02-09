/* Author: Kyle Rolland
 * Date: 2/9/2021
 * File: Toy_Bear.cs
 * Description: File containing Toy Bear interface, related class, and adapter
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_Project
{
    interface Toy_Bear
    {
        //Prototype for hug function that will be implemented in related class
        void hug();
    }

    //Regular implementation of Toy_Bear interface
    class Teddy_Bear : Toy_Bear
    {
        void Toy_Bear.hug()
        {
            Console.WriteLine("This teddy just looks sooo squeeze-able!");
            //Print extra line for readability
            Console.WriteLine();
        }
    }

    //Adapter implementation of Toy_Bear interface, creates instance of Bear and calls maul() instead of normal hug()
    class Bear_Adapter : Toy_Bear
    {
        //Bear member variable, used for calling maul
        Bear Adapt_Bear;

        //Parameterized constructor for Bear_Adapter
        public Bear_Adapter(Bear User_Bear)
        {
            User_Bear = new Grizzly();
            Adapt_Bear = User_Bear;
        }

        //Adapted implementation of hug(), calls maul()
        void Toy_Bear.hug()
        {
            Adapt_Bear.maul();
        }
    }
}

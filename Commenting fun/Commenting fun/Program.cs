using System;

namespace Commenting_fun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoolestMethod();
            Console.WriteLine("Hello World!");
        }

        // Single Line Comment
        /* Multi
         * Line
         * Comment
         */

        // XML documentation comment below.    --Look what happens when you hover mouse over method ;)

        /// <summary>
        /// This is a cool method
        /// </summary>
        static void CoolestMethod()
        {
            //cool code
        }
    }
}

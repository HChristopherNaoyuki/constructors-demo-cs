using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors_demo_cs
{
    // Entry point of the program
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a Solution object and run the main logic
                Solution solution = new Solution();
                solution.Run();
            }
            catch (Exception Issue)
            {
                // Catch any unexpected error from Run
                Console.WriteLine($"[ERROR]: {Issue.Message}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bindings
{
    public class Binding
    {
        public void callID(string v)
        {
            // Checker hvilken metoder der skal kaldes
            if (v == "DoThis")
            {
                //Console.WriteLine(Functions.DoThis());
            }
            else if (v == "DoThat")
            {
                //Console.WriteLine(Functions.DoThat());
            }
            else if (v == "DoSomething")
            {
                Console.Write("Enter: ");
                string line = Console.ReadLine();
                //Console.WriteLine(Functions.DoSomething(line));
            }
            else if (v == "GetTheAnswerToLifeTheUniverseAndEverything")
            {
                //Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
            }
        }
    }
}
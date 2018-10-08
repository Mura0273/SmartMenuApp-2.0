using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;

namespace SmartMenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            SmartMenu menu = new SmartMenu();
            Console.WriteLine("Vælg sprog / Choose language ");
            Console.WriteLine("For Dansk: Tryk 1 / For English press 2");
            string input = Console.ReadLine();
            int.TryParse(input, out int r);
            menu.LoadMenu(menu.ChooseLanguage(r));
            menu.Activate();
        }

    }
}

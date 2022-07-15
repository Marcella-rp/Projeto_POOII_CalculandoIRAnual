using Projeto_POOII_Presentation.Presentations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POOII_Presentation.Infrastructure
{
    public static class ScreenPresenter
    {

        public static void PrintMenu(string mensage)
        {
            Console.WriteLine(Menu.OpenMenu);
        }

        public static int GetOption()
        {
            int response;
            string input = Console.ReadLine();
            while (!int.TryParse(input, out response) ||
              !(Convert.ToInt32(response) >= 1 &&
              Convert.ToInt32(response) <= 2))
            {
                Console.WriteLine(Mensages.ErrorMensageMenu);
                input = Console.ReadLine();
            }
            return response;
        }

        
        public static double GetInput()
        {
            double response;
            string input = Console.ReadLine();
            while (!double.TryParse(input, out response)
                || Convert.ToDouble(input) < 0)
            {
                Console.WriteLine(Mensages.ErrorMensage);
                input = Console.ReadLine();
            }
            return response;
        }

        public static void PrintKeyToContinue(string mensage)
        {
            Console.WriteLine(mensage);
        }
        public static void PrintEndProgram(string mensage)
        {
            Console.WriteLine(mensage);
        }

        public static void PrintGetInput(string mensage)
        {
            Console.Write(mensage);
        }

        public static void PrintFinalTax(string mensage)
        {
            Console.WriteLine(mensage);
        }

        public static void PrintSpace(string mensage)
        {
            Console.WriteLine(mensage);
        }

        public static void PrintFinalresult(double value)
        {
            Console.WriteLine($"O valor a ser pago é: R$ {Math.Round(value, 2)}"); //String.Format("{0:0.00}") 
        }
    }
}

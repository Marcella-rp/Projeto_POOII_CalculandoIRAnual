using Projeto_POOII_Presentation.Infrastructure;
using Projeto_POOII_Presentation.Interfaces;
using Projeto_POOII_Presentation.Presentations;
using Projeto_POOII_Services.Interfaces;

namespace Projeto_POOII_Presentation.ProgramFlows
{
    public class MainFlow : IMainFlow
    {
        private readonly ITaxaCalculator _taxacalculator;

        public MainFlow(ITaxaCalculator taxacalculator)
        {
            _taxacalculator = taxacalculator;
        }
        public void BeginProgram()
        {
            NavigateMenu();
        }
        public void NavigateMenu()
        {
            double value;
            ScreenPresenter.PrintMenu(Menu.OpenMenu);
            var ChooseMenu = ScreenPresenter.GetOption();
            switch (ChooseMenu)
            {
                case 1:
                    Console.Clear();
                    ScreenPresenter.PrintGetInput(Mensages.InputMessage);
                    value = ValueReceive();
                    ValueCalculator(value);
                    break;
                case 2:
                    Console.Clear();
                    ScreenPresenter.PrintEndProgram(Mensages.ProgramEndMessage);
                    break;
            }
            ScreenPresenter.PrintSpace(Mensages.SpaceMensage);
            ScreenPresenter.PrintKeyToContinue(Mensages.KeyToContinue);
            Console.ReadKey();
            Console.Clear();
            BeginProgram();
        }

        public double ValueReceive()
        {
            double value = ScreenPresenter.GetInput();

            return value;
        }

        public double ValueCalculator(double value)
        {
            double finalValue = 0;
            finalValue = _taxacalculator.TaxCalculation(value);
            ScreenPresenter.PrintFinalresult(finalValue);
            return finalValue;
        }


    }
}

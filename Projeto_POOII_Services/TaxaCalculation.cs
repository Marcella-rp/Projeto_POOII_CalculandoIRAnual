using Projeto_POOII_Services.Interfaces;

namespace Projeto_POOII_Services
{
    public class TaxaCalculation : ITaxaCalculator
    {
        public double TaxCalculation(double value)
        {
            double aliquot = 0;
            double deduction = 0;
            if (value < 22847.76)
            {
                aliquot = 0;
                deduction = 0;
            }
            else if (value < 33919.80)
            {
                aliquot = 0.075;
                deduction = 1713.58;
            }
            else if (value < 45012.60)
            {
                aliquot = 0.150;
                deduction = 4257.57;
            }
            else if (value < 55976.16)
            {
                aliquot = 0.225;
                deduction = 7633.51;
            }
            else
            {
                aliquot = 0.275;
                deduction = 10432.32;
            }
            return value * aliquot - deduction;
        }


    }
}

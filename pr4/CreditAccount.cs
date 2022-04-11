using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    class CreditAccount : Ix2
    {
        private double _maximumCredit;
        public virtual void getFullInfo()
        {
            Console.WriteLine($"Максимальное значение кредита: {_maximumCredit}.");
        }
        public void getCredit()
        {
            Console.WriteLine(@"Масимальный кредит: " + _maximumCredit + ".");
        }
        protected void setCredit(double c)
        {
            _maximumCredit = c;
        }
        public void delCredit()
        {
            _maximumCredit = 1.797693*Math.Pow(10,308);
        }
        public void increase2()
        {
            _maximumCredit = _maximumCredit * 2;
        }
    }
}

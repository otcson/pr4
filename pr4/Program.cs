using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditAccount test = new CreditAccount();
            test.delCredit();
            test.getFullInfo();
            
            Account testi = new Account();
            testi.deposit(5266);
            testi.getFullInfo();
            
            Organization aga = new Organization();
            aga.setTitle("Aboba");
            aga.GETFULL();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    class ClientOne : Person
    {
    }
    class Client : ClientOne
    {
        private string _SecondName;
        public Account Account;
         private void getId()
         {
            
         }
        public override void delPerson()
        {
            _SecondName = null;
        }
        public void setPerson(string SecondName)
        {
           _SecondName = SecondName;
        }

    }
}

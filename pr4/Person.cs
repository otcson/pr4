using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    class Person : IRemove
    {
        private string _firstName;
        private string _family;
        public void getFulName()
        {
            Console.WriteLine("Фамилия " + _firstName + ", Семья " + _family + ".");
        }
        public void setPerson(string firstName, string family)
        {
            _firstName = firstName;
            _family = family;
        }        
        public virtual void delPerson()
        {
            _family = null;
            _firstName = null;
        }
        public void Remove()
        {
            _family = _family.Remove(4);
            _firstName = _firstName.Remove(5);
        }
    }
}

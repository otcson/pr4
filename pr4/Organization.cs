using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    class Organization : IRemove
    {
        private string _title;
        public virtual void GETFULL()
        {
            Console.WriteLine($"Название организации в верхнем регистре: {_title.ToUpper()}");
        }
        public void getTitle()
        {
            Console.WriteLine(@"Название организации " + _title + ".");
        }
        public void setTitle(string title)
        {
            _title = title;
        }
        public void delTitle()
        {
            _title = null;
        }
        public void Remove()
        {
            _title = _title.Remove(5);
        }
    }
}

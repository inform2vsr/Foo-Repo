using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NewClass
    {
        public static  NewClass _newClass;

        private NewClass() {


        }

        public static NewClass getInstance() {

            if (_newClass == null)
            {
                _newClass = new NewClass();

            }

            return _newClass;
        }

    }


}

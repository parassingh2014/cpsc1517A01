using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Die
    {
        private String _color;

        public String Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (_color == " ")
                    throw new Exception("Cannot be empty.");
                else
                    _color = value;
            }
        }
    }
}

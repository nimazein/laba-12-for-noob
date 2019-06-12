using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_12_for_noob 
{
    class WrongTypeException : ApplicationException
    {
        public WrongTypeException()
           : base()
        {

        }

        public WrongTypeException(string str)
            : base(str)
        {

        }
        public override string ToString()
        {
            return Message;
        }
    }
}

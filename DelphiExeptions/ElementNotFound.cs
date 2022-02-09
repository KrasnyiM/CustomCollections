using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelphiExceptions
{
    public class ElementNotFound : Exception
    {
        public ElementNotFound() : base()
        {

        }

        public ElementNotFound(string message) : base(message)
        {

        }

        public ElementNotFound(string message, Exception inner) : base(message, inner)
        {

        }
    }
}

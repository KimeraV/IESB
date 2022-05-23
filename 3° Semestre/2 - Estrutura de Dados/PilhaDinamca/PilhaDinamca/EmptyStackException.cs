using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamca
{
    class EmptyStackException : ApplicationException
    {
        public EmptyStackException(string message) : base(message)
        {
            
        }
    }
}

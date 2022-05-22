using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstática
{
    class FullStackExeption : ApplicationException
    {
        public FullStackExeption(string message) : base(message)
        {
            
        }
    }
}

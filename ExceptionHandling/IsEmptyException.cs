using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClassLibrary1.ExceptionHandling
{

    public class IsEmptyException : Exception
    {
        public IsEmptyException(string message) : base(message) { }
    }
}

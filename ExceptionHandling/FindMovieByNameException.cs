using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClassLibrary1.ExceptionHandling
{
    public class FindMovieByNameException : Exception
    {
        public FindMovieByNameException(string message) : base(message) { }
    }
}

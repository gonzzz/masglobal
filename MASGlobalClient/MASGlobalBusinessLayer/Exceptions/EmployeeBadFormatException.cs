using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASGlobalBusinessLayer.Exceptions
{
    public class EmployeeBadFormatException : Exception
    {
        public EmployeeBadFormatException() {}

        public EmployeeBadFormatException(string pMessage) : base(pMessage) { }

        public EmployeeBadFormatException(string pMessage, Exception pException) : base(pMessage, pException) { }
    }
}

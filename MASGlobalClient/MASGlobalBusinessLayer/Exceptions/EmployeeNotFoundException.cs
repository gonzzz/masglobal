using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASGlobalBusinessLayer.Exceptions
{
    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException() { }

        public EmployeeNotFoundException(string pMessage) : base(pMessage) { }

        public EmployeeNotFoundException(string pMessage, Exception pException) : base(pMessage, pException) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User.Domain.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message) 
        {
            
        }
    }
}
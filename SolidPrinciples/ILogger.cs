using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    //abstraction (where High level module i.e Customer and low level modules i.e FileLogger depends)
    interface ILogger
    {
        void handler(string error);
        
    }
}

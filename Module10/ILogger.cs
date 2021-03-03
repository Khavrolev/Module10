using System;
using System.Collections.Generic;
using System.Text;

namespace Module10
{
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMVC.Logger
{
    public interface ILogger
    {
        void LogException(string message);
    }
}

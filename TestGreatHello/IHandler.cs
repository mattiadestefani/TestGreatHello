using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestGreatHello
{
    public interface IHandler
    {
        IHandler Setnext(IHandler handler);
        string Handler(params string[] input);

    }
}

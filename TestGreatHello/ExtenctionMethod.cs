using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGreatHello
{
    public static class ExtenctionMethod
    {
        public static bool IsUpper(this string name) => name.All(char.IsUpper);
    }
}

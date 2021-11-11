using System.Collections.Generic;
using System.Linq;
namespace TestGreatHello
{
    public class Greet : IGreetHello
    {
        public string GreetHello(params string[] names)
        {
            if (names == null)
                return "Hello, my friend.";
            if (names.Length == 1)
                return names[0] == names[0].ToUpper() ? $"HELLO {names[0]}!" : $"Hello, {names[0]}.";
            if (names.Length == 2)
                return $"Hello, {names[0]} and {names[1]}.";
           
           List<string> nameUpp = new();
           List<string> nameDown = new();
           foreach (var name in names)
           {
               if (name.All(char.IsUpper))
                   nameUpp.Add(name);
               else
                    nameDown.Add(name);
           }
           var result = string.Concat("Hello, ", string.Join(", ", nameDown.Where(x => x != nameDown.Last())), " and ", nameDown.Last(), ".");
           if (nameUpp.Any())
               result = string.Concat(result, " AND HELLO ", string.Join(", ", nameUpp.Select(x => x)), "!");
            return result;
        }

    }
}
using System.Linq;

namespace TestGreatHello
{
    public class Greet : IGreetHello
    {
        private static string[] EraseEscape(string escape,string[] names)
        {
            return names?.Select(x => x.Replace(escape, string.Empty)).ToArray();
        }

        private static string[] SplitComma(string sign, string[] names,string escape)
        {
            var comma = names?.Where(x => x.Contains(sign)).ToArray();
            var escapeName = comma?.Where(x => x.Contains(escape)).ToArray();
            names = names?.Except(comma).ToArray();
            comma = comma?.Except(escapeName).ToArray();
            return names?.Concat(comma.SelectMany(x => x.Split(sign))).Concat(EraseEscape(escape,escapeName)).ToArray();
        }

        public string GreetHello(params string[] names)
        {
            names = SplitComma(", ", names, "\"");
            if (names == null)
                return "Hello, my friend.";
            
            if (names.Length == 1)
                return names[0] == names[0].ToUpper() ? $"HELLO {names[0]}!" : $"Hello, {names[0]}.";

            if (names.Length == 2)
                return $"Hello, {names[0]} and {names[1]}.";

            var nameUpp = names.Where(x => x.IsUpper()).ToList();
            var nameDown = names.Except(nameUpp).ToList();

            var result = string.Concat("Hello, ", string.Join(", ", nameDown.Where(x => x != nameDown.Last())), " and ", nameDown.Last(), ".");
            
            if (nameUpp.Any())
                return string.Concat(result, " AND HELLO ", string.Join(", ", nameUpp.Select(x => x)), "!");

            return result;
        }

    }
}
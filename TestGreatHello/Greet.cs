using System.Linq;

namespace TestGreatHello
{
    public class Greet : IGreetHello
    {
        private IHandler _handler;
        public Greet(IHandler handler)
        {
            _handler = handler;
        }
        private static string[] EraseEscape(string escape,string[] names) => names?.Select(x => x.Replace(escape, string.Empty)).ToArray();
        private static string[] Normalize(string sign, string[] names,string escape)
        {
            var comma = names?.Where(x => x.Contains(sign)).ToArray();
            var escapeName = comma?.Where(x => x.Contains(escape)).ToArray();
            names = names?.Except(comma).ToArray();
            comma = comma?.Except(escapeName).ToArray();
            return names?.Concat(comma.SelectMany(x => x.Split(sign))).Concat(EraseEscape(escape,escapeName)).ToArray();
        }

        public string GreetHello(params string[] names) => _handler.Handler(Normalize(", ",names,"\""));
    }
}
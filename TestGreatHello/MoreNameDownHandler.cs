using System.Linq;

namespace TestGreatHello
{
    public class MoreNameDownHandler : AbstractHandler
    {
        public override string Handler(params string[] input)
        {
            if(input != null && input.Length > 2 && !input.Any(x=>x.IsUpper()))
            {
                var lastName = input.Last();
                var otherName = string.Join(", ", input.Where(x => x != input.Last()));
                return string.Concat("Hello, ", otherName, " and ",lastName, ".");
            }
            return base.Handler(input);
        }
    }
}

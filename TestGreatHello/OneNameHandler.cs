using System.Linq;

namespace TestGreatHello
{
    public class OneNameHandler : AbstractHandler
    {
        public override string Handler(params string[] input)
        {
            if (input != null && input.Length == 1)
                return $"Hello, {input.First()}.";
            return base.Handler(input);
        }
    }
}

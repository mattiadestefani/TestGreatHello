using System.Linq;

namespace TestGreatHello
{
    public class TwoNameHandler : AbstractHandler
    {
        public override string Handler(params string[] input)
        {
            if(input != null && input.Length == 2  )
                return $"Hello, {input.First()} and {input.Last()}.";
            return base.Handler(input);
        }
    }
}

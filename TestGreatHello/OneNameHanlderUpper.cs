using System.Linq;

namespace TestGreatHello
{
    public class OneNameHanlderUpper : AbstractHandler
    {
        public override string Handler(params string[] input)
        {
            if (input != null && input.Length == 1 && input.First().IsUpper())
                return $"HELLO {input.First()}!";
             return base.Handler(input);
        }
    }
}

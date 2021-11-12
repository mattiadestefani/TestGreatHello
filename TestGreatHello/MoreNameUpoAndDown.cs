using System.Linq;

namespace TestGreatHello
{
    public class MoreNameUpoAndDown : AbstractHandler
    {
        public override string Handler(params string[] input)
        {
            if(input != null && input.Length > 2 && input.Any(x => x.IsUpper()))
            {
                var nameUpp = input.Where(x => x.IsUpper()).ToArray();
                input = input.Except(nameUpp).ToArray();
                var stringUp = string.Concat(" AND HELLO ", string.Join(", ", nameUpp.Select(x => x)), "!");
                return string.Concat(base.Handler(input), stringUp);
            }
            return base.Handler(input);
        }
    }
}

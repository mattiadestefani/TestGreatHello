namespace TestGreatHello
{
    public class NullHandler : AbstractHandler
    {
        public override string Handler(params string[] input) => input == null ? "Hello, my friend." : base.Handler(input);
    }
}

namespace TestGreatHello
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _next;
        public virtual string Handler(params string[] input) => _next != null ?_next.Handler(input):null;

        public IHandler Setnext(IHandler handler) => _next = handler;
    }
}

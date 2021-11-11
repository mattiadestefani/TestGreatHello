namespace TestGreatHello
{
    public class Greet : IGreetHello
    {
        //    public string GreetHello(string name)
        //    {
        //        if (name == null) return "Hello, my friend.";
        //        return name == name.ToUpper() ? $"HELLO {name}!" : $"Hello, {name}.";
        //    }

        public string GreetHello(params string[] names)
        {
            string hello = "Hello, my friend.";

            if (names == null)
                return hello;

            if (names.Length == 2)
            {
                hello = "Hello, ";
                hello = hello + names[0] + " and " + names[1] + ".";
                return hello;
            }

            return names[0] == names[0].ToUpper() ? $"HELLO {names[0]}!" : $"Hello, {names[0]}.";
        }
    }
}
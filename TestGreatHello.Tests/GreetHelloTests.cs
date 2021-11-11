using NUnit.Framework;

namespace TestGreatHello.Tests
{
    public class GreetHelloTests
    {
        private IGreetHello _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Greet();
        }

        [Test]
        public void Should_Send_Me_Hello_By_Name()
        {
            var actual = _sut.GreetHello("Gino"); 
            Assert.AreEqual("Hello, Gino.", actual);
            Assert.Pass("ho salutato");
        }

        [Test]
        public void Should_Send_Me_Hello_My_Friend()
        {
            var actual = _sut.GreetHello(null);
            Assert.AreEqual("Hello, my friend.", actual);
            Assert.Pass("ti ho salutato ma non ti conosco");
        }

        [Test]
        public void Should_Send_Me_Hello_By_Uppercase()
        {
            var actual = _sut.GreetHello("IGOR");
            Assert.AreEqual("HELLO IGOR!", actual);
            Assert.Pass("ti ho salutato urlando");
        }

        [Test]
        public void Should_Send_Me_Hello_To_Two_Names()
        {
            var actual = _sut.GreetHello("Oussama", "Nicola");
            Assert.AreEqual("Hello, Oussama and Nicola." , actual);
            Assert.Pass("vi ho salutato entrambi");
        }
    }
}
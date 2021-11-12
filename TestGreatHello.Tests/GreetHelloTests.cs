
using System.Net.NetworkInformation;
using NUnit.Framework;
using TestGreatHello.Ioc;

namespace TestGreatHello.Tests
{
    public class GreetHelloTests
    {
        //private IHandler _sut;
        private IGreetHello _sut;

        [SetUp]
        public void Setup()
        {
            _sut = Container.GetService<IGreetHello>();
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

        [Test]
        public void ShoulBeMoreNames()
        {
            var actual= _sut.GreetHello("Gino", "Pino", "Rino", "Vino");
            Assert.AreEqual("Hello, Gino, Pino, Rino and Vino.", actual);
        }

        [Test]
        public void ShoulBeMixed()
        {
            var actual = _sut.GreetHello("Gino", "Pino", "RINO", "Vino");
            Assert.AreEqual("Hello, Gino, Pino and Vino. AND HELLO RINO!",actual);
        }

        [Test]
        public void ShoulContainComma()
        {
            var actual = _sut.GreetHello("Gino", "Pino", "Rino, Vino");
            Assert.AreEqual("Hello, Gino, Pino, Rino and Vino.",actual);
        }
        [Test]
        public void ShouldContainEscape()
        {
            var actual = _sut.GreetHello("Gino", "Pino", "\"Rino, Vino\"", "Ella");
            Assert.AreEqual("Hello, Gino, Pino, Ella and Rino, Vino.", actual);
        }

        [Test]
        public void sandbox()
        {
            var actual = _sut.GreetHello("GINO", "\"Vino, Rino\"");
            Assert.Pass(actual);
        }
    }
}
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGreatHello.Ioc
{
    public static class Container
    {
        private static IHost CreateHostBuiler()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((_, services) =>
            {
                services
                .AddSingleton<IGreetHello, Greet>()
                .AddSingleton<IHandler>(x =>
                {
                    var nullName = new NullHandler();
                    var oneNameHandler = new OneNameHandler();
                    var twoNomeHandler = new TwoNameHandler();
                    var oneNameUpper = new OneNameHanlderUpper();
                    var moreNameDown = new MoreNameDownHandler();
                    var moreNameUp = new MoreNameUpoAndDown();

                    moreNameUp
                    .Setnext(moreNameDown)
                    .Setnext(twoNomeHandler)
                    .Setnext(oneNameUpper)
                    .Setnext(oneNameHandler)
                    .Setnext(nullName);
                    return moreNameUp;
                });
            }).Build();
        }

        public static T GetService<T>() => CreateHostBuiler().Services.GetService<T>();
    }
}

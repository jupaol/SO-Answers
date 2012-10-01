using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using FluentAssertions;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GlobalTests.Topics.ReactiveProgramming
{
    [TestClass]
    public class SubscribingToASimpleDataSourceTests
    {
        [TestMethod]
        public void subscribe_using_an_empty_observable()
        {
            var o = Observable.Empty<int>();
            bool n = false, e = false, c = false;

            var d = o.Subscribe(
                x => { Console.WriteLine("OnNext: {0}", x); n = true; },
                x => { Console.WriteLine("On Error: {0}", x.Message); e = true; },
                () => { Console.WriteLine("On Complete"); c = true; });

            Thread.Sleep(3000);

            d.Dispose();

            n.Should().BeFalse();
            e.Should().BeFalse();
            c.Should().BeTrue();
        }

        [TestMethod]
        public void subscribe_using_a_collection_throwing_an_eception()
        {
            var o = Observable.Throw<int>(new Exception("Oooops"));
            bool n = false, e = false, c = false;

            var d = o.Subscribe(
                x => { Console.WriteLine("OnNext: {0}", x); n = true; },
                x => { Console.WriteLine("On Error: {0}", x.Message); e = true; },
                () => { Console.WriteLine("On Complete"); c = true; });

            Thread.Sleep(2000);

            d.Dispose();

            n.Should().BeFalse();
            e.Should().BeTrue();
            c.Should().BeFalse();
        }

        [TestMethod]
        public void subscribe_using_a_simple_collection_with_one_element()
        {
            var o = Observable.Return(45);
            bool n = false, e = false, c = false;

            var d = o.Subscribe(
                x => { Console.WriteLine("OnNext: {0}", x); n = true; },
                x => { Console.WriteLine("On Error: {0}", x.Message); e = true; },
                () => { Console.WriteLine("On Complete"); c = true; });

            Thread.Sleep(2000);

            d.Dispose();

            n.Should().BeTrue();
            e.Should().BeFalse();
            c.Should().BeTrue();
        }

        [TestMethod]
        public void subscribe_using_a_collection_of_numbers()
        {
            var o = Observable.Range(10, 20);
            bool n = false, e = false, c = false;
            int called = 0;

            var d = o.Subscribe(
                x => { Console.WriteLine("OnNext: {0}", x); n = true; called++; },
                x => { Console.WriteLine("On Error: {0}", x.Message); e = true; },
                () => { Console.WriteLine("On Complete"); c = true; });

            Thread.Sleep(2000);

            d.Dispose();

            n.Should().BeTrue();
            e.Should().BeFalse();
            c.Should().BeTrue();
            called.Should().Be(20);
        }

        [TestMethod]
        public void subscribe_using_never()
        {
            var o = Observable.Never<int>();
            bool n = false, e = false, c = false;

            var d = o.Subscribe(
                x => { Console.WriteLine("OnNext: {0}", x); n = true; },
                x => { Console.WriteLine("On Error: {0}", x.Message); e = true; },
                () => { Console.WriteLine("On Complete"); c = true; });

            Thread.Sleep(2000);

            d.Dispose();;

            n.Should().BeFalse();
            e.Should().BeFalse();
            c.Should().BeFalse();
        }
    }
}

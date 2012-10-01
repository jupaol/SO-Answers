using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using FluentAssertions.EventMonitoring;

namespace GlobalTests.Topics.CustomEvents
{
    [TestClass]
    public class CustomEventsTests
    {
        [TestMethod]
        public void my_event_should_be_raised()
        {
            var sut = new MyEventRaiser();

            sut.MonitorEvents();

            sut.Process("Hello");

            sut.ShouldRaise("MyEvent").WithSender(sut).WithArgs<EventArgs<string>>(x => x.Argument.StartsWith("Hello"));
        }

        [TestMethod]
        public void my_event_should_not_be_raised()
        {
            var sut = new MyEventRaiser();

            sut.MonitorEvents();

            sut.Process(null);

            sut.ShouldNotRaise("MyEvent");
        }
    }
}

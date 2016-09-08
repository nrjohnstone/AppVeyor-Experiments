using AppVeyorExperiment;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppVeyorExperiments.Tests
{
    [TestClass]
    public class FooManagerTests
    {
        [TestMethod]
        public void Add_TwoNumbers_ShouldReturnSum()
        {
            var sut = new FooManager();

            sut.Add(2, 3).Should().Be(5);
        }
    }
}

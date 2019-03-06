using System;
using TechTalk.SpecFlow;
using Xunit;

namespace TestSpecFlowProj
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        //private readonly List<int> _numbers = new List<int>();
        private int _total;
        private readonly TestContext _context;
        public SpecFlowFeature1Steps(TestContext context)
        {
            _context = context;
        }

        public class TestContext
        {
            public int? Variable1 { get; set; }
            public int? Variable2 { get; set; }
            public int? Variable3 { get; set; }
            //public int ExpectedSum { get; set; }
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            if (_context.Variable1 == null)
                _context.Variable1 = p0;
            else if (_context.Variable1 != null && _context.Variable2 == null)
                _context.Variable2 = p0;
            else
                _context.Variable3 = p0;

        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            int? num1 = _context.Variable1;
            int? num2 = _context.Variable2;

            Assert.NotNull(num1);
            Assert.NotNull(num2);
            
            _total = num1.Value * num2.Value;

            Assert.Matches(@"\d", _total.ToString());
        }


        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            int? num1 = _context.Variable1;
            int? num2 = _context.Variable2;
            int? num3 = _context.Variable3;

            Assert.NotNull(num1);
            Assert.NotNull(num2);

            if (num3 == null)
                _total = num1.Value + num2.Value;
            else
                _total = num1.Value + num2.Value + num3.Value;

            Assert.Matches(@"\d", _total.ToString());
        }

        [Then(@"The result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.Equal(p0, _total);
        }
    }
}

using CatchTheAce;
using System.Collections;
using System.Text;
using Xunit.Abstractions;

namespace CatchTheAceTests
{
    public class UITests
    {
        private ITestOutputHelper _testOutputHelper;

        public UITests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }



        [Theory]
        [InlineData("20", 20)]
        [InlineData(" 23", 23)]
        [InlineData("2 ", 2)]
        public void GetUserInput_ValidUserInput_ValidIntReturned(string userinput, int expected)
        {
            using var reader = new StringReader(userinput);

            Console.SetIn(reader);
            var ui = new UI();
            var actual = ui.GetUserInput();

            _testOutputHelper.WriteLine(actual.ToString());

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("two", "2")]
        [InlineData("-1", "1")]
        public void GetUserInput_InvalidUserInput_PromptForValidInput(string incorrectInput, string correctInput)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(incorrectInput);
            stringBuilder.AppendLine(correctInput);

            using var reader = new StringReader(stringBuilder.ToString());
            using var writer = new StringWriter();

            Console.SetIn(reader);
            Console.SetOut(writer);

            var ui = new UI();
            _ = ui.GetUserInput();
            var actualMessage = writer.ToString();
            _testOutputHelper.WriteLine(actualMessage);

            var expected = "\nPlease enter an integer greater than 0 \n";

            Assert.Contains(expected, actualMessage);
        }


        [Theory, ClassData(typeof(IndexOfData))]
      
        public void DisplayResults_ValidData_ValidOutput(int yearsToSimulate, int aceInTheLastWeekCount, List<int> weeksWithFoundAce)
        {
            
            //var yearsToSimulate = 5;
            //var aceInTheLastWeekCount = 2;
            //var weeksWithFoundAce = new List<int> { 3, 4, 7, 2, 8 };

            var ui = new UI();
            ui.DisplayResults(yearsToSimulate, aceInTheLastWeekCount, weeksWithFoundAce);



        }
    }

    public class IndexOfData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { 5, 2, new List<int> { 3, 4, 7, 2, 8 } }
        };

        public IEnumerator<object[]> GetEnumerator()
        { return _data.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
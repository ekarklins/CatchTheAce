using CatchTheAce;
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
            using (var reader = new StringReader(userinput))
            {
                Console.SetIn(reader);
                var ui = new UI();
                var actual = ui.GetUserInput();

                _testOutputHelper.WriteLine(actual.ToString());

                Assert.Equal(expected, actual);
            }
        }

        [Theory]
        [InlineData("two")]
        [InlineData("-1")]
        public void GetUserInput_InvalidUserInput_PromptForValidInput(string userinput)
        {
            //using (var reader = new StringReader(userinput))
            //using (var writer = new StringWriter())
            //{
            //    Console.SetIn(reader);
            //    Console.SetOut(writer);

            // var ui = new UI(); _ = ui.GetUserInput(); var actualMessage = writer.ToString(); _testOutputHelper.WriteLine(actualMessage);

            //    var expected = "\nPlease enter an integer greater than 0 \n";

            //    Assert.Equal(expected, actualMessage);
            //}
        }


        [Fact]
        public void DisplayResults_ValidData_ValidOutput()
        {
            var content = new System.Text.StringBuilder();
            var writer = new StringWriter(content);
            Console.SetOut(writer);
            var yearsToSimulate = 5;
            var aceInTheLastWeekCount = 2;
            var weeksWithFoundAce = new List<int> { 3, 4, 7, 2, 8 };

            var ui = new UI();
            ui.DisplayResults(yearsToSimulate, aceInTheLastWeekCount, weeksWithFoundAce);
            var actualOutput = writer.ToString();

            _testOutputHelper.WriteLine(actualOutput);


        }

    }
}
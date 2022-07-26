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

            //    var ui = new UI();
            //    _ = ui.GetUserInput();
            //    var actualMessage = writer.ToString();
            //    _testOutputHelper.WriteLine(actualMessage);

            //    var expected = "\nPlease enter an integer greater than 0 \n";



            //    Assert.Equal(expected, actualMessage);
            //}
        }


    }
}

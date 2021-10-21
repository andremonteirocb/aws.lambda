using Xunit;
using Amazon.Lambda.TestUtilities;
using Lambda;
using AWS.Models;

namespace Fundamentos.AWS.Lambda.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToUpperFunction()
        {
            var function = new Function();
            var context = new TestLambdaContext();
            var input = new Input { Message = "hello world" };
            var upperCase = function.Handler(input, context).Result;

            Assert.Equal("HELLO WORLD", upperCase);
        }
    }
}

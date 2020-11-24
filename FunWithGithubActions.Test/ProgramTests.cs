using Xunit;

namespace FunWithGithubActions.Test
{
    public class ProgramTests
    {
        [Fact]
        public void TestAdd()
        {
            const int a = 2;
            const int b = 4;
            const int expected = 6;
            
            var actual = Program.Add(a, b);
            
            Assert.Equal(expected, actual);
        }
    }
}

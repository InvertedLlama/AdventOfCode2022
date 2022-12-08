namespace RockPaperScissors.Test
{
    public class CalculatorTest
    {
        public class ScoreChoice
        {
            [Fact]
            public void When_X_Then_1()
            {
                var input = 'X';
                var score = Calculator.ScoreChoice(input);

                score.Should().Be(1);
            }

            [Fact]
            public void When_Y_Then_2()
            {
                var input = 'Y';
                var score = Calculator.ScoreChoice(input);

                score.Should().Be(2);
            }

            [Fact]
            public void When_Z_Then_3()
            {
                var input = 'Z';
                var score = Calculator.ScoreChoice(input);

                score.Should().Be(3);
            }
        }
        public class ScoreWin
        {
            [Theory]
            [InlineData('A', 'X')]
            [InlineData('B', 'Y')]
            [InlineData('C', 'Z')]
            public void When_Draw_Then_Three(char thierChoice, char myChoice)
            {
                var score = Calculator.ScoreWin(thierChoice, myChoice);
                score.Should().Be(3);
            }

            [Theory]
            [InlineData('A', 'Y')]
            [InlineData('B', 'Z')]
            [InlineData('C', 'X')]
            public void When_Win_Then_Six(char thierChoice, char myChoice)
            {
                var score = Calculator.ScoreWin(thierChoice, myChoice);
                score.Should().Be(6);
            }
        }
    }
}
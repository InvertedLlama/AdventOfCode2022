using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Test
{
    public class ExampleTest
    {
        [Fact]
        public void FirstExampleTest()
        {
            var input = new List<(char, char)>()
            {
                ('A', 'Y'),
                ('B', 'X'),
                ('C', 'Z')
            };
            var score = Calculator.CalculateScore(input);

            score.Should().Be(15);
        }

        [Fact]
        public void FirstExampleTest_Part1()
        {
            var input = ('A', 'Y');
            var score = Calculator.CalculateScore(input);

            score.Should().Be(8);
        }

        [Fact]
        public void FirstExampleTest_Part2()
        {
            var input = ('B', 'X');
            var score = Calculator.CalculateScore(input);

            score.Should().Be(1);
        }

        [Fact]
        public void FirstExampleTest_Part3()
        {
            var input = ('C', 'Z');
            var score = Calculator.CalculateScore(input);

            score.Should().Be(6);
        }

        [Fact]
        public void SecondExampleTest()
        {
            var input = new List<(char, char)>()
            {
                ('A', 'Y'),
                ('B', 'X'),
                ('C', 'Z')
            };
            input = Strategy.ChooseReponses(input);
            var score = Calculator.CalculateScore(input);

            score.Should().Be(12);
        }


        [Fact]
        public void SecondExampleTest_Part1()
        {
            var input = ('A', 'Y');
            input.Item2 = Strategy.ChooseReponse(input.Item1, input.Item2);
            var score = Calculator.CalculateScore(input);

            score.Should().Be(4);
        }


        [Fact]
        public void SecondExampleTest_Part2()
        {
            var input = ('B', 'X');
            input.Item2 = Strategy.ChooseReponse(input.Item1, input.Item2);
            var score = Calculator.CalculateScore(input);

            score.Should().Be(1);
        }


        [Fact]
        public void SecondExampleTest_Part3()
        {
            var input = ('C', 'Z');
            input.Item2 = Strategy.ChooseReponse(input.Item1, input.Item2);
            var score = Calculator.CalculateScore(input);

            score.Should().Be(7);
        }
    }
}

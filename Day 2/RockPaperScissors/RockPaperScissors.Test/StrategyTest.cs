using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Test
{
    public class StrategyTest
    {
        public class GetWinResponse
        {
            [Fact]
            public void When_A_Then_Y()
            {
                var input = 'A';
                var response = Strategy.GetWinResponse(input);

                response.Should().Be('Y');
            }

            [Fact]
            public void When_B_Then_Z()
            {
                var input = 'B';
                var response = Strategy.GetWinResponse(input);

                response.Should().Be('Z');
            }

            [Fact]
            public void When_C_Then_X()
            {
                var input = 'C';
                var response = Strategy.GetWinResponse(input);

                response.Should().Be('X');
            }
        }

        public class GetDrawResponse
        {
            [Fact]
            public void When_A_Then_X()
            {
                var input = 'A';
                var response = Strategy.GetDrawResponse(input);

                response.Should().Be('X');
            }

            [Fact]
            public void When_B_Then_Y()
            {
                var input = 'B';
                var response = Strategy.GetDrawResponse(input);

                response.Should().Be('Y');
            }

            [Fact]
            public void When_C_Then_Z()
            {
                var input = 'C';
                var response = Strategy.GetDrawResponse(input);

                response.Should().Be('Z');
            }
        }

        public class GetLoseResponse
        {
            [Fact]
            public void When_A_Then_Z()
            {
                var input = 'A';
                var response = Strategy.GetLoseResponse(input);

                response.Should().Be('Z');
            }

            [Fact]
            public void When_B_Then_X()
            {
                var input = 'B';
                var response = Strategy.GetLoseResponse(input);

                response.Should().Be('X');
            }

            [Fact]
            public void When_C_Then_Y()
            {
                var input = 'C';
                var response = Strategy.GetLoseResponse(input);

                response.Should().Be('Y');
            }
        }
    }
}

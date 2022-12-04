namespace CampCleanup.Test
{
    public class JobTest
    {
        public class AssignmentTest
        {
            [Fact]
            public void When_12_Expect_Parse12()
            {
                var assignment = new Job.Assignment("1-2");

                using (new AssertionScope())
                {
                    assignment.Start.Should().Be(1);
                    assignment.End.Should().Be(2);
                }
            }

            [Fact]
            public void When_1011_Expect_Parse1011()
            {
                var assignment = new Job.Assignment("10-11");

                using (new AssertionScope())
                {
                    assignment.Start.Should().Be(10);
                    assignment.End.Should().Be(11);
                }
            }
        }

        [Fact]
        public void When_1234_Expect_Parse1234()
        {
            var job = new Job("1-2,3-4");

            using (new AssertionScope())
            {
                job.assignments.Should().HaveCount(2);
                job.assignments[0].Start.Should().Be(1);
                job.assignments[0].End.Should().Be(2);
                job.assignments[1].Start.Should().Be(3);
                job.assignments[1].End.Should().Be(4);
            }
        }

        [Fact]
        public void When_10112021_Expect_Parse10112021()
        {
            var job = new Job("10-11,20-21");

            using (new AssertionScope())
            {
                job.assignments.Should().HaveCount(2);
                job.assignments[0].Start.Should().Be(10);
                job.assignments[0].End.Should().Be(11);
                job.assignments[1].Start.Should().Be(20);
                job.assignments[1].End.Should().Be(21);
            }
        }
    }
}
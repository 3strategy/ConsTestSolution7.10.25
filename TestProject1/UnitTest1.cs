using ConsTestSolution7._10._25;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenSeveralProposedDigitsTestOutput()
        {
            // arrange: redirect in/out
            //var input = new StringReader("2\n101\n102\n");
            var input = new StringReader("3\n5\n20\n103\n");
            //var input = new StringReader("2\n7\n7\n");
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            // act
            Program.MainQ2();

            // grab *all* of what was written
            var allOutput = output.ToString();
            // split into individual lines (dropping any trailing empty lines)
            var lines = allOutput
                .Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            // assert: exactly one line equals "2"
            var countOf2 = lines.Count(l => l == "2");
            Assert.That(countOf2, Is.EqualTo(1),
                $"Expected exactly one '2' in output, but found {countOf2}. Full output was:{Environment.NewLine}{allOutput}");
        }
    }
}

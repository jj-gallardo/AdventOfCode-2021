using AdventOfCode2021.InputLoaders;
using AdventOfCode2021.Problems.Day2;

using FluentAssertions;

using NSubstitute;

using NUnit.Framework;

namespace AdventOfCode2021.Tests.Problems.Day2;

[TestFixture]
public class DiveProblemTests
{
    [SetUp]
    public void SetUp()
    {
        _inputLoader = Substitute.For<IInputLoader>();
        _inputLoader.GetInput().Returns(new[]
        {
            "forward 5",
            "down 5",
            "forward 8",
            "up 3",
            "down 8",
            "forward 2"
        });
    }

    private IInputLoader _inputLoader;

    [Test]
    public void SampleTest_PartOne()
    {
        var diveProblem = new DivePartOneProblem(_inputLoader);

        string result = diveProblem.GetSolution();

        result.Should().Be("150");
    }

    [Test]
    public void SampleTest_PartTwo()
    {
        var diveProblem = new DivePartTwoProblem(_inputLoader);

        string result = diveProblem.GetSolution();

        result.Should().Be("900");
    }
}
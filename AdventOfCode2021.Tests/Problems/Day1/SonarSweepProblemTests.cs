using AdventOfCode2021.InputLoaders;
using AdventOfCode2021.Problems.Day1;

using FluentAssertions;

using NSubstitute;

using NUnit.Framework;

namespace AdventOfCode2021.Tests.Problems.Day1;

[TestFixture]
public class SonarSweepProblemTests
{
    [SetUp]
    public void SetUp()
    {
        _inputLoader = Substitute.For<IInputLoader>();
        _inputLoader.GetInput().Returns(new[]
        {
            "199",
            "200",
            "208",
            "210",
            "200",
            "207",
            "240",
            "269",
            "260",
            "263"
        });
    }

    private IInputLoader _inputLoader;

    [Test]
    public void SampleTest_PartOne()
    {
        var sonarSweepPartOneProblem = new SonarSweepPartOneProblem(_inputLoader);
        string result = sonarSweepPartOneProblem.GetSolution();
        result.Should().Be("7");
    }

    [Test]
    public void SampleTest_PartTwo()
    {
        var sonarSweepPartTwoProblem = new SonarSweepPartTwoProblem(_inputLoader);
        string result = sonarSweepPartTwoProblem.GetSolution();
        result.Should().Be("5");
    }
}
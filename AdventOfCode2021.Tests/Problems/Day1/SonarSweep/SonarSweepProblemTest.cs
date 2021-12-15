using AdventOfCode2021.InputLoaders;
using AdventOfCode2021.Problems.Day1.SonarSweep;

using FluentAssertions;

using NSubstitute;

using NUnit.Framework;

namespace AdventOfCode2021.Tests.Problems.Day1.SonarSweep;

[TestFixture]
public class SonarSweepProblemTests
{
    [SetUp]
    public void SetUp()
    {
        _inputLoader = Substitute.For<IInputLoader>();
        _sonarSweepProblem = new SonarSweepProblem(_inputLoader);
    }

    private IInputLoader _inputLoader;
    private SonarSweepProblem _sonarSweepProblem;

    [Test]
    public void SampleTest()
    {
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

        string result = _sonarSweepProblem.Solve();
        result.Should().Be("7");
    }
}
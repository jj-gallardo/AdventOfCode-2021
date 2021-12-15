using AdventOfCode2021.InputLoaders;
using AdventOfCode2021.Problems.Day1.SonarSweep2;

using FluentAssertions;

using NSubstitute;

using NUnit.Framework;

namespace AdventOfCode2021.Tests.Problems.Day1.SonarSweep2;

[TestFixture]
public class SonarSweepProblem2Tests
{
    [SetUp]
    public void SetUp()
    {
        _inputLoader = Substitute.For<IInputLoader>();
        _sonarSweep2Problem = new SonarSweep2Problem(_inputLoader);
    }

    private IInputLoader _inputLoader;
    private SonarSweep2Problem _sonarSweep2Problem;

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

        string result = _sonarSweep2Problem.Solve();
        result.Should().Be("5");
    }
}
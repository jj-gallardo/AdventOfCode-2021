using AdventOfCode2021.InputLoaders;
using AdventOfCode2021.Problems.Day2.Dive;

using FluentAssertions;

using NSubstitute;

using NUnit.Framework;

namespace AdventOfCode2021.Tests.Problems.Day2.Dive;

[TestFixture]
public class DiveProblemTests
{
    [SetUp]
    public void SetUp()
    {
        _inputLoader = Substitute.For<IInputLoader>();
        _diveProblem = new DiveProblem(_inputLoader);
    }

    private IInputLoader _inputLoader;
    private DiveProblem _diveProblem;

    [Test]
    public void SampleTest()
    {
        _inputLoader.GetInput().Returns(new[]
        {
            "forward 5",
            "down 5",
            "forward 8",
            "up 3",
            "down 8",
            "forward 2"
        });

        string result = _diveProblem.Solve();
        result.Should().Be("150");
    }
}
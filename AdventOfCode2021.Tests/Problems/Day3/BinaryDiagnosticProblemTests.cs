using AdventOfCode2021.InputLoaders;
using AdventOfCode2021.Problems.Day3;

using FluentAssertions;

using NSubstitute;

using NUnit.Framework;

namespace AdventOfCode2021.Tests.Problems.Day3;

[TestFixture]
public class BinaryDiagnosticProblemTests
{
    [SetUp]
    public void SetUp()
    {
        _inputLoader = Substitute.For<IInputLoader>();
        _inputLoader.GetInput().Returns(new[]
        {
            "00100",
            "11110",
            "10110",
            "10111",
            "10101",
            "01111",
            "00111",
            "11100",
            "10000",
            "11001",
            "00010",
            "01010"
        });
    }

    private IInputLoader _inputLoader;

    [Test]
    public void SampleTest_PartOne()
    {
        var binaryDiagnosticProblem = new BinaryDiagnosticPartOneProblem(_inputLoader);
        string result = binaryDiagnosticProblem.GetSolution();
        result.Should().Be("198");
    }

    [Test]
    public void SampleTest_PartTwo()
    {
        var binaryDiagnosticProblem = new BinaryDiagnosticPartTwoProblem(_inputLoader);
        string result = binaryDiagnosticProblem.GetSolution();
        result.Should().Be("230");
    }
}
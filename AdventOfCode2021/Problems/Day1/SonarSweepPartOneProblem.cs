using AdventOfCode2021.InputLoaders;

namespace AdventOfCode2021.Problems.Day1;

public class SonarSweepPartOneProblem : BaseProblem<IEnumerable<int>>
{
    /// <summary>
    ///     https://adventofcode.com/2021/day/1
    /// </summary>
    public SonarSweepPartOneProblem(IInputLoader inputLoader) : base(inputLoader)
    {
    }

    protected override string Solve(IEnumerable<int> inputs)
    {
        int[] sonarSweepReport = inputs.ToArray();

        var increasesCounter = 0;
        for (var i = 1; i < sonarSweepReport.Length; i++)
            if (sonarSweepReport[i] > sonarSweepReport[i - 1])
            {
                increasesCounter++;
            }

        return increasesCounter.ToString();
    }

    protected override IEnumerable<int> ParseInput(IEnumerable<string> inputLines)
    {
        return inputLines.Select(int.Parse);
    }
}
using AdventOfCode2021.InputLoaders;

namespace AdventOfCode2021.Problems.Day1.SonarSweep;

public class SonarSweepProblem : BaseProblem
{
    /// <summary>
    ///     https://adventofcode.com/2021/day/1
    /// </summary>
    public SonarSweepProblem(IInputLoader inputLoader) : base(inputLoader)
    {
    }

    public override string Solve()
    {
        int[] sonarSweepReport = GetInput().Select(int.Parse).ToArray();

        var increasesCounter = 0;
        for (var i = 1; i < sonarSweepReport.Length; i++)
            if (sonarSweepReport[i] > sonarSweepReport[i - 1])
            {
                increasesCounter++;
            }

        return increasesCounter.ToString();
    }
}
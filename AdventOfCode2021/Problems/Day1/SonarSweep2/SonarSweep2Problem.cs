using AdventOfCode2021.InputLoaders;

namespace AdventOfCode2021.Problems.Day1.SonarSweep2;

public class SonarSweep2Problem : BaseProblem
{
    private const int SlidingWindowSize = 3;

    /// <summary>
    ///     https://adventofcode.com/2021/day/1#part2
    /// </summary>
    public SonarSweep2Problem(IInputLoader inputLoader) : base(inputLoader)
    {
    }

    public override string Solve()
    {
        int[] sonarSweepReport = GetInput().Select(int.Parse).ToArray();

        var increasesCounter = 0;
        int windowPreviousValue = GetWindowValue(sonarSweepReport, 0);
        for (var i = 1; i < sonarSweepReport.Length - (SlidingWindowSize - 1); i++)
        {
            int currentWindowValue = windowPreviousValue
                                     - sonarSweepReport[i - 1]
                                     + sonarSweepReport[i + (SlidingWindowSize - 1)];

            if (currentWindowValue > windowPreviousValue)
            {
                increasesCounter++;
            }

            windowPreviousValue = currentWindowValue;
        }

        return increasesCounter.ToString();
    }

    private int GetWindowValue(int[] sonarSweepReport, int position)
    {
        return sonarSweepReport.Take(..(position + SlidingWindowSize)).Sum();
    }
}
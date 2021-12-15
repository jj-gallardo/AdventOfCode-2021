using AdventOfCode2021.InputLoaders;

namespace AdventOfCode2021.Problems.Day1;

public class SonarSweepPartTwoProblem : BaseProblem<int>
{
    private const int SlidingWindowSize = 3;

    /// <summary>
    ///     https://adventofcode.com/2021/day/1#part2
    /// </summary>
    public SonarSweepPartTwoProblem(IInputLoader inputLoader) : base(inputLoader)
    {
    }

    private int GetWindowValue(int[] sonarSweepReport, int position)
    {
        return sonarSweepReport.Take(..(position + SlidingWindowSize)).Sum();
    }

    protected override string Solve(IEnumerable<int> inputs)
    {
        int[] sonarSweepReport = inputs.ToArray();

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

    protected override int ParseInput(string inputLine)
    {
        return int.Parse(inputLine);
    }
}
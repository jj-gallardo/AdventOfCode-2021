using AdventOfCode2021.InputLoaders;

namespace AdventOfCode2021.Problems.Day2;

public class DivePartTwoProblem : DiveBaseProblem
{
    /// <summary>
    ///     https://adventofcode.com/2021/day/2#part2
    /// </summary>
    public DivePartTwoProblem(IInputLoader inputLoader) : base(inputLoader)
    {
    }

    protected override string Solve(IEnumerable<Command> inputs)
    {
        var horizontalPos = 0;
        var depth = 0;
        var aim = 0;
        foreach (Command command in inputs)
            switch (command.Direction)
            {
                case CommandDirection.Forward:
                    horizontalPos += command.Value;
                    depth += aim * command.Value;
                    break;
                case CommandDirection.Up:
                    aim -= command.Value;
                    break;
                case CommandDirection.Down:
                    aim += command.Value;
                    break;
            }

        return (horizontalPos * depth).ToString();
    }
}
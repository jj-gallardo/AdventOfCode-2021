using AdventOfCode2021.InputLoaders;

namespace AdventOfCode2021.Problems.Day2;

public class DivePartOneProblem : DiveBaseProblem
{
    /// <summary>
    ///     https://adventofcode.com/2021/day/2
    /// </summary>
    public DivePartOneProblem(IInputLoader inputLoader) : base(inputLoader)
    {
    }


    protected override string Solve(IEnumerable<Command> inputs)
    {
        var horizontalPos = 0;
        var depth = 0;
        foreach (Command command in inputs)
            switch (command.Direction)
            {
                case CommandDirection.Forward:
                    horizontalPos += command.Value;
                    break;
                case CommandDirection.Up:
                    depth -= command.Value;
                    break;
                case CommandDirection.Down:
                    depth += command.Value;
                    break;
            }

        return (horizontalPos * depth).ToString();
    }
}
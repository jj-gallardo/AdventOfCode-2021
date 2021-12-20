using AdventOfCode2021.InputLoaders;

namespace AdventOfCode2021.Problems.Day2;

public record Command(CommandDirection Direction, int Value);

public enum CommandDirection
{
    Forward,
    Up,
    Down
}

public abstract class DiveBaseProblem : BaseProblem<IEnumerable<Command>>
{
    /// <summary>
    ///     https://adventofcode.com/2021/day/2
    /// </summary>
    public DiveBaseProblem(IInputLoader inputLoader) : base(inputLoader)
    {
    }

    protected override IEnumerable<Command> ParseInput(IEnumerable<string> inputLines)
    {
        return inputLines.Select(inputLine =>
        {
            string[] commandParts = inputLine.Split(' ');
            return new Command(Enum.Parse<CommandDirection>(commandParts[0], true), int.Parse(commandParts[1]));
        });
    }
}
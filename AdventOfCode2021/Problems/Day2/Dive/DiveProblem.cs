using AdventOfCode2021.InputLoaders;

namespace AdventOfCode2021.Problems.Day2.Dive;

public class DiveProblem : BaseProblem
{
    /// <summary>
    ///     https://adventofcode.com/2021/day/2
    /// </summary>
    public DiveProblem(IInputLoader inputLoader) : base(inputLoader)
    {
    }

    public override string Solve()
    {
        IEnumerable<Command> submarineCommands = GetInput().Select(ParseSubmarineCommand);

        var horizontalPos = 0;
        var depth = 0;
        foreach (Command command in submarineCommands)
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

    private Command ParseSubmarineCommand(string command)
    {
        string[] commandParts = command.Split(' ');
        return new Command(Enum.Parse<CommandDirection>(commandParts[0], true), int.Parse(commandParts[1]));
    }

    private enum CommandDirection
    {
        Forward,
        Up,
        Down
    }

    private record Command(CommandDirection Direction, int Value);
}
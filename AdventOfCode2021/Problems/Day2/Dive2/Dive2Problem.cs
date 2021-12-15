using AdventOfCode2021.InputLoaders;

namespace AdventOfCode2021.Problems.Day2.Dive2;

public class Dive2Problem : BaseProblem
{
    /// <summary>
    ///     https://adventofcode.com/2021/day/2#part2
    /// </summary>
    public Dive2Problem(IInputLoader inputLoader) : base(inputLoader)
    {
    }

    public override string Solve()
    {
        IEnumerable<Command> submarineCommands = GetInput().Select(ParseSubmarineCommand);

        var horizontalPos = 0;
        var depth = 0;
        var aim = 0;
        foreach (Command command in submarineCommands)
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
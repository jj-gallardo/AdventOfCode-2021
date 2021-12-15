using AdventOfCode2021.InputLoaders;

namespace AdventOfCode2021.Problems;

public abstract class BaseProblem<T> : IProblem
{
    private readonly IInputLoader _inputLoader;

    protected BaseProblem(IInputLoader inputLoader)
    {
        _inputLoader = inputLoader;
    }

    public string GetSolution()
    {
        IEnumerable<T> parsedInput = GetInput().Select(ParseInput);
        return Solve(parsedInput);
    }

    protected abstract string Solve(IEnumerable<T> inputs);

    protected abstract T ParseInput(string inputLine);

    protected IEnumerable<string> GetInput()
    {
        return _inputLoader.GetInput();
    }
}
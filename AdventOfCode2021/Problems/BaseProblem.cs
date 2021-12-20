using AdventOfCode2021.InputLoaders;

namespace AdventOfCode2021.Problems;

public abstract class BaseProblem<TInput> : IProblem
{
    private readonly IInputLoader _inputLoader;

    protected BaseProblem(IInputLoader inputLoader)
    {
        _inputLoader = inputLoader;
    }

    public string GetSolution()
    {
        TInput parsedInput = ParseInput(GetInput());
        return Solve(parsedInput);
    }

    protected abstract string Solve(TInput input);

    protected abstract TInput ParseInput(IEnumerable<string> inputLines);

    protected IEnumerable<string> GetInput()
    {
        return _inputLoader.GetInput();
    }
}
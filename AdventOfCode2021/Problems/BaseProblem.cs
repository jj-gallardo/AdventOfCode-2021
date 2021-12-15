using AdventOfCode2021.InputLoaders;

namespace AdventOfCode2021.Problems;

public abstract class BaseProblem : IProblem
{
    private readonly IInputLoader _inputLoader;

    protected BaseProblem(IInputLoader inputLoader)
    {
        _inputLoader = inputLoader;
    }

    public abstract string Solve();

    protected IEnumerable<string> GetInput()
    {
        return _inputLoader.GetInput();
    }
}
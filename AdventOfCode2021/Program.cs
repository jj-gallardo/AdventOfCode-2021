using AdventOfCode2021.InputLoaders;
using AdventOfCode2021.Problems;
using AdventOfCode2021.Problems.Day1.SonarSweep;
using AdventOfCode2021.Problems.Day1.SonarSweep2;

IProblem GetProblem(string? problemKey)
{
    return problemKey switch
    {
        "1.1" => new SonarSweepProblem(new FileInputLoader("Problems/Day1/SonarSweep/input.txt")),
        "1.2" => new SonarSweep2Problem(new FileInputLoader("Problems/Day1/SonarSweep2/input.txt")),

        _ => throw new ArgumentException("Problem not found")
    };
}

string? problemKey = args.FirstOrDefault();
if (string.IsNullOrWhiteSpace(problemKey))
{
    Console.Error.WriteLine("Problem identifier not specified.");
    return;
}

IProblem problem = GetProblem(problemKey);
Console.WriteLine(problem.Solve());
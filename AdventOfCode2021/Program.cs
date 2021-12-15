using AdventOfCode2021.InputLoaders;
using AdventOfCode2021.Problems;
using AdventOfCode2021.Problems.Day1.SonarSweep;
using AdventOfCode2021.Problems.Day1.SonarSweep2;
using AdventOfCode2021.Problems.Day2.Dive;
using AdventOfCode2021.Problems.Day2.Dive2;

IProblem GetProblem(string? problemKey)
{
    return problemKey switch
    {
        "1.1" => new SonarSweepProblem(new FileInputLoader("Problems/Day1/SonarSweep/input.txt")),
        "1.2" => new SonarSweep2Problem(new FileInputLoader("Problems/Day1/SonarSweep2/input.txt")),

        "2.1" => new DiveProblem(new FileInputLoader("Problems/Day2/Dive/input.txt")),
        "2.2" => new Dive2Problem(new FileInputLoader("Problems/Day2/Dive2/input.txt")),

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
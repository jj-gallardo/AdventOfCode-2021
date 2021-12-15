using AdventOfCode2021.InputLoaders;
using AdventOfCode2021.Problems;
using AdventOfCode2021.Problems.Day1;
using AdventOfCode2021.Problems.Day2;

IProblem GetProblem(string? problemKey)
{
    return problemKey switch
    {
        "1.1" => new SonarSweepPartOneProblem(new FileInputLoader("Problems/Day1/input.txt")),
        "1.2" => new SonarSweepPartTwoProblem(new FileInputLoader("Problems/Day1/input.txt")),

        "2.1" => new DivePartOneProblem(new FileInputLoader("Problems/Day2/input.txt")),
        "2.2" => new DivePartTwoProblem(new FileInputLoader("Problems/Day2/input.txt")),

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
Console.WriteLine(problem.GetSolution());
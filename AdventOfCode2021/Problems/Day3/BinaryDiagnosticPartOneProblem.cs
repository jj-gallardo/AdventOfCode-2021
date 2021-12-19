using System.Collections;

using AdventOfCode2021.InputLoaders;

namespace AdventOfCode2021.Problems.Day3;

public class BinaryDiagnosticPartOneProblem : BaseProblem<bool[]>
{
    public BinaryDiagnosticPartOneProblem(IInputLoader inputLoader) : base(inputLoader)
    {
    }

    protected override string Solve(IEnumerable<bool[]> inputs)
    {
        bool[][] bitArrayInputs = inputs.ToArray();

        int inputBitLength = bitArrayInputs[0].Length;
        int inputCount = bitArrayInputs.Length;

        var oneBitCountArray = new int[inputBitLength];

        foreach (bool[] bitArray in bitArrayInputs)
        {
            for (int i = 0; i < bitArray.Length; i++)
            {
                oneBitCountArray[i] += bitArray[i] ? 1 : 0;
            }
        }

        var gammaRateBitArray = oneBitCountArray.Select((countValue) => countValue >= (inputCount / 2)).ToArray();
        var epsilonRateBitArray = gammaRateBitArray.Select(x => !x).ToArray();
        
        var result = GetDecimalValue(gammaRateBitArray) * GetDecimalValue(epsilonRateBitArray);
        return result.ToString();
    }

    protected override bool[] ParseInput(string inputLine)
    {
        return (inputLine.Select(c => c.CompareTo('1') == 0).ToArray());
    }

    int GetDecimalValue(bool[] bitArray)
    {
        var decimalValue = 0;
        for (var i = 0; i < bitArray.Length; i++)
        {
            int temp = bitArray[i] ? 1 : 0;
            decimalValue |= temp << (bitArray.Length - i - 1);
        }
        return decimalValue;
    }
}
using System.Collections;

using AdventOfCode2021.InputLoaders;

namespace AdventOfCode2021.Problems.Day3;

public class BinaryDiagnosticPartTwoProblem : BaseProblem<bool[]>
{
    public BinaryDiagnosticPartTwoProblem(IInputLoader inputLoader) : base(inputLoader)
    {
    }

    protected override string Solve(IEnumerable<bool[]> inputs)
    {
        bool[][] bitArrayInputs = inputs.ToArray();

        bool[] oxigenGeneratorRatingBitArray = FilterByMostCommonValues(bitArrayInputs);
        bool[] co2GeneratorRatingBitArray = FilterByLessCommonValues(bitArrayInputs);

        int oxigenGeneratorRating = GetDecimalValue(oxigenGeneratorRatingBitArray);
        int co2GeneratorRating = GetDecimalValue(co2GeneratorRatingBitArray);

        int result = oxigenGeneratorRating * co2GeneratorRating;
        return result.ToString();
    }

    private static bool GetMostCommonBitByPosition(bool[][] bitArrayInputs, int position)
    {
        int oneBitCount = 0;
        int zeroBitCount = 0;
        foreach (bool[] bitArray in bitArrayInputs)
        {
            if (bitArray[position])
            {
                oneBitCount++;
            }
            else
            {
                zeroBitCount++;
            }
        }

        return (oneBitCount >= zeroBitCount);
    }

    private static bool GetLessCommonBitByPosition(bool[][] bitArrayInputs, int position) => !GetMostCommonBitByPosition(bitArrayInputs, position);
    

    private bool[] FilterByMostCommonValues(bool[][] bitArrayInputs) =>
        FilterByCommonValues(bitArrayInputs, GetMostCommonBitByPosition, 0);
    
    private bool[] FilterByLessCommonValues(bool[][] bitArrayInputs) =>
        FilterByCommonValues(bitArrayInputs, GetLessCommonBitByPosition, 0);
    
    private bool[] FilterByCommonValues(bool[][] bitArrayInputs,Func<bool[][], int, bool> commonBitSelectorFunction, int position = 0)
    {
        bool mostCommonBit = commonBitSelectorFunction.Invoke(bitArrayInputs, position);

        bool[][] result = bitArrayInputs.Where(input => mostCommonBit == input[position]).ToArray();
        if (result.Length <= 1)
            return result[0];

        return FilterByCommonValues(result,commonBitSelectorFunction, (position + 1));
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
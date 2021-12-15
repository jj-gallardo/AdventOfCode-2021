namespace AdventOfCode2021.InputLoaders;

public class FileInputLoader : IInputLoader
{
    private readonly string _filePath;

    public FileInputLoader(string filePath)
    {
        _filePath = filePath;
    }

    public IEnumerable<string> GetInput()
    {
        return File.ReadLines(_filePath);
    }
}
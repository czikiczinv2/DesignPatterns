namespace DesignPatterns.Builder;

public class Car
{
    private readonly List<string> _parts = new List<string>();
        
    public void Add(string part)
    {
        _parts.Add(part);
    }

    public void DisplayParts()
    {
        foreach (var part in _parts)
        {
            Console.WriteLine(part);
        }
    }
}
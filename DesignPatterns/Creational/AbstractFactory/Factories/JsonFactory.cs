namespace AbstractFactory.Factories;

public class JsonFactory : IFormatFactory
{
    public string Start()
    {
        return "{\n\tvalues: [";
    }

    public string AddValues(int[] values)
    {
        return string.Join(", ", values);
    }

    public string End()
    {
        return "]\n}";
    }
}
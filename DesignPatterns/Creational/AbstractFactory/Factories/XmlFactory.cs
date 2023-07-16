namespace AbstractFactory.Factories;

public class XmlFactory : IFormatFactory
{
    public string Start()
    {
        return "<values>\n";
    }

    public string AddValues(int[] values)
    {
        string s = string.Empty;
        
        foreach (int value in values)
            s += $"\t<value>{value}</value>\n";

        return s;
    }

    public string End()
    {
        return "</values>";
    }
}
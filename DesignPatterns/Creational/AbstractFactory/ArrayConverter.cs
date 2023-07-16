using AbstractFactory.Factories;

namespace AbstractFactory;

public class ArrayConverter
{
    private readonly IFormatFactory _formatFactory;
    
    public ArrayConverter(IFormatFactory formatFactory)
    {
        _formatFactory = formatFactory;
    }

    // This method could return IFile (JsonFIle or XmlFIle implementations)
    public string Create(int[] values)
    {
        string result = string.Empty;
        
        result += _formatFactory.Start();
        result += _formatFactory.AddValues(values);
        result += _formatFactory.End();

        return result;
    }
}
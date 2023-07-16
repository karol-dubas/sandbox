namespace AbstractFactory.Factories;

public interface IFormatFactory
{
    string Start();
    string AddValues(int[] values);
    string End();
}
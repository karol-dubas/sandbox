namespace Benchmarks.Benchmarks.ListVsDictionary;

public class People
{
    private static readonly Person Random1 = new(
        Guid.Parse("984FB325-8F63-49B8-81F9-37385E8DB81B"),
        "Jan",
        "Kowalski",
        DateTime.Now);

    private static readonly Person Random2 = new(
        Guid.Parse("68B7A9C9-0856-4290-9DAB-CAB6B2CCF7F2"),
        "Adam",
        "Nowak",
        DateTime.Now);

    private static readonly Person Wanted = new(
        Guid.Parse("46E6040A-1C26-419A-83A5-E8ECCEC71187"),
        "Stanisław",
        "Błoński",
        DateTime.Now);

    public Dictionary<Guid, Person> DictionaryWhereFirst { get; } = new()
    {
        { Wanted.Id, Wanted },
        { Random2.Id, Random1 },
        { Random1.Id, Random1 }
    };

    public Dictionary<Guid, Person> DictionaryWhereLast { get; } = new()
    {
        { Random2.Id, Random1 },
        { Random1.Id, Random1 },
        { Wanted.Id, Wanted }
    };

    public Dictionary<Guid, Person> DictionaryWhereMiddle { get; } = new()
    {
        { Random2.Id, Random1 },
        { Wanted.Id, Wanted },
        { Random1.Id, Random1 }
    };

    public List<Person> ListWhereFirst { get; } = new()
    {
        Wanted,
        Random2,
        Random1
    };

    public List<Person> ListWhereLast { get; } = new()
    {
        Random2,
        Random1,
        Wanted
    };

    public List<Person> ListWhereMiddle { get; } = new()
    {
        Random2,
        Wanted,
        Random1
    };
    
    public Person[] ArrayWhereFirst { get; } = 
    {
        Wanted,
        Random2,
        Random1
    };
    
    public Person[] ArrayWhereMiddle { get; } = 
    {
        Random2,
        Wanted,
        Random1
    };
    
    public Person[] ArrayWhereLast { get; } = 
    {
        Random2,
        Random1,
        Wanted
    };

    public Guid WantedId
    {
        get => Wanted.Id;
    }
    
}
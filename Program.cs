
public class Program
{

    static void Main(string[] args)
    {
      Console.WriteLine("TryGet Pattern..."); 
      Console.WriteLine("Input same name: ");
      var name = Console.ReadLine();

      Console.WriteLine(WithTryGetPatternPersonByName(name, out var person) 
          ? $"Selected person: {person.Name}"
          : $"Person {name} not found");

       var _person = WithouthTryGetPatternPersonByName(name);
      Console.WriteLine($"Select person: {_person.Name}");

      Console.ReadKey();
    }

    static bool WithTryGetPatternPersonByName(string name, out Person person)
    {
      var persons = CreatePersons();

      person = persons
        .FirstOrDefault(_ => _.Name.Equals("name"));

      return person is not null;
    }

    //Possible NullReference
    static Person WithouthTryGetPatternPersonByName(string name)
    {
      var persons = CreatePersons();

      var result = persons
        .FirstOrDefault(_ => _.Name.Equals("name"));

      return result;
    }

     static List<Person> CreatePersons()
    {
      return new List<Person>(5)
      {
        new() { Name = "Feuser" },
        new() { Name = "Lucas" },
        new() { Name = "Amanda" },
        new() { Name = "Braga" },
        new() { Name = "Sakura" },
      };
    }
}

public class Person
{
  public string Name { get; set; }
  public int Age { get; set; }
}

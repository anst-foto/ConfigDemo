using System.Text.Json;
using ConfigDemo;

var config = Config.GetConfig();

var person = JsonSerializer.Deserialize<Person>(File.ReadAllText(config.Path));
Console.WriteLine($"{person.LastName} {person.FirstName} - {person.BirthDate:d}");

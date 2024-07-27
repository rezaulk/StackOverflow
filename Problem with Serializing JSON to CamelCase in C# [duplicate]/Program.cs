using System.Text.Json;

var json = "{ \"Key\": \"TextA\" }";

var options = new JsonSerializerOptions
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
};

//var person = JsonSerializer.Deserialize<Dictionary<string, object>>(json, options);

var person = JsonSerializer.Deserialize<Person>(json, options);

string json2 = JsonSerializer.Serialize(person, options);
// { "name": "Luke", age: 30 }
Console.WriteLine(json2);
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Key { get; set; }

}
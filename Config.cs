using System.Text.Json;

namespace ConfigDemo;

public class Config
{
    public string Path { get; set; }

    public static Config GetConfig(string path = "appsettings.json")
    {
        var json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<Config>(json);
    }
}
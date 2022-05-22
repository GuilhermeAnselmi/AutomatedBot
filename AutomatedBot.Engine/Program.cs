using Newtonsoft.Json;

namespace AutomatedBot.Engine;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program key:value key:value\n");

        string json = "{";

        foreach (string arg in args)
        {
            string key = arg.Split(':')[0];
            string value = arg.Split(':')[1];

            json += $"\"{key}\":\"{value}\",";
        }

        json += "}";

        Console.WriteLine(json + "\n");

        Dictionary<string, string> obj = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

        Console.WriteLine(obj.Keys.ToList()[0]);
    }
}
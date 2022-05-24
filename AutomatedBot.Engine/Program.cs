using AutomatedBot.Engine.Model;
using Newtonsoft.Json;

namespace AutomatedBot.Engine;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("AutomatedBot.Engine.exe ROUTINE_NAME KEY:VALUE KEY:VALUE\n");

        string routine = "";
        string json = "{";

        foreach (string arg in args)
        {
            try
            {
                if (arg.Split(':').Length > 1)
                {
                    string key = arg.Split(':')[0];
                    string value = arg.Split(':')[1];

                    json += $"\"{key}\":\"{value}\",";
                }
                else if (routine == "")
                {
                    routine = arg;
                }
            }
            catch
            {
                Console.WriteLine("Nao foi possivel compreender os argumentos de entrada\n");
                Console.WriteLine("Modelo padrao: AutomatedBot.Engine.exe ROUTINE_NAME KEY:VALUE KEY:VALUE");
            }
        }

        json += "}";

        //Testing(routine, json);

        routine = "Testing";
        json = "{" + "\"Name\":\"Guilherme\",\"Email\":\"guianselmi.sa@hotmail.com\",\"Age\":\"22\"," + "}";

        if (!string.IsNullOrEmpty(routine))
        {
            StartEngine(routine, json);
        }
        else
        {
            Console.WriteLine("Nome da rotina deve ser preenchido");
        }
    }

    public static void StartEngine(string routineName, string json, bool debug = false, string stage = null)
    {
        bool exec = true;

        if (debug)
        {
            if (stage != null)
            {
                exec = true;
            }
            else
            {
                exec = false;
            }
        }

        if (exec)
        {
            exec = false;

            if (Directory.Exists(Directory.GetCurrentDirectory() + "\\FilesJson\\"))
            {
                Routine routine = null;

                var files = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\FilesJson\\");

                foreach (var file in files)
                {
                    Routine obj = JsonConvert.DeserializeObject<Routine>(File.ReadAllText(file));

                    if (obj.Name == routineName) routine = obj;
                }

                if (routine != null)
                {
                    Dictionary<string, string> parameters = new Dictionary<string, string>();

                    try
                    {
                        parameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                        exec = true;
                    }
                    catch
                    {
                        Console.WriteLine("Nao foi possivel compreender os parametros de inicializacao");
                    }

                    if (exec)
                    {
                        Engine engine = new Engine(routine, parameters, debug, stage);

                        engine.Run();
                    }
                }
                else
                {
                    Console.WriteLine("A rotina informada nao foi encontrada.");
                }
            }
            else
            {
                Console.WriteLine("Diretorio das rotinas nao foi encontrado.");
            }
        }
        else
        {
            Console.WriteLine("O Debug esta ativo. Com o Debug ativo a etapa deve ser informada.");
        }
    }

    private static void Testing(string routine, string json)
    {
        Dictionary<string, string> obj = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

        //Console.WriteLine(obj);

        Console.WriteLine(routine);

        Console.WriteLine(obj.Keys.ToList()[0]);
    }
}
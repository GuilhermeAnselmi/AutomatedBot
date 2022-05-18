using AutomatedBot.Model;
using Newtonsoft.Json;

namespace AutomatedBot.Control.Data
{
    internal class JsonDb
    {
        private readonly string Path = Directory.GetCurrentDirectory() + "\\FilesJson\\";
        private string AllPath;
        public string Name;
        public string FileName;

        public JsonDb(string name = null)
        {
            Name = name;
            FileName = name + ".json";
            AllPath = Path + FileName;

            if (!Directory.Exists(Path)) Directory.CreateDirectory(Path);
        }

        public Tuple<bool, string> Create()
        {
            try
            {
                if (FileName != null)
                {
                    if (!File.Exists(AllPath))
                    {
                        File.Create(AllPath).Close();

                        Routine routine = new Routine();

                        routine.Name = Name;
                        routine.FileName = FileName;

                        File.WriteAllText(AllPath, JsonConvert.SerializeObject(routine));

                        return new Tuple<bool, string>(true, null);
                    }
                    else
                    {
                        return new Tuple<bool, string>(false, "Arquivo já existe");
                    }
                }
                else
                {
                    return new Tuple<bool, string>(false, "Nome do arquivo não pode ser nulo");
                }
            }
            catch(Exception ex)
            {
                return new Tuple<bool, string>(false, $"Error: {ex}");
            }
        }
    }
}

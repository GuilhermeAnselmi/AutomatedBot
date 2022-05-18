using AutomatedBot.Model;
using Newtonsoft.Json;

namespace AutomatedBot.Control.Data
{
    internal class JsonDb
    {
        private static readonly string Path = Directory.GetCurrentDirectory() + "\\FilesJson\\";

        public static Tuple<bool, string> Create(string name)
        {
            try
            {
                string fileName = name.Replace(" ", "") + ".json";

                if (!Directory.Exists(Path)) Directory.CreateDirectory(Path);

                if (!string.IsNullOrEmpty(name))
                {
                    if (!File.Exists(Path + fileName))
                    {
                        File.Create(Path + fileName).Close();

                        Routine routine = new Routine();

                        routine.Name = name;
                        routine.FileName = fileName;

                        File.WriteAllText(Path + fileName, JsonConvert.SerializeObject(routine));

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

        public static List<Routine> GetAllRoutines()
        {
            List<Routine> routines = new List<Routine>();

            string[] files = Directory.GetFiles(Path);

            foreach (string file in files)
            {
                Routine routine = new Routine();

                routine = JsonConvert.DeserializeObject<Routine>(File.ReadAllText(file));

                routines.Add(routine);
            }

            return routines;
        }

        public static Routine GetRoutine(string name)
        {
            List<Routine> routines = GetAllRoutines();

            Routine routine = routines.Where<Routine>(x => x.Name == name).First();

            return routine;
        }
    }
}

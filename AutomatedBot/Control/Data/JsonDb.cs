using AutomatedBot.Engine.Model;
using Newtonsoft.Json;

namespace AutomatedBot.Control.Data
{
    internal class JsonDb
    {
        private static readonly string Path = Directory.GetCurrentDirectory() + "\\FilesJson\\";
        private static readonly string InputParams = Path + "\\Configs\\_InputParams.json";
        private static readonly string TempPath = Path + "\\Temp\\";

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

        public static Tuple<bool, string> RewriteObject(string fileName, string json)
        {
            try
            {
                if (File.Exists(Path + fileName))
                {
                    File.WriteAllText(Path + fileName, json);

                    return new Tuple<bool, string>(true, null);
                }
                else
                {
                    return new Tuple<bool, string>(false, $"Erro: Arquivo não localizado");
                }
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, $"Error: {ex}");
            }
        }

        public static bool RemoveRoutine(string fileName)
        {


            try
            {
                if (File.Exists(Path + fileName))
                {
                    File.Delete(Path + fileName);

                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public static List<Routine> GetAllRoutines()
        {
            List<Routine> routines = new List<Routine>();

            if (Directory.Exists(Path))
            {

                string[] files = Directory.GetFiles(Path);

                foreach (string file in files)
                {
                    Routine routine = new Routine();

                    routine = JsonConvert.DeserializeObject<Routine>(File.ReadAllText(file));

                    routines.Add(routine);
                }
            }

            return routines;
        }

        public static Routine GetRoutine(string name)
        {
            List<Routine> routines = GetAllRoutines();

            Routine routine = routines.Where<Routine>(x => x.Name == name).First();

            return routine;
        }

        public static List<Stage> GetAllStages(string routineName)
        {
            List<Stage> stages = GetRoutine(routineName).Stage;

            return stages == null ? new List<Stage>() : stages;
        }

        public static Stage GetStage(string routineName, string stageName)
        {
            Stage stage = GetRoutine(routineName).Stage.Where(x => x.Name == stageName).FirstOrDefault();

            return stage;
        }

        public static bool RemoveStage(string routineName, string fileName, string stageName)
        {
            Routine routine = GetRoutine(routineName);

            routine.Stage.Remove(routine.Stage.Where(x => x.Name == stageName).First());

            if (File.Exists(Path + fileName))
            {
                File.WriteAllText(Path + fileName, JsonConvert.SerializeObject(routine));

                return true;
            }

            return false;
        }

        #region Params Inicialization
        public static Tuple<bool, string> SaveParamInicialization(string routineName, object jsonParams)
        {
            try
            {
                List<ParamsInicialization> pi = new List<ParamsInicialization>();

                string content = "";

                if (!Directory.Exists(Path + "\\Configs"))
                {
                    Directory.CreateDirectory(Path + "\\Configs");
                }

                if (!File.Exists(InputParams))
                {
                    File.Create(InputParams).Close();
                }
                else
                {
                    pi = JsonConvert.DeserializeObject<List<ParamsInicialization>>(File.ReadAllText(InputParams));
                }

                pi = pi.Where(x => x.RoutineName != routineName).ToList();

                pi.Add(new ParamsInicialization() { RoutineName = routineName, InputParams = jsonParams });

                string json = JsonConvert.SerializeObject(pi);

                File.WriteAllText(InputParams, json);

                return new Tuple<bool, string>(true, null);
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, $"Error: {ex}");
            }
        }

        public static string GetParamInicialization(string routineName)
        {
            List<ParamsInicialization> pi = new List<ParamsInicialization>();

            string json = "";

            if (Directory.Exists(Path + "\\Configs\\"))
            {
                pi = JsonConvert.DeserializeObject<List<ParamsInicialization>>(File.ReadAllText(InputParams));

                ParamsInicialization obj = pi.Where(x => x.RoutineName == routineName).FirstOrDefault();

                if (obj != null)
                {
                    json = JsonConvert.SerializeObject(obj.InputParams);
                }
            }

            return json;
        }
        #endregion

        #region Temp
        public static void CreateTempFile(string nameTemp)
        {
            string fineName = nameTemp + ".temp";

            if (!Directory.Exists(TempPath)) Directory.CreateDirectory(TempPath);

            if (File.Exists(TempPath + fineName)) File.Delete(TempPath + fineName);

            File.Create(TempPath + fineName).Close();
        }

        public static Tuple<bool, string> ReadTempFile(string nameTemp)
        {
            string fileName = nameTemp + ".temp";

            if (File.Exists(TempPath + fileName))
            {
                string json = File.ReadAllText(TempPath + fileName);

                return new Tuple<bool, string>(true, json);
            }
            else
            {
                return new Tuple<bool, string>(false, "Arquivo temporario não encontrado");
            }
        }

        public static bool WriteTempFile(string nameTemp, string content)
        {
            string fileName = nameTemp + ".temp";

            if (File.Exists(TempPath + fileName))
            {
                File.WriteAllText(TempPath + fileName, content);

                return true;
            }
            else
            {
                return false;
            }
        }

        public static void DeleteTempFile(string nameTemp)
        {
            string fileName = nameTemp + ".temp";

            if (File.Exists(TempPath + fileName))
            {
                File.Delete(TempPath + fileName);
            }
        }

        public static bool ClearTempFiles()
        {
            if (Directory.Exists(TempPath))
            {
                bool verify = false;
                string[] files = Directory.GetFiles(TempPath);

                foreach (string file in files)
                {
                    File.Delete(file);

                    verify = true;
                }

                if (verify) return true;
            }

            return false;
        }
        #endregion
    }
}

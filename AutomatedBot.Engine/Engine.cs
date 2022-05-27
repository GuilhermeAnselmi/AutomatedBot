using AutomatedBot.Engine.Model;
using KlusterG.AutoGui;
using KlusterG.AutoGui.InternalKeys;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AutomatedBot.Engine
{
    internal class Engine
    {
        private Routine _routine;
        private Dictionary<string, string> _parameters;
        private bool Debug;
        private string StageBreak;

        private MarkConditional ConditionalValue;
        private bool Loop;

        private string RoutineName;
        private bool NextRoutine;
        private bool IsLooping;

        public Engine(Routine routine, Dictionary<string, string> parameters, bool debug, string stageBreak)
        {
            _routine = routine;
            _parameters = parameters;
            Debug = debug;
            StageBreak = stageBreak;

            ConditionalValue = MarkConditional.None;
            Loop = true;

            RoutineName = _routine.Name;
            NextRoutine = true;
            IsLooping = false;
        }

        public void Run()
        {
            try
            {
                while (NextRoutine)
                {
                    NextRoutine = false;

                    foreach (Stage stage in _routine.Stage)
                    {
                        if (stage.MarkConditional == MarkConditional.None || ConditionalValue == MarkConditional.None ||
                            (stage.MarkConditional == ConditionalValue))
                        {
                            switch (stage.Function)
                            {
                                case "SimpleClick":
                                    SimpleClick(stage);
                                    break;

                                case "RightClick":
                                    RightClick(stage);
                                    break;

                                case "DoubleClick":
                                    DoubleClick(stage);
                                    break;

                                case "Write":
                                    Write(stage);
                                    break;

                                case "ClickKey":
                                    ClickKey(stage);
                                    break;

                                case "PressKey":
                                    PressKey(stage);
                                    break;

                                case "ReleaseKey":
                                    ReleaseKey(stage);
                                    break;

                                case "WaitColor":
                                    WaitColor(stage);
                                    break;

                                case "WaitColorCondition":
                                    WaitColorCondition(stage);
                                    break;

                                case "Condition":
                                    Condition(stage);
                                    break;

                                case "CommandLine":
                                    CommandLine(stage);
                                    break;

                                default:
                                    throw new EngineException("Function Not Exists");
                                    break;
                            }
                        }

                        if (_routine.Name != RoutineName)
                        {
                            SetNewRoutine(RoutineName);

                            ConditionalValue = MarkConditional.None;
                            Loop = true;

                            RoutineName = _routine.Name;
                            NextRoutine = true;

                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new EngineException("Erro", ex);
            }
        }

        private void SimpleClick(Stage stage)
        {
            try
            {
                Exec.StartProcedure(stage.Procedure);
            }
            catch
            {
                throw new EngineException($"SimpleClick error: Routine: {_routine.Name} - Stage:{stage.Name}");
            }
        }

        private void RightClick(Stage stage)
        {
            try
            {
                Exec.StartProcedure(stage.Procedure);
            }
            catch
            {
                throw new EngineException($"RightClick error: Routine: {_routine.Name} - Stage:{stage.Name}");
            }
        }

        private void DoubleClick(Stage stage)
        {
            try
            {
                Exec.StartProcedure(stage.Procedure);
            }
            catch
            {
                throw new EngineException($"DoubleClick error: Routine: {_routine.Name} - Stage:{stage.Name}");
            }
        }

        private void Write(Stage stage)
        {
            try
            {
                stage.Procedure.Keyboard.Text = RefactorText(stage.Procedure.Keyboard.Text);
                
                Exec.StartProcedure(stage.Procedure);
            }
            catch
            {
                throw new EngineException($"Write error: Routine: {_routine.Name} - Stage:{stage.Name}");
            }
        }

        private void ClickKey(Stage stage)
        {
            try
            {
                Exec.StartProcedure(stage.Procedure);
            }
            catch
            {
                throw new EngineException($"ClickKey error: Routine: {_routine.Name} - Stage:{stage.Name}");
            }
        }

        private void PressKey(Stage stage)
        {
            try
            {
                Exec.StartProcedure(stage.Procedure);
            }
            catch
            {
                throw new EngineException($"PressKey error: Routine: {_routine.Name} - Stage:{stage.Name}");
            }
        }

        private void ReleaseKey(Stage stage)
        {
            try
            {
                Exec.StartProcedure(stage.Procedure);
            }
            catch
            {
                throw new EngineException($"ReleaseKey error: Routine: {_routine.Name} - Stage:{stage.Name}");
            }
        }

        private void WaitColor(Stage stage)
        {
            try
            {
                TimeSpan initialTime = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss.ffff"));
                TimeSpan time;

                while (Loop)
                {
                    PixelColor color = Exec.GetPixelColor(stage.Procedure.Mouse.X, stage.Procedure.Mouse.Y);

                    if (color.R == stage.PColor.R && 
                        color.G == stage.PColor.G && 
                        color.B == stage.PColor.B && 
                        color.A == stage.PColor.A) break;

                    time = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss.ffff")) - initialTime;

                    if (Math.Round(time.TotalSeconds, 0) >= int.Parse(stage.Timeout.Timeout.ToString()) &&
                        stage.Timeout.RoutineTimeout != null)
                    {
                        Loop = false;
                    }
                }

                if (!Loop)
                {
                    RoutineName = stage.Timeout.RoutineTimeout;
                }

                Loop = true;
            }
            catch
            {
                throw new EngineException($"WaitColor error: Routine: {_routine.Name} - Stage:{stage.Name}");
            }
        }

        private void WaitColorCondition(Stage stage)
        {
            try
            {
                bool color1 = false, color2 = false, color3 = false;

                TimeSpan initialTime = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss.ffff"));
                TimeSpan time;

                while (Loop)
                {
                    if (stage.ColorsCondition.Count >= 1)
                    {
                        PixelColor color = Exec.GetPixelColor(stage.ColorsCondition[0].X, stage.ColorsCondition[0].Y);

                        if (color.R == stage.ColorsCondition[0].R &&
                            color.G == stage.ColorsCondition[0].G &&
                            color.B == stage.ColorsCondition[0].B &&
                            color.A == stage.ColorsCondition[0].A)
                        {
                            color1 = true;

                            break;
                        }
                    }

                    if (stage.ColorsCondition.Count >= 2)
                    {
                        PixelColor color = Exec.GetPixelColor(stage.ColorsCondition[1].X, stage.ColorsCondition[1].Y);

                        if (color.R == stage.ColorsCondition[1].R &&
                            color.G == stage.ColorsCondition[1].G &&
                            color.B == stage.ColorsCondition[1].B &&
                            color.A == stage.ColorsCondition[1].A)
                        {
                            color2 = true;

                            break;
                        }
                    }

                    if (stage.ColorsCondition.Count >= 3)
                    {
                        PixelColor color = Exec.GetPixelColor(stage.ColorsCondition[2].X, stage.ColorsCondition[2].Y);

                        if (color.R == stage.ColorsCondition[2].R &&
                            color.G == stage.ColorsCondition[2].G &&
                            color.B == stage.ColorsCondition[2].B &&
                            color.A == stage.ColorsCondition[2].A)
                        {
                            color3 = true;

                            break;
                        }
                    }

                    time = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss.ffff")) - initialTime;

                    if (Math.Round(time.TotalSeconds, 0) >= int.Parse(stage.Timeout.Timeout.ToString()) &&
                        stage.Timeout.RoutineTimeout != null)
                    {
                        Loop = false;
                    }
                }

                if (color1)
                {
                    RoutineName = stage.ColorsCondition[0].NextRoutine;
                }
                else if (color2)
                {
                    RoutineName = stage.ColorsCondition[1].NextRoutine;
                }
                else if (color3)
                {
                    RoutineName = stage.ColorsCondition[2].NextRoutine;
                }

                if (!Loop)
                {
                    RoutineName = stage.Timeout.RoutineTimeout;
                }

                Loop = true;
            }
            catch
            {
                throw new EngineException($"WaitColorCondition error: Routine: {_routine.Name} - Stage:{stage.Name}");
            }
        }

        private void Condition(Stage stage)
        {
            try
            {
                bool verify = true;
                int count = 0;
                int logicalOperator = stage.Conditions[0].LogicalOperator;

                foreach (Condition con in stage.Conditions)
                {
                    var param = _parameters.Where(x => x.Key == con.Key).FirstOrDefault();

                    switch (con.Operator)
                    {
                        case 0:
                            if (param.Value == con.Value)
                            {
                                if (count == 0)
                                {
                                    verify &= true;
                                }
                                else
                                {
                                    if (logicalOperator == 1) verify &= true;
                                    if (logicalOperator == 2) verify |= true;
                                }
                            }
                            else
                            {
                                if (count == 0)
                                {
                                    verify &= false;
                                }
                                    else
                                {
                                    if (logicalOperator == 1) verify &= false;
                                    if (logicalOperator == 2) verify |= false;
                                }
                            }
                            break;

                        case 1:
                            if (param.Value != con.Value)
                            {
                                if (count == 0)
                                {
                                    verify &= true;
                                }
                                else
                                {
                                    if (logicalOperator == 1) verify &= true;
                                    if (logicalOperator == 2) verify |= true;
                                }
                            }
                            else
                            {
                                if (count == 0)
                                {
                                    verify &= false;
                                }
                                else
                                {
                                    if (logicalOperator == 1) verify &= false;
                                    if (logicalOperator == 2) verify |= false;
                                }
                            }
                            break;

                        case 2:
                            if (int.Parse(param.Value) > int.Parse(con.Value))
                            {
                                if (count == 0)
                                {
                                    verify &= true;
                                }
                                else
                                {
                                    if (logicalOperator == 1) verify &= true;
                                    if (logicalOperator == 2) verify |= true;
                                }
                            }
                            else
                            {
                                if (count == 0)
                                {
                                    verify &= false;
                                }
                                else
                                {
                                    if (logicalOperator == 1) verify &= false;
                                    if (logicalOperator == 2) verify |= false;
                                }
                            }
                            break;

                        case 3:
                            if (int.Parse(param.Value) < int.Parse(con.Value))
                            {
                                if (count == 0)
                                {
                                    verify &= true;
                                }
                                else
                                {
                                    if (logicalOperator == 1) verify &= true;
                                    if (logicalOperator == 2) verify |= true;
                                }
                            }
                            else
                            {
                                if (count == 0)
                                {
                                    verify &= false;
                                }
                                else
                                {
                                    if (logicalOperator == 1) verify &= false;
                                    if (logicalOperator == 2) verify |= false;
                                }
                            }
                            break;
                    }

                    count++;
                }

                if (verify)
                {
                    ConditionalValue = MarkConditional.True;
                }
                else
                {
                    ConditionalValue = MarkConditional.False;
                }
            }
            catch
            {
                throw new EngineException($"Condition error: Routine: {_routine.Name} - Stage:{stage.Name}");
            }
        }

        private void CommandLine(Stage stage)
        {
            try
            {
                stage.CommandLine = RefactorText(stage.CommandLine);

                Process.Start("cmd.exe", "/C " + stage.CommandLine);
            }
            catch
            {
                throw new EngineException($"CommandLine error: Routine: {_routine.Name} - Stage:{stage.Name}");
            }
        }

        private string RefactorText(string text)
        {
            Regex regex = new Regex(@"[?]+[a-zA-Z0-9]*[?]");

            MatchCollection match = regex.Matches(text);

            foreach (var item in match)
            {
                string value = _parameters[item.ToString().Replace("?", "")];

                text = text.Replace(item.ToString(), value);
            }

            return text;
        }

        private void SetNewRoutine(string routineName)
        {
            var files = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\FilesJson\\");

            foreach (var file in files)
            {
                Routine obj = JsonConvert.DeserializeObject<Routine>(File.ReadAllText(file));

                if (obj.Name == routineName) _routine = obj;
            }
        }
    }
}

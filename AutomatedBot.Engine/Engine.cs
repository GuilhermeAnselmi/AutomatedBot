using AutomatedBot.Engine.Model;
using KlusterG.AutoGui;
using KlusterG.AutoGui.InternalKeys;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AutomatedBot.Engine
{
    internal class Engine
    {
        private Routine _routine;
        private Dictionary<string, string> _parameters;
        private bool Debug;
        private string Stage;

        private MarkConditional ConditionalValue;

        public Engine(Routine routine, Dictionary<string, string> parameters, bool debug, string stage)
        {
            _routine = routine;
            _parameters = parameters;
            Debug = debug;
            Stage = stage;

            ConditionalValue = MarkConditional.None;
        }

        public void Run()
        {
            try
            {
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
                                throw new EngineException("");
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
                Exec.Wait(2);
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
                while (true)
                {
                    PixelColor color = Exec.GetPixelColor(stage.Procedure.Mouse.X, stage.Procedure.Mouse.Y);

                    if (color.R == stage.PColor.R && 
                        color.G == stage.PColor.G && 
                        color.B == stage.PColor.B && 
                        color.A == stage.PColor.A) break;
                }
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
                Exec.StartProcedure(stage.Procedure);
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
                Process.Start("cmd.exe", "/C " + stage.CommandLine);
            }
            catch
            {
                throw new EngineException($"CommandLine error: Routine: {_routine.Name} - Stage:{stage.Name}");
            }
        }

        private string RefactorText(string text)
        {
            Regex regex = new Regex(@"[?]+[a-zA-Z0-9]*");

            MatchCollection match = regex.Matches(text);

            foreach (var item in match)
            {
                string value = _parameters[item.ToString().Substring(1)];

                text = text.Replace(item.ToString(), value);
            }

            return text;
        }
    }
}

using AutomatedBot.Control.Data;
using AutomatedBot.Engine.Model;
using KlusterG.AutoGui;
using KlusterG.AutoGui.InternalKeys;
using Newtonsoft.Json;

namespace AutomatedBot.Control
{
    internal class StructureStage
    {
        private Routine _routine;

        private int InsertIndex;

        private string Name;
        private string Comment;
        private string Function;
        private int X;
        private int Y;
        private bool Move;
        private double Wait;
        private MarkConditional MarkConditional;

        private string Command;

        private Stage _stage;

        private ModelProcedure _procedure;
        private Mouse _mouse;
        private Keyboard _keyboard;
        private PixelColor _pixelColor;
        private List<WaitColorsCondition> _colorsCondition;
        private List<Condition> _conditions;
        private TimeoutRoutine _timeout;

        public StructureStage(Routine routine, string name, string comment, int x, int y, bool move, double wait,
            int markConditional, int insertIndex = -1)
        {
            _routine = routine;

            InsertIndex = insertIndex;

            Name = name;
            Comment = comment;
            X = x;
            Y = y;
            Move = move;
            Wait = wait;
            MarkConditional = MarkConditional.None;

            if (markConditional == 1)
            {
                MarkConditional = MarkConditional.True;
            }
            else if (markConditional == 2)
            {
                MarkConditional = MarkConditional.False;
            }

            _mouse = new Mouse() { Action = MouseAction.None };
            _keyboard = new Keyboard();
            _pixelColor = new PixelColor();
            _colorsCondition = new List<WaitColorsCondition>();
            _conditions = new List<Condition>();
            _timeout = new TimeoutRoutine();
        }

        private void Create()
        {
            _procedure = new ModelProcedure()
            {
                Input = InputProcedure.Both,
                Mouse = _mouse,
                Keyboard = _keyboard,
                Wait = this.Wait,
            };

            _stage = new Stage()
            {
                Name = this.Name,
                Comment = this.Comment,
                Function = this.Function,
                MarkConditional = this.MarkConditional,
                Procedure = _procedure,
                PColor = _pixelColor,
                ColorsCondition = _colorsCondition,
                Conditions = _conditions,
                Timeout = _timeout,
                CommandLine = this.Command,
            };

            if (_routine.Stage != null)
            {
                if (_routine.Stage.Where(x => x.Name == this.Name).Any())
                {
                    _routine.Stage.Where(x => x.Name == this.Name).First().Comment = this.Comment;
                    _routine.Stage.Where(x => x.Name == this.Name).First().Function = this.Function;
                    _routine.Stage.Where(x => x.Name == this.Name).First().MarkConditional = this.MarkConditional;
                    _routine.Stage.Where(x => x.Name == this.Name).First().Procedure = _procedure;
                    _routine.Stage.Where(x => x.Name == this.Name).First().PColor = _pixelColor;
                    _routine.Stage.Where(x => x.Name == this.Name).First().ColorsCondition = _colorsCondition;
                    _routine.Stage.Where(x => x.Name == this.Name).First().Conditions = _conditions;
                    _routine.Stage.Where(x => x.Name == this.Name).First().Timeout = _timeout;
                    _routine.Stage.Where(x => x.Name == this.Name).First().CommandLine = this.Command;
                }
                else
                {
                    if (InsertIndex >= 0)
                    {
                        _routine.Stage.Insert(InsertIndex, _stage);
                    }
                    else
                    {
                        _routine.Stage.Add(_stage);
                    }
                }
            }
            else
            {
                _routine.Stage = new List<Stage>() { _stage };
            }

            string json = JsonConvert.SerializeObject(_routine);

            JsonDb.RewriteObject(_routine.FileName, json);
        }

        private void DefineMouse(MouseAction action = MouseAction.None, MKeys key = MKeys.Left)
        {
            _mouse = new Mouse()
            {
                X = X,
                Y = Y,
                Move = Move,
                Action = action,
                Key = key,
            };
        }

        private void DefineKeyboard(KeyboardAction action = KeyboardAction.Write, int primary = 0, int secondary = 0, int tertiary = 0, string text = "")
        {
            _keyboard = new Keyboard()
            {
                Action = action,
                PrimaryKey = ConvertKey(primary),
                SecondaryKey = ConvertKey(secondary),
                TertiaryKey = ConvertKey(tertiary),
                Text = text,
            };
        }

        private void DefineTimeout(int timeout, string routineTimeout)
        {
            _timeout = new TimeoutRoutine()
            {
                Timeout = timeout,
                RoutineTimeout = routineTimeout == "-" ? null : routineTimeout,
            };
        }

        public void SimpleClick(bool simpleClick)
        {
            Function = "SimpleClick";

            if (simpleClick)
            {
                DefineMouse(MouseAction.Click);
            }
            else
            {
                DefineMouse();
            }

            Create();
        }

        public void RightClick()
        {
            Function = "RightClick";

            DefineMouse(MouseAction.Click, MKeys.Right);

            Create();
        }

        public void DoubleClick()
        {
            Function = "DoubleClick";

            DefineMouse(MouseAction.Double);

            Create();
        }

        public void Write(bool simpleClick, string text)
        {
            Function = "Write";

            if (simpleClick)
            {
                DefineMouse(MouseAction.Click);
            }
            else
            {
                DefineMouse();
            }

            DefineKeyboard(KeyboardAction.Write, text:text);

            Create();
        }

        public void ClickKey(bool simpleClick, int keyOne, int keyTwo, int keyThree)
        {
            Function = "ClickKey";

            if (simpleClick)
            {
                DefineMouse(MouseAction.Click);
            }
            else
            {
                DefineMouse();
            }

            DefineKeyboard(KeyboardAction.Click, keyOne, keyTwo, keyThree);

            Create();
        }

        public void PressKey(bool simpleClick, int keyOne, int keyTwo, int keyThree)
        {
            Function = "PressKey";

            if (simpleClick)
            {
                DefineMouse(MouseAction.Click);
            }
            else
            {
                DefineMouse();
            }

            DefineKeyboard(KeyboardAction.Press, keyOne, keyTwo, keyThree);

            Create();
        }

        public void ReleaseKey(bool simpleClick, int keyOne, int keyTwo, int keyThree)
        {
            Function = "ReleaseKey";

            if (simpleClick)
            {
                DefineMouse(MouseAction.Click);
            }
            else
            {
                DefineMouse();
            }

            DefineKeyboard(KeyboardAction.Release, keyOne, keyTwo, keyThree);

            Create();
        }

        public void WaitColor(PixelColor color, int timeout, string routineTimeout)
        {
            Function = "WaitColor";

            _pixelColor = color;

            DefineTimeout(timeout, routineTimeout);

            DefineMouse();

            Create();
        }

        public void WaitColorCondition(List<WaitColorsCondition> conditions, int timeout, string routineTimeout)
        {
            Function = "WaitColorCondition";

            _colorsCondition = conditions;

            DefineTimeout(timeout, routineTimeout);

            DefineMouse();

            Create();
        }

        public void Condition(List<Condition> conditions)
        {
            Function = "Condition";

            _conditions = conditions;

            DefineMouse();

            Create();
        }

        public void CommandLine(string text)
        {
            Function = "CommandLine";

            Command = text;

            DefineMouse();

            Create();
        }

        private KKeys ConvertKey(int value)
        {
            if (value == 0) return KKeys.None;
            if (value == 1) return KKeys.Ctrl;
            if (value == 2) return KKeys.Shift;
            if (value == 3) return KKeys.Tab;
            if (value == 4) return KKeys.Caps;
            if (value == 5) return KKeys.Alt;
            if (value == 6) return KKeys.Win;
            if (value == 7) return KKeys.Esc;
            if (value == 8) return KKeys.Backspace;
            if (value == 9) return KKeys.Enter;
            if (value == 10) return KKeys.Space;
            if (value == 11) return KKeys.ArrowUp;
            if (value == 12) return KKeys.ArrowDown;
            if (value == 13) return KKeys.ArrowLeft;
            if (value == 14) return KKeys.ArrowRight;
            if (value == 15) return KKeys.A;
            if (value == 16) return KKeys.B;
            if (value == 17) return KKeys.C;
            if (value == 18) return KKeys.D;
            if (value == 19) return KKeys.E;
            if (value == 20) return KKeys.F;
            if (value == 21) return KKeys.G;
            if (value == 22) return KKeys.H;
            if (value == 23) return KKeys.I;
            if (value == 24) return KKeys.J;
            if (value == 25) return KKeys.K;
            if (value == 26) return KKeys.L;
            if (value == 27) return KKeys.M;
            if (value == 28) return KKeys.N;
            if (value == 29) return KKeys.O;
            if (value == 30) return KKeys.P;
            if (value == 31) return KKeys.Q;
            if (value == 32) return KKeys.R;
            if (value == 33) return KKeys.S;
            if (value == 34) return KKeys.T;
            if (value == 35) return KKeys.U;
            if (value == 36) return KKeys.V;
            if (value == 37) return KKeys.W;
            if (value == 38) return KKeys.X;
            if (value == 39) return KKeys.Y;
            if (value == 40) return KKeys.Z;
            if (value == 41) return KKeys.One;
            if (value == 42) return KKeys.Two;
            if (value == 43) return KKeys.Three;
            if (value == 44) return KKeys.Four;
            if (value == 45) return KKeys.Five;
            if (value == 46) return KKeys.Six;
            if (value == 47) return KKeys.Seven;
            if (value == 48) return KKeys.Eight;
            if (value == 49) return KKeys.Nine;
            if (value == 50) return KKeys.Zero;
            if (value == 51) return KKeys.KeyPadOne;
            if (value == 52) return KKeys.KeyPadTwo;
            if (value == 53) return KKeys.KeyPadThree;
            if (value == 54) return KKeys.KeyPadFour;
            if (value == 55) return KKeys.KeyPadFive;
            if (value == 56) return KKeys.KeyPadSix;
            if (value == 57) return KKeys.KeyPadSeven;
            if (value == 58) return KKeys.KeyPadEight;
            if (value == 59) return KKeys.KeyPadNine;
            if (value == 60) return KKeys.KeyPadZero;

            return KKeys.None;
        }
    }
}

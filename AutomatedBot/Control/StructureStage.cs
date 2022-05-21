using AutomatedBot.Engine.Model;
using KlusterG.AutoGui;

namespace AutomatedBot.Control
{
    internal class StructureStage
    {
        private string Name;
        private string Comment;
        private string Function;
        private int X;
        private int Y;
        private bool MoveMouse;

        public StructureStage(string name, string comment, int x, int y, bool moveMouse)
        {
            Name = name;
            Comment = comment;
            X = x;
            Y = y;
            MoveMouse = moveMouse;
        }

        public void SimpleClick(bool simpleClick, double wait)
        {

        }

        public void RightClick(double wait)
        {

        }

        public void DoubleClick(double wait)
        {

        }

        public void Write(bool simpleClick, string text, double wait)
        {

        }

        public void ClickKey(bool simpleClick, int keyOne, int keyTwo, int keyThree, double wait)
        {

        }

        public void PressKey(bool simpleClick, int keyOne, int keyTwo, int keyThree, double wait)
        {

        }

        public void ReleaseKey(bool simpleClick, int keyOne, int keyTwo, int keyThree, double wait)
        {

        }

        public void WaitColor(PixelColor color, double wait)
        {

        }

        public void WaitColorCondition(List<WaitColorsCondition> conditions, double wait)
        {

        }

        public void Condition(List<Condition> conditions, string nextStage, double wait)
        {

        }

        public void CommandLine(string text, double wait)
        {

        }
    }
}

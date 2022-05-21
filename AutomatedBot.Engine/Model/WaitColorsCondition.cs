using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedBot.Engine.Model
{
    public class WaitColorsCondition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int A { get; set; }
        public string NextRoutine { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedBot.Engine.Model
{
    public class Condition
    {
        public string Key { get; set; }
        public int Operator { get; set; }
        public string Value { get; set; }
        public int LogicalOperator { get; set; }
    }
}

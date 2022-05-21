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
        public string Operator { get; set; }
        public string Value { get; set; }
        public string LogicalOperator { get; set; }
    }
}

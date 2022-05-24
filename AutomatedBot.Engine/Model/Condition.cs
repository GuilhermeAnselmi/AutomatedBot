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

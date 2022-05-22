using KlusterG.AutoGui;

namespace AutomatedBot.Engine.Model
{
    public class Routine
    {
        public string Name { get; set; }
        public string FileName { get; set; }
        public List<Stage> Stage { get; set; }
    }

    public class Stage
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Function { get; set; }
        public ModelProcedure Procedure { get; set; }
        public PixelColor PColor { get; set; }
        public List<WaitColorsCondition> ColorsCondition { get; set; }
        public List<Condition> Conditions { get; set; }
        public TimeoutRoutine Timeout { get; set; }
        public string NextStageTrue { get; set; }
        public string NextStageFalse { get; set; }
        public string CommandLine { get; set; }
    }
}

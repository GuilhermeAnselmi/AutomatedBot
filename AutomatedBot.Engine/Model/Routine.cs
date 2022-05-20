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
        public ModelProcedure Procedure { get; set; }
    }
}

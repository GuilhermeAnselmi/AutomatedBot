using KlusterG.AutoGui;

namespace AutomatedBot.Model
{
    internal class Routine
    {
        public string Name { get; set; }
        public string FileName { get; set; }
        public List<Stage> Stage { get; set; }
    }

    internal class Stage
    {
        public ModelProcedure Procedure { get; set; }
    }
}

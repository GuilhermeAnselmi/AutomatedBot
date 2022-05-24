namespace AutomatedBot.Engine.Model
{
    public class TimeoutRoutine
    {
        public int Timeout { get; set; }
        public string RoutineTimeout { get; set; }

        public TimeoutRoutine()
        {
            Timeout = 30;
            RoutineTimeout = null;
        }
    }
}

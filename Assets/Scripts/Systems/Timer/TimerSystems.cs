namespace Systems.Timer
{
    internal class TimerSystems : Feature
    {
        public TimerSystems(Contexts contexts)
        {
            Add(new InitTimerSystem(contexts));
            Add(new UpdateTimerSystem(contexts));
        }
    }
}

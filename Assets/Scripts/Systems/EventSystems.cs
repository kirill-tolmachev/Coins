namespace Systems
{
    internal class EventSystems : Feature
    {
        public EventSystems(Contexts contexts) : base("Event Systems")
        {
            Add(new GameEventSystems(contexts));
            Add(new GameStateEventSystems(contexts));
        }
    }
}

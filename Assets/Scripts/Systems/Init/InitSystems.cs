namespace Systems
{
    public class InitSystems : Feature
    {
        public InitSystems(Contexts contexts) : base("Init Systems")
        {
            Add(new InitPlayerSystem(contexts));
            Add(new InitArenaSystem(contexts));
            Add(new InitCoinsSystem(contexts));
        }
    }
}

namespace Extensions
{
    internal static class ContextExtensions
    {
        public static GameStateEntity Respawn(this GameStateContext context)
        {
            var respawn = context.CreateEntity();
            respawn.isRespawn = true;
            
            return respawn;
        }
    }
}

using Config;
using Entitas;

namespace Systems.Timer
{
    internal class InitTimerSystem : RespawnSystem
    {
        private readonly IConfig _config;
        private readonly GameStateContext _context;

        public InitTimerSystem(Contexts contexts) : base(contexts)
        {
            _config = contexts.game.config.Config;
            _context = contexts.gameState;
        }

        protected override void OnRespawn()
        {
            _context.ReplaceTimer(_config.TotalTime);
        }
    }
}

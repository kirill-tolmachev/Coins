using Entitas;
using Extensions;

namespace Systems
{
    internal class AllCoinsCollectedSystem : ISystem, IAnyCapturableListener
    {
        private readonly GameStateContext _context;

        public AllCoinsCollectedSystem(Contexts contexts)
        {
            _context = contexts.gameState;

            var listener = contexts.game.CreateEntity();
            listener.AddAnyCapturableListener(this);
        }

        public void OnAnyCapturable(GameEntity entity, bool isCaptured)
        {
            if (!isCaptured)
                return;
            
            _context.ReplaceCoinsLeft(_context.coinsLeft.Value - 1);
            
            if (_context.coinsLeft.Value == 0)
                _context.Respawn();
        }
    }
}

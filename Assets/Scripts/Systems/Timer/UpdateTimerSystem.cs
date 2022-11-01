using Entitas;
using Extensions;
using UnityEngine;

namespace Systems.Timer
{
    internal class UpdateTimerSystem : IExecuteSystem
    {
        private readonly GameStateContext _context;

        public UpdateTimerSystem(Contexts contexts) => _context = contexts.gameState;

        public void Execute()
        {
            var timeLeft = _context.timer.TimeLeft - Time.deltaTime;
            _context.ReplaceTimer(Mathf.Max(0f, timeLeft));

            if (timeLeft <= 0f)
                _context.Respawn();
        }
    }
}

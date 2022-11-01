using System.Collections.Generic;
using Entitas;

namespace Systems
{
    internal class ScoreSystem : RespawnSystem, IAnyCapturableListener
    {
        private readonly GameStateContext _state;

        public ScoreSystem(Contexts contexts) : base(contexts)
        {
            _state = contexts.gameState;
            
            var listener = contexts.game.CreateEntity();
            listener.AddAnyCapturableListener(this);
        }

        protected override void OnRespawn()
        {
            _state.ReplaceScore(0);

            if (!_state.hasHighScore)
                _state.SetHighScore(0);
        }
        
        public void OnAnyCapturable(GameEntity entity, bool isCaptured)
        {
            if (!isCaptured)
                return;

            _state.ReplaceScore(_state.score.Value + 1);

            if (_state.score.Value > _state.highScore.Value)
                _state.ReplaceHighScore(_state.score.Value);
        }
    }
}

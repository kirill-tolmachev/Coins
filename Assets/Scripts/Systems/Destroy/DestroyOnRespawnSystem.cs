using System.Collections.Generic;
using Entitas;

namespace Systems.Destroy
{
    internal class DestroyOnRespawnSystem : ReactiveSystem<GameStateEntity>
    {
        private readonly IGroup<GameEntity> _group;
        private readonly List<GameEntity> _buffer = new List<GameEntity>();
        private readonly GameStateContext _state;

        protected override ICollector<GameStateEntity> GetTrigger(IContext<GameStateEntity> context) =>
            context.CreateCollector(GameStateMatcher.Respawn.Added());

        protected override bool Filter(GameStateEntity entity) => entity.isRespawn;

        protected override void Execute(List<GameStateEntity> entities)
        {
            foreach (var entity in _group.GetEntities(_buffer))
            {
                if (entity.destroyOnRespawn.Round < _state.currentRound.Value)
                    entity.isDestroyed = true;
            }
        }

        public DestroyOnRespawnSystem(Contexts contexts) : base(contexts.gameState)
        {
            _state = contexts.gameState;
            _group = contexts.game.GetGroup(GameMatcher.DestroyOnRespawn);
        }
    }
}

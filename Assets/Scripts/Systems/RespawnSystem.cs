using System.Collections.Generic;
using Entitas;

namespace Systems
{
    public abstract class RespawnSystem : ReactiveSystem<GameStateEntity>, IInitializeSystem
    {
        protected readonly GameContext GameContext;

        protected RespawnSystem(Contexts contexts) : base(contexts.gameState) => GameContext = contexts.game;

        protected abstract void OnRespawn();

        public virtual void Initialize() => OnRespawn();

        protected override ICollector<GameStateEntity> GetTrigger(IContext<GameStateEntity> context) =>
            context.CreateCollector(GameStateMatcher.Respawn.Added());

        protected override bool Filter(GameStateEntity entity) => entity.isRespawn;

        protected override void Execute(List<GameStateEntity> entities) => OnRespawn();
    }
}

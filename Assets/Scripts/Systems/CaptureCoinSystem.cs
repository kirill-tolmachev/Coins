using System.Collections.Generic;
using Entitas;

namespace Systems
{
    internal class CaptureCoinSystem : ReactiveSystem<InputEntity>
    {
        public CaptureCoinSystem(Contexts contexts) : base(contexts.input)
        {
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context) => 
            context.CreateCollector(InputMatcher.Collision);

        protected override bool Filter(InputEntity entity) => entity.hasCollision;

        protected override void Execute(List<InputEntity> entities)
        {
            foreach (var collision in entities)
            {
                var coin = (GameEntity)collision.collision.Coin;
                coin.ReplaceCapturable(true);
                coin.isDestroyed = true;
            }
        }
    }
}

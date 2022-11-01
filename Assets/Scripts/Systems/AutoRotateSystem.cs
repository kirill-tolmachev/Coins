using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Systems
{
    internal class AutoRotateSystem : ReactiveSystem<GameEntity>
    {
        private GameContext _context;

        public AutoRotateSystem(Contexts contexts) : base(contexts.game)
        {
            _context = contexts.game;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) => 
            context.CreateCollector(GameMatcher.Rotation);

        protected override bool Filter(GameEntity entity) => !entity.isDestroyed && entity.isAutoRotate;

        protected override void Execute(List<GameEntity> entities)
        {
            float rotationSpeed = _context.config.Config.CoinRotationSpeed;

            foreach (var gameEntity in entities)
            {
                float speed = rotationSpeed * Time.deltaTime;
                var old = gameEntity.rotation.Value.eulerAngles;
                gameEntity.ReplaceRotation(Quaternion.Euler(old.x, old.y + speed, old.z));
            }
        }

    }
}

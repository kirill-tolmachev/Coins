using Config;
using Entitas;
using Extensions;
using UnityEngine;

namespace Systems
{
    internal class MovementSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;

        public MovementSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Execute()
        {
            var input = _contexts.input.movement.Value;
            if (input == Vector2.zero)
                return;
            
            var player = _contexts.game.playerEntity;
            var config = _contexts.game.config.Config;
            var speed = config.PlayerSpeed * Time.deltaTime;

            var newPosition = player.position.Value + input * speed;
            newPosition = newPosition.ClampToRect(config.GetArenaBounds());

            player.ReplacePosition(newPosition);
        }

        
    }
}

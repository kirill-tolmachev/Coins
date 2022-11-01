using Entitas;

namespace Systems
{
    public class LogPositionSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;

        public LogPositionSystem(Contexts contexts)
        {
            _entities = contexts.game.GetGroup(GameMatcher.Position);
        }

        public void Execute()
        {
            foreach (var entity in _entities)
            {
                var position = entity.position.Value;
                UnityEngine.Debug.Log("position: " + position);
            }
        }
    }
}

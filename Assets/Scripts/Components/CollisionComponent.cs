using Entitas;

namespace Components
{
    [Input]
    public class CollisionComponent : IComponent
    {
        public IEntity Player;

        public IEntity Coin;
    }
}

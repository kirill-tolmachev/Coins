using UnityEngine;

namespace Systems
{
    public class InitPlayerSystem : RespawnSystem
    {
        public InitPlayerSystem(Contexts contexts) : base(contexts)
        {

        }

        protected override void OnRespawn()
        {
            var playerComponent = new global::Components.PlayerComponent();
            GameContext.ReplacePlayer(playerComponent);
            GameContext.playerEntity.ReplaceAsset("Player");
            GameContext.playerEntity.ReplacePosition(new Vector2(0, 0));
        }
    }
}
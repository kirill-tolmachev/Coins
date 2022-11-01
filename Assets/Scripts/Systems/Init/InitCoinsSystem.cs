using Config;
using Entitas;
using UnityEngine;

namespace Systems
{
    internal class InitCoinsSystem : RespawnSystem
    {
        private GameStateContext _state;
        public InitCoinsSystem(Contexts contexts) : base(contexts)
        {
            _state = contexts.gameState;
        }

        protected override void OnRespawn()
        {
            var config = GameContext.config.Config;
            Vector2 start = new Vector2(-config.ArenaSizeX / 2f + 0.5f, -config.ArenaSizeY / 2f + 0.5f);
            
            _state.ReplaceCoinsLeft(0);
            for (int x = 0; x < config.ArenaSizeX; x++)
            {
                for (int y = 0; y < config.ArenaSizeY; y++)
                {
                    if (Random.value < config.CoinsDensity)
                    {
                        CreateCoin(start.x + x, start.y + y);
                        _state.ReplaceCoinsLeft(_state.coinsLeft.Value + 1);
                    }
                }
            }
        }

        private void CreateCoin(float x, float y)
        {
            var e = GameContext.CreateEntity();
            e.AddAsset("Coin");
            e.AddPosition(new Vector2(x, y));
            e.AddRotation(Quaternion.identity);
            e.AddCapturable(false);
            e.AddDestroyOnRespawn(_state.currentRound.Value);
            e.isAutoRotate = true;
        }
    }
}
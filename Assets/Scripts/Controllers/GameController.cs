using Config;
using Systems;
using UnityEngine;

namespace Controllers
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] 
        private GameConfig _config;

        private Entitas.Systems _systems;

        void Awake()
        {
            var contexts = Contexts.sharedInstance = new Contexts();
            contexts.game.SetConfig(_config);

            _systems = new GameSystems(contexts);
            _systems.Initialize();
        }

        void Update()
        {
            _systems.Execute();
        }
    }
}
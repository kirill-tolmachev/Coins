using Systems.Destroy;
using Systems.Input;
using Systems.Timer;
using Views;

namespace Systems
{
    internal class GameSystems : Feature
    {
        public GameSystems(Contexts contexts) : base("Game Systems")
        {
            Add(new ChangeRoundSystem(contexts));
            Add(new DestroyOnRespawnSystem(contexts));
            Add(new InitSystems(contexts));
            Add(new EventSystems(contexts));

            Add(new ScoreSystem(contexts));
            Add(new AddViewSystem(contexts));
            Add(new InputSystem(contexts));
            
            Add(new TimerSystems(contexts));
            Add(new AutoRotateSystem(contexts));
            
            Add(new MovementSystem(contexts));
            Add(new CaptureCoinSystem(contexts));
            Add(new AllCoinsCollectedSystem(contexts));

            Add(new DestroyDestroyedSystem(contexts));
        }
    }
}

namespace Systems
{
    internal class ChangeRoundSystem : RespawnSystem
    {
        private readonly GameStateContext _state;

        public ChangeRoundSystem(Contexts contexts) : base(contexts)
        {
            _state = contexts.gameState;
        }

        public override void Initialize()
        {
            _state.SetCurrentRound(1);
        }

        protected override void OnRespawn()
        {
            _state.ReplaceCurrentRound(_state.currentRound.Value + 1);
        }
    }
}

namespace Controllers
{
    internal class RoundLabelController : LabelController<int>, IAnyCurrentRoundListener
    {
        protected override void Start()
        {
            base.Start();
            CreateListener().AddAnyCurrentRoundListener(this);
        }

        protected override string FormatText(int value) => $"Round: {value}";
        
        public void OnAnyCurrentRound(GameStateEntity entity, int value) => SetText(value);
    }
}
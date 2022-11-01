namespace Controllers
{
    internal class ScoreLabelController : LabelController<int>, IAnyScoreListener
    {
        protected override void Start()
        {
            base.Start();
            CreateListener().AddAnyScoreListener(this);
        }

        protected override string FormatText(int value) => $"Score: {value}";

        public void OnAnyScore(GameStateEntity entity, int value) => SetText(value);

    }
}
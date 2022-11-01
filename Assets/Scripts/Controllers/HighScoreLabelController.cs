namespace Controllers
{
    internal class HighScoreLabelController : LabelController<int>, IAnyHighScoreListener
    {
        protected override void Start()
        {
            base.Start();
            CreateListener().AddAnyHighScoreListener(this);
        }
        protected override string FormatText(int value) => $"High Score: {value}";
        
        public void OnAnyHighScore(GameStateEntity entity, int value) => SetText(value);

    }
}
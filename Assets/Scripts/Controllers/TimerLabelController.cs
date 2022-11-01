using System;

namespace Controllers
{
    internal class TimerLabelController : LabelController<float>, IAnyTimerListener
    {
        protected override void Start()
        {
            base.Start();
            CreateListener().AddAnyTimerListener(this);
        }

        protected override string FormatText(float value) => TimeSpan.FromSeconds(value).ToString("ss\\:ff");

        public void OnAnyTimer(GameStateEntity entity, float timeLeft) => SetText(timeLeft);
    }
}
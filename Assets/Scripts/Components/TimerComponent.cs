using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Components
{
    [GameState, Unique, Event(EventTarget.Any)]
    public class TimerComponent : IComponent
    {
        public float TimeLeft;
    }
}

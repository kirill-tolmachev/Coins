using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Components
{
    [GameState, Unique, Event(EventTarget.Any)]
    public class HighScoreComponent : IComponent
    {
        public int Value;
    }
}
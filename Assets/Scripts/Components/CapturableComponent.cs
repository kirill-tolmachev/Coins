using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Components
{
    [Game, Event(EventTarget.Any)]
    public class CapturableComponent : IComponent
    {
        public bool IsCaptured;
    }
}
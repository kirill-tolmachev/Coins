using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Components
{
    [Game, Event(EventTarget.Self)]
    public class DestroyedComponent : IComponent
    {
    }
}

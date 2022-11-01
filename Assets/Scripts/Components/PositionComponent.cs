using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Components
{
    [Game, Event(EventTarget.Self)]
    public sealed class PositionComponent : IComponent
    {
        public Vector2 Value;
    }
}

using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Components
{
    [Game, Event(EventTarget.Self)]
    public class RotationComponent : IComponent
    {
        public Quaternion Value;
    }
}

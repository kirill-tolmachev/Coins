using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Components
{
    [Input, Unique]
    public class MovementComponent : IComponent
    {
        public Vector2 Value;
    }
}

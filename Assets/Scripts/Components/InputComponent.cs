using Controllers;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Components
{
    [Input, Unique]
    public class InputComponent : IComponent
    {
        public IInput Input;
    }
}

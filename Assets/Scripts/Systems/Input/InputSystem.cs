using Entitas;
using UnityEngine;

namespace Systems.Input
{
    internal class InputSystem : IExecuteSystem
    {
        private readonly InputContext _context;

        public InputSystem(Contexts contexts) => _context = contexts.input;

        public void Execute()
        {
            var input = _context.input.Input.GetInput();
            _context.ReplaceMovement(input);
        }
    }
}

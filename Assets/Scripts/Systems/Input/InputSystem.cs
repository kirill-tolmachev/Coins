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
            float x = UnityEngine.Input.GetAxis("Horizontal");
            float y = UnityEngine.Input.GetAxis("Vertical");

            _context.ReplaceMovement(new Vector2(x, y));
        }
    }
}

using Config;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Components
{
    [Game, Unique]
    public class ConfigComponent : IComponent
    {
        public IConfig Config;
    }
}

using System;
using Entitas;
using UnityEngine;

namespace Systems
{
    internal class InitArenaSystem : IInitializeSystem
    {
        private readonly GameContext _context;

        public InitArenaSystem(Contexts contexts) => _context = contexts.game;

        public void Initialize()
        {
            var e = _context.CreateEntity();
            e.AddAsset("Arena");
            e.AddPosition(new Vector3(0, 0));

            var config = _context.config.Config;
            e.AddScale(new Vector3(config.ArenaSizeX, 0.1f, config.ArenaSizeY));
        }
    }
}

using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Views
{
    public sealed class AddViewSystem : ReactiveSystem<GameEntity>
    {
        readonly Transform _parent;

        public AddViewSystem(Contexts contexts) : base(contexts.game)
        {
            _parent = new GameObject("Views").transform;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(GameMatcher.Asset);

        protected override bool Filter(GameEntity entity) => entity.hasAsset && !entity.hasView;

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                var prefab = Resources.Load<GameObject>(e.asset.AssetName);
                var view = Object.Instantiate(prefab, _parent).GetComponent<IView>();
                view.Link(e);

                e.AddView(view);
            }
        }
    }
}
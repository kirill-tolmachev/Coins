using Entitas.Unity;
using UnityEngine;

namespace Controllers
{
    internal class CollisionEmitter : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            var target = other.gameObject;
            var targetEntity = GetPrefabEntityLink(target).entity as GameEntity;
            if (targetEntity?.hasCapturable != true)
                return;

            var link = GetPrefabEntityLink(gameObject);
            var col = Contexts.sharedInstance.input.CreateEntity();
            col.AddCollision(link.entity, targetEntity);
        }

        private EntityLink GetPrefabEntityLink(GameObject go) => go.transform.parent.gameObject.GetEntityLink();
    }
}

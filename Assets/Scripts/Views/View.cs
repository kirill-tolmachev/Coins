using System;
using Entitas;
using Entitas.Unity;
using UnityEngine;

namespace Views
{
    internal class View : MonoBehaviour, IView, IPositionListener, IRotationListener, IDestroyedListener
    {
        private GameEntity _entity;

        public void Link(IEntity entity)
        {
            gameObject.Link(entity);
            _entity = (GameEntity) entity;
            _entity.AddPositionListener(this);
            _entity.AddRotationListener(this);
            _entity.AddDestroyedListener(this);

            transform.localPosition = Translate(_entity.position.Value);

            if (_entity.hasRotation)
                transform.localRotation = _entity.rotation.Value;

            if (_entity.hasScale)
                transform.localScale = _entity.scale.Value;
        }

        public void OnPosition(GameEntity entity, Vector2 value) => 
            transform.localPosition = Translate(value);

        public void OnRotation(GameEntity entity, Quaternion rotation) =>
            transform.localRotation = rotation;

        private static Vector3 Translate(Vector2 value) => 
            new Vector3(value.x, 0f, value.y);

        public void OnDestroyed(GameEntity _)
        {
            GameObject go = gameObject;

            go.Unlink();
            Destroy(go);

            //_entity.Destroy();
        }
    }
}

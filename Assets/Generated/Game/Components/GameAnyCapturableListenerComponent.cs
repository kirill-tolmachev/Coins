//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AnyCapturableListenerComponent anyCapturableListener { get { return (AnyCapturableListenerComponent)GetComponent(GameComponentsLookup.AnyCapturableListener); } }
    public bool hasAnyCapturableListener { get { return HasComponent(GameComponentsLookup.AnyCapturableListener); } }

    public void AddAnyCapturableListener(System.Collections.Generic.List<IAnyCapturableListener> newValue) {
        var index = GameComponentsLookup.AnyCapturableListener;
        var component = (AnyCapturableListenerComponent)CreateComponent(index, typeof(AnyCapturableListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyCapturableListener(System.Collections.Generic.List<IAnyCapturableListener> newValue) {
        var index = GameComponentsLookup.AnyCapturableListener;
        var component = (AnyCapturableListenerComponent)CreateComponent(index, typeof(AnyCapturableListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyCapturableListener() {
        RemoveComponent(GameComponentsLookup.AnyCapturableListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherAnyCapturableListener;

    public static Entitas.IMatcher<GameEntity> AnyCapturableListener {
        get {
            if (_matcherAnyCapturableListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnyCapturableListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnyCapturableListener = matcher;
            }

            return _matcherAnyCapturableListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddAnyCapturableListener(IAnyCapturableListener value) {
        var listeners = hasAnyCapturableListener
            ? anyCapturableListener.value
            : new System.Collections.Generic.List<IAnyCapturableListener>();
        listeners.Add(value);
        ReplaceAnyCapturableListener(listeners);
    }

    public void RemoveAnyCapturableListener(IAnyCapturableListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyCapturableListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyCapturableListener();
        } else {
            ReplaceAnyCapturableListener(listeners);
        }
    }
}
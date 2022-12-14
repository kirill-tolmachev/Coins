//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public AnyTimerListenerComponent anyTimerListener { get { return (AnyTimerListenerComponent)GetComponent(GameStateComponentsLookup.AnyTimerListener); } }
    public bool hasAnyTimerListener { get { return HasComponent(GameStateComponentsLookup.AnyTimerListener); } }

    public void AddAnyTimerListener(System.Collections.Generic.List<IAnyTimerListener> newValue) {
        var index = GameStateComponentsLookup.AnyTimerListener;
        var component = (AnyTimerListenerComponent)CreateComponent(index, typeof(AnyTimerListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyTimerListener(System.Collections.Generic.List<IAnyTimerListener> newValue) {
        var index = GameStateComponentsLookup.AnyTimerListener;
        var component = (AnyTimerListenerComponent)CreateComponent(index, typeof(AnyTimerListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyTimerListener() {
        RemoveComponent(GameStateComponentsLookup.AnyTimerListener);
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
public sealed partial class GameStateMatcher {

    static Entitas.IMatcher<GameStateEntity> _matcherAnyTimerListener;

    public static Entitas.IMatcher<GameStateEntity> AnyTimerListener {
        get {
            if (_matcherAnyTimerListener == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.AnyTimerListener);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherAnyTimerListener = matcher;
            }

            return _matcherAnyTimerListener;
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
public partial class GameStateEntity {

    public void AddAnyTimerListener(IAnyTimerListener value) {
        var listeners = hasAnyTimerListener
            ? anyTimerListener.value
            : new System.Collections.Generic.List<IAnyTimerListener>();
        listeners.Add(value);
        ReplaceAnyTimerListener(listeners);
    }

    public void RemoveAnyTimerListener(IAnyTimerListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyTimerListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyTimerListener();
        } else {
            ReplaceAnyTimerListener(listeners);
        }
    }
}

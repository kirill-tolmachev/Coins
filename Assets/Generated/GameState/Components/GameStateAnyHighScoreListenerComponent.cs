//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public AnyHighScoreListenerComponent anyHighScoreListener { get { return (AnyHighScoreListenerComponent)GetComponent(GameStateComponentsLookup.AnyHighScoreListener); } }
    public bool hasAnyHighScoreListener { get { return HasComponent(GameStateComponentsLookup.AnyHighScoreListener); } }

    public void AddAnyHighScoreListener(System.Collections.Generic.List<IAnyHighScoreListener> newValue) {
        var index = GameStateComponentsLookup.AnyHighScoreListener;
        var component = (AnyHighScoreListenerComponent)CreateComponent(index, typeof(AnyHighScoreListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyHighScoreListener(System.Collections.Generic.List<IAnyHighScoreListener> newValue) {
        var index = GameStateComponentsLookup.AnyHighScoreListener;
        var component = (AnyHighScoreListenerComponent)CreateComponent(index, typeof(AnyHighScoreListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyHighScoreListener() {
        RemoveComponent(GameStateComponentsLookup.AnyHighScoreListener);
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

    static Entitas.IMatcher<GameStateEntity> _matcherAnyHighScoreListener;

    public static Entitas.IMatcher<GameStateEntity> AnyHighScoreListener {
        get {
            if (_matcherAnyHighScoreListener == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.AnyHighScoreListener);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherAnyHighScoreListener = matcher;
            }

            return _matcherAnyHighScoreListener;
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

    public void AddAnyHighScoreListener(IAnyHighScoreListener value) {
        var listeners = hasAnyHighScoreListener
            ? anyHighScoreListener.value
            : new System.Collections.Generic.List<IAnyHighScoreListener>();
        listeners.Add(value);
        ReplaceAnyHighScoreListener(listeners);
    }

    public void RemoveAnyHighScoreListener(IAnyHighScoreListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyHighScoreListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyHighScoreListener();
        } else {
            ReplaceAnyHighScoreListener(listeners);
        }
    }
}
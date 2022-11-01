//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.CapturableComponent capturable { get { return (Components.CapturableComponent)GetComponent(GameComponentsLookup.Capturable); } }
    public bool hasCapturable { get { return HasComponent(GameComponentsLookup.Capturable); } }

    public void AddCapturable(bool newIsCaptured) {
        var index = GameComponentsLookup.Capturable;
        var component = (Components.CapturableComponent)CreateComponent(index, typeof(Components.CapturableComponent));
        component.IsCaptured = newIsCaptured;
        AddComponent(index, component);
    }

    public void ReplaceCapturable(bool newIsCaptured) {
        var index = GameComponentsLookup.Capturable;
        var component = (Components.CapturableComponent)CreateComponent(index, typeof(Components.CapturableComponent));
        component.IsCaptured = newIsCaptured;
        ReplaceComponent(index, component);
    }

    public void RemoveCapturable() {
        RemoveComponent(GameComponentsLookup.Capturable);
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

    static Entitas.IMatcher<GameEntity> _matcherCapturable;

    public static Entitas.IMatcher<GameEntity> Capturable {
        get {
            if (_matcherCapturable == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Capturable);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCapturable = matcher;
            }

            return _matcherCapturable;
        }
    }
}
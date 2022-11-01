//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateContext {

    public GameStateEntity currentRoundEntity { get { return GetGroup(GameStateMatcher.CurrentRound).GetSingleEntity(); } }
    public Components.CurrentRoundComponent currentRound { get { return currentRoundEntity.currentRound; } }
    public bool hasCurrentRound { get { return currentRoundEntity != null; } }

    public GameStateEntity SetCurrentRound(int newValue) {
        if (hasCurrentRound) {
            throw new Entitas.EntitasException("Could not set CurrentRound!\n" + this + " already has an entity with Components.CurrentRoundComponent!",
                "You should check if the context already has a currentRoundEntity before setting it or use context.ReplaceCurrentRound().");
        }
        var entity = CreateEntity();
        entity.AddCurrentRound(newValue);
        return entity;
    }

    public void ReplaceCurrentRound(int newValue) {
        var entity = currentRoundEntity;
        if (entity == null) {
            entity = SetCurrentRound(newValue);
        } else {
            entity.ReplaceCurrentRound(newValue);
        }
    }

    public void RemoveCurrentRound() {
        currentRoundEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public Components.CurrentRoundComponent currentRound { get { return (Components.CurrentRoundComponent)GetComponent(GameStateComponentsLookup.CurrentRound); } }
    public bool hasCurrentRound { get { return HasComponent(GameStateComponentsLookup.CurrentRound); } }

    public void AddCurrentRound(int newValue) {
        var index = GameStateComponentsLookup.CurrentRound;
        var component = (Components.CurrentRoundComponent)CreateComponent(index, typeof(Components.CurrentRoundComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCurrentRound(int newValue) {
        var index = GameStateComponentsLookup.CurrentRound;
        var component = (Components.CurrentRoundComponent)CreateComponent(index, typeof(Components.CurrentRoundComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCurrentRound() {
        RemoveComponent(GameStateComponentsLookup.CurrentRound);
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

    static Entitas.IMatcher<GameStateEntity> _matcherCurrentRound;

    public static Entitas.IMatcher<GameStateEntity> CurrentRound {
        get {
            if (_matcherCurrentRound == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.CurrentRound);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherCurrentRound = matcher;
            }

            return _matcherCurrentRound;
        }
    }
}

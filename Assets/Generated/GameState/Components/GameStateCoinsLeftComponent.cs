//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Components;

public partial class GameStateContext {

    public GameStateEntity coinsLeftEntity { get { return GetGroup(GameStateMatcher.CoinsLeft).GetSingleEntity(); } }
    public CoinsLeftComponent coinsLeft { get { return coinsLeftEntity.coinsLeft; } }
    public bool hasCoinsLeft { get { return coinsLeftEntity != null; } }

    public GameStateEntity SetCoinsLeft(int newValue) {
        if (hasCoinsLeft) {
            throw new Entitas.EntitasException("Could not set CoinsLeft!\n" + this + " already has an entity with Assets.Scripts.Components.CoinsLeftComponent!",
                "You should check if the context already has a coinsLeftEntity before setting it or use context.ReplaceCoinsLeft().");
        }
        var entity = CreateEntity();
        entity.AddCoinsLeft(newValue);
        return entity;
    }

    public void ReplaceCoinsLeft(int newValue) {
        var entity = coinsLeftEntity;
        if (entity == null) {
            entity = SetCoinsLeft(newValue);
        } else {
            entity.ReplaceCoinsLeft(newValue);
        }
    }

    public void RemoveCoinsLeft() {
        coinsLeftEntity.Destroy();
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

    public CoinsLeftComponent coinsLeft { get { return (CoinsLeftComponent)GetComponent(GameStateComponentsLookup.CoinsLeft); } }
    public bool hasCoinsLeft { get { return HasComponent(GameStateComponentsLookup.CoinsLeft); } }

    public void AddCoinsLeft(int newValue) {
        var index = GameStateComponentsLookup.CoinsLeft;
        var component = (CoinsLeftComponent)CreateComponent(index, typeof(CoinsLeftComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCoinsLeft(int newValue) {
        var index = GameStateComponentsLookup.CoinsLeft;
        var component = (CoinsLeftComponent)CreateComponent(index, typeof(CoinsLeftComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCoinsLeft() {
        RemoveComponent(GameStateComponentsLookup.CoinsLeft);
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

    static Entitas.IMatcher<GameStateEntity> _matcherCoinsLeft;

    public static Entitas.IMatcher<GameStateEntity> CoinsLeft {
        get {
            if (_matcherCoinsLeft == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.CoinsLeft);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherCoinsLeft = matcher;
            }

            return _matcherCoinsLeft;
        }
    }
}
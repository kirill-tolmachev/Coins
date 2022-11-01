//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateContext {

    public GameStateEntity timerEntity { get { return GetGroup(GameStateMatcher.Timer).GetSingleEntity(); } }
    public Components.TimerComponent timer { get { return timerEntity.timer; } }
    public bool hasTimer { get { return timerEntity != null; } }

    public GameStateEntity SetTimer(float newTimeLeft) {
        if (hasTimer) {
            throw new Entitas.EntitasException("Could not set Timer!\n" + this + " already has an entity with Components.TimerComponent!",
                "You should check if the context already has a timerEntity before setting it or use context.ReplaceTimer().");
        }
        var entity = CreateEntity();
        entity.AddTimer(newTimeLeft);
        return entity;
    }

    public void ReplaceTimer(float newTimeLeft) {
        var entity = timerEntity;
        if (entity == null) {
            entity = SetTimer(newTimeLeft);
        } else {
            entity.ReplaceTimer(newTimeLeft);
        }
    }

    public void RemoveTimer() {
        timerEntity.Destroy();
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

    public Components.TimerComponent timer { get { return (Components.TimerComponent)GetComponent(GameStateComponentsLookup.Timer); } }
    public bool hasTimer { get { return HasComponent(GameStateComponentsLookup.Timer); } }

    public void AddTimer(float newTimeLeft) {
        var index = GameStateComponentsLookup.Timer;
        var component = (Components.TimerComponent)CreateComponent(index, typeof(Components.TimerComponent));
        component.TimeLeft = newTimeLeft;
        AddComponent(index, component);
    }

    public void ReplaceTimer(float newTimeLeft) {
        var index = GameStateComponentsLookup.Timer;
        var component = (Components.TimerComponent)CreateComponent(index, typeof(Components.TimerComponent));
        component.TimeLeft = newTimeLeft;
        ReplaceComponent(index, component);
    }

    public void RemoveTimer() {
        RemoveComponent(GameStateComponentsLookup.Timer);
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

    static Entitas.IMatcher<GameStateEntity> _matcherTimer;

    public static Entitas.IMatcher<GameStateEntity> Timer {
        get {
            if (_matcherTimer == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.Timer);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherTimer = matcher;
            }

            return _matcherTimer;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GameStateEventSystems : Feature {

    public GameStateEventSystems(Contexts contexts) {
        Add(new AnyCoinsLeftEventSystem(contexts)); // priority: 0
        Add(new AnyCurrentRoundEventSystem(contexts)); // priority: 0
        Add(new AnyHighScoreEventSystem(contexts)); // priority: 0
        Add(new AnyScoreEventSystem(contexts)); // priority: 0
        Add(new AnyTimerEventSystem(contexts)); // priority: 0
    }
}

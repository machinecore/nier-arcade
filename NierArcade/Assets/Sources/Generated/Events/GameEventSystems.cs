//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GameEventSystems : Feature {

    public GameEventSystems(Contexts contexts) {
        Add(new PositionEventSystem(contexts)); // priority: 0
        Add(new HealthEventSystem(contexts)); // priority: 1
        Add(new PoolEventSystem(contexts)); // priority: 1
        Add(new RotationEventSystem(contexts)); // priority: 1
        Add(new ScaleEventSystem(contexts)); // priority: 1
        Add(new VelocityEventSystem(contexts)); // priority: 1
        Add(new WaveEventSystem(contexts)); // priority: 1
    }
}

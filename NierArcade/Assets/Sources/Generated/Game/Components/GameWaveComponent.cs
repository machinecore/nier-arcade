//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public WaveComponent wave { get { return (WaveComponent)GetComponent(GameComponentsLookup.Wave); } }
    public bool hasWave { get { return HasComponent(GameComponentsLookup.Wave); } }

    public void AddWave(float newRadius, float newSpeed) {
        var index = GameComponentsLookup.Wave;
        var component = CreateComponent<WaveComponent>(index);
        component.Radius = newRadius;
        component.Speed = newSpeed;
        AddComponent(index, component);
    }

    public void ReplaceWave(float newRadius, float newSpeed) {
        var index = GameComponentsLookup.Wave;
        var component = CreateComponent<WaveComponent>(index);
        component.Radius = newRadius;
        component.Speed = newSpeed;
        ReplaceComponent(index, component);
    }

    public void RemoveWave() {
        RemoveComponent(GameComponentsLookup.Wave);
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

    static Entitas.IMatcher<GameEntity> _matcherWave;

    public static Entitas.IMatcher<GameEntity> Wave {
        get {
            if (_matcherWave == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Wave);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherWave = matcher;
            }

            return _matcherWave;
        }
    }
}

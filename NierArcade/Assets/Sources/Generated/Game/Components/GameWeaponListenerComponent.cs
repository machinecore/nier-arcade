//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public WeaponListenerComponent weaponListener { get { return (WeaponListenerComponent)GetComponent(GameComponentsLookup.WeaponListener); } }
    public bool hasWeaponListener { get { return HasComponent(GameComponentsLookup.WeaponListener); } }

    public void AddWeaponListener(System.Collections.Generic.List<IWeaponListener> newValue) {
        var index = GameComponentsLookup.WeaponListener;
        var component = CreateComponent<WeaponListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceWeaponListener(System.Collections.Generic.List<IWeaponListener> newValue) {
        var index = GameComponentsLookup.WeaponListener;
        var component = CreateComponent<WeaponListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveWeaponListener() {
        RemoveComponent(GameComponentsLookup.WeaponListener);
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

    static Entitas.IMatcher<GameEntity> _matcherWeaponListener;

    public static Entitas.IMatcher<GameEntity> WeaponListener {
        get {
            if (_matcherWeaponListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.WeaponListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherWeaponListener = matcher;
            }

            return _matcherWeaponListener;
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

    public void AddWeaponListener(IWeaponListener value) {
        var listeners = hasWeaponListener
            ? weaponListener.value
            : new System.Collections.Generic.List<IWeaponListener>();
        listeners.Add(value);
        ReplaceWeaponListener(listeners);
    }

    public void RemoveWeaponListener(IWeaponListener value, bool removeComponentWhenEmpty = true) {
        var listeners = weaponListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveWeaponListener();
        } else {
            ReplaceWeaponListener(listeners);
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.CodeGeneratorMonoComponent.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using UnityEngine;
using Entitas;

public class GameShieldComponentMonoBehaviour : BaseComponentMonoBehaviour
{
                
    public string Name;
	public AssetSource Source;
    
    public override int Index
    {
        get
        {
            return 17;
        }
    }

    public override IComponent Component
    {
        get 
        { 
            return new ShieldComponent
            {
                Name = Name,
				Source = Source
            }; 
        }
    }
}
            
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

public class GameVelocityComponentMonoBehaviour : BaseComponentMonoBehaviour
{
                
    public UnityEngine.Vector3 Value;
    
    public override int Index
    {
        get
        {
            return 16;
        }
    }

    public override IComponent Component
    {
        get 
        { 
            return new VelocityComponent
            {
                Value = Value
            }; 
        }
    }
}
            
﻿using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game, Event(EventTarget.Self, priority: 1)]
public sealed class WaveComponent : IComponent
{
    public float Value;
    public float Radius;
    public float Speed;
}

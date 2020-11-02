using System;
using UnityEngine;


namespace Assets.MyScripts
{
    public sealed class CaughtPlayerEventArgs : EventArgs
    {
        public Color Color { get; }
        // Можем дописать сколько угодно свойств
        public CaughtPlayerEventArgs(Color Color)
        {
            this.Color = Color;
        }   
    }
}

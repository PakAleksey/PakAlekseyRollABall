using System;
using UnityEngine;


namespace Assets.MyScripts
{
    public sealed class CheckBonus : GoodBonus
    {
        public event Action CheckPoint = delegate () { };
        protected override void Interaction()
        {
            CheckPoint.Invoke();
        }
    }
}

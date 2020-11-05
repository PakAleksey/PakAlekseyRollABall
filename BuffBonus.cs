using System;
using UnityEngine;


namespace Assets.MyScripts
{
    public class BuffBonus : GoodBonus
    {
        public event Action<bool> BuffSpeed = (bool b) => { };       

        protected override void Interaction()
        {
            bool IsGood = true;
            BuffSpeed.Invoke(IsGood);           
        }
       
    }
}

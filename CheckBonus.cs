using UnityEngine;


namespace Assets.MyScripts
{
    public sealed class CheckBonus : GoodBonus
    {
        protected override void Interaction(Player Player)
        {
            _displayBonuses.Display(0, 1);           
        }

        public new void Flicker()
        {
            //_material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
            //    Mathf.PingPong(Time.time, 1.0f));
            _material.color = new Color(2, 34, 12);
        }
    }
}

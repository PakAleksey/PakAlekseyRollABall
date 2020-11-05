using System;


namespace Assets.MyScripts
{
    public sealed class DebuffBonus : BadBonus
    {
        public event Action<bool> DeBuffSpeed = (bool b) => { };

        protected override void Interaction()
        {
            bool IsGood = false;
            DeBuffSpeed.Invoke(IsGood);
        }
    }
}

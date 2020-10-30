using UnityEngine;


namespace Assets.MyScripts
{
    public sealed class DebuffBonus : BadBonus
    {        
        private float _lowSpeed = 0.5f;
        private float _BaseSpeed = 3.0f;
        private float _endTimer = 10.0f;
        private Timer _timer = new Timer();
        private Player _player = new Player();

        protected override void Interaction(Player player)
        {
            _player = player;
            _timer = player.gameObject.GetComponent<Timer>();
            _timer.IsStart = true;
            player.Speed = _lowSpeed;
            _timer.StopTimer += EndDeBuff;
        }

        public void EndDeBuff()
        {
            _player.Speed = _BaseSpeed;
            _timer.IsStart = false;
            _timer.TimeStart = 0;
            _timer.StopTimer -= EndDeBuff;
        }
    }
}

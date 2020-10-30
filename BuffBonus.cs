using System;
using UnityEngine;


namespace Assets.MyScripts
{
    public class BuffBonus : GoodBonus
    {
        private float _endTimer = 10;
        private Timer _timer = new Timer();
        private Player _player = new Player();

        //private void Update()
        //{           
        //    if(_timer.TimeStart > _endTimer)
        //    {
        //        Debug.Log($"Timer = {_timer.TimeStart}");
        //        _player.Speed = 3.0f;
        //        _timer.IsStart = false;
        //        _timer.TimeStart = 0;
        //        Debug.Log($"Timer = {_timer.TimeStart}");
        //    }          
        //}

        protected override void Interaction(Player player)
        {
            _player = player;            
            _timer = player.gameObject.GetComponent<Timer>();
            _timer.IsStart = true;
            player.Speed = 10.0f;
            _timer.StopTimer += EndBuff;
            Debug.Log($"Speed = {player.Speed}");
        }

        public void EndBuff()
        {
            Debug.Log($"Timer = {_timer.TimeStart}");
            _player.Speed = 3.0f;
            _timer.IsStart = false;
            _timer.TimeStart = 0;
            _timer.StopTimer -= EndBuff;
            Debug.Log($"Timer = {_timer.TimeStart}");
        }
       
    }
}

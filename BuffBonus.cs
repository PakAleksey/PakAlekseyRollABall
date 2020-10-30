﻿using System;
using UnityEngine;


namespace Assets.MyScripts
{
    public class BuffBonus : GoodBonus
    {
        private float _highSpeed = 10.0f;       
        private float _BaseSpeed = 3.0f;
        private float _endTimer = 10;
        private Timer _timer = new Timer();
        private Player _player = new Player();

        protected override void Interaction(Player player)
        {
            _player = player;            
            _timer = player.gameObject.GetComponent<Timer>();
            _timer.IsStart = true;
            player.Speed = _highSpeed;
            _timer.StopTimer += EndBuff;
        }

        public void EndBuff()
        {
            _player.Speed = _BaseSpeed;
            _timer.IsStart = false;
            _timer.TimeStart = 0;
            _timer.StopTimer -= EndBuff;
        }
       
    }
}
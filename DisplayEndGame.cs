﻿using System;
using UnityEngine.UI;


namespace Assets.MyScripts
{
    public sealed class DisplayEndGame
    {
        private Text _finishGameLabel;

        public DisplayEndGame(Text finishGameLabel)
        {
            _finishGameLabel = finishGameLabel;
            _finishGameLabel.text = String.Empty;
        }

        public void GameOver()
        {
            _finishGameLabel.text = "Вы проиграли";
        }
    }
}

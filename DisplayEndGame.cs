using System;
using UnityEngine;
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

        public void GameOver(object o, CaughtPlayerEventArgs caughtPlayerEventArgs)
        {
            _finishGameLabel.text = $"Вы проиграли. Вас убил {((GameObject)o).name} {caughtPlayerEventArgs.Color} цвета";
        }
    }
}

using System;
using UnityEngine;
using UnityEngine.UI;


namespace Assets.MyScripts
{
    public sealed class DisplayWin
    {
        private Text _winGameText;

        public DisplayWin(GameObject winGame)
        {
            _winGameText = winGame.GetComponentInChildren<Text>();
            _winGameText.text = String.Empty;
        }

        public void GameWin()
        {
            _winGameText.text = $"Вы победили!";
        }
    }
}

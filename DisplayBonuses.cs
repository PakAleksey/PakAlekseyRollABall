using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.MyScripts
{
    public sealed class DisplayBonuses
    {
        private Text _bonuseLable;
        private Text _checkBonusLabel;

        public DisplayBonuses(GameObject bonus, GameObject checkBonus)
        {
            _bonuseLable = bonus.GetComponentInChildren<Text>();
            _bonuseLable.text = String.Empty;
            _checkBonusLabel = checkBonus.GetComponentInChildren<Text>();
            _checkBonusLabel.text = String.Empty;
        }

        public void Display(int bonus, int check)
        {
            _bonuseLable.text = $"Вы набрали {bonus} бонусов";
            _checkBonusLabel.text = $"Вы собрали {check} чекпоинтов";
        }
    }
}

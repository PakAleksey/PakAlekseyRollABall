using UnityEngine;
using UnityEngine.UI;


namespace Assets.MyScripts
{
    public sealed class DisplayBonuses
    {
        private Text _text;
        private static int _bonus;
        private static int _checkBonus;

        public DisplayBonuses()
        {
            _text = Object.FindObjectOfType<Text>();           
        }
        public void Display(int value, int value2)
        {                       
            _bonus += value;
            _checkBonus += value2;
            _text.text = $"Бонусы: {_bonus}, Чекпоинты: {_checkBonus}/5";                    
        }
    }
}

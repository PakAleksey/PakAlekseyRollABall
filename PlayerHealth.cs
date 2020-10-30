using System;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;


namespace Assets.MyScripts
{
    public sealed class PlayerHealth 
    {
        private Text _textHealth;
        private int _health;

        public PlayerHealth()
        {
            _health = 100;
            _textHealth = Object.FindObjectOfType<TextHealth>().GetComponent<Text>();
            _textHealth.text = $"Health = {_health}";
        }       

        public void Hurt(int damage)
        {
            _health -= damage;
            Debug.Log(_health);
            _textHealth.text = $"Health = {_health}";
            if (_health <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Debug.Log("Player Die((((((((");
        }
    }
}

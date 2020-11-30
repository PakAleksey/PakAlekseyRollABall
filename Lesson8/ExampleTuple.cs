using UnityEngine;

namespace Geekbrains
{
    public sealed class ExampleTuple
    {
        private sealed class Player
        {
            private int _maxHP;
            private int _currentHP;

            public Player()
            {
                _maxHP = 100;
                _currentHP = 42;
            }

            public void Deconstruct(out int currentHP, out int maxHP) =>
                (currentHP, maxHP) = (_currentHP, _maxHP);
        }

        public void Main()
        {
            Player player = new Player();
            (int currentHP, int maxHP) = player;
            
            Debug.Log($"{currentHP}/{maxHP}");
        }

        private (int roman, int valeriya) NameMethod()
        {
            (int, int) valueTuple = (6,7);

            return valueTuple;
        }
    }
}

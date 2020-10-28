using System;
using UnityEngine;


public class Example : MonoBehaviour
{
    private void Start()
    {
        User user1 = new User();
        user1[0] = new Vector3();
        return;
        var user = new User()
        {
            Name = "Vasya",
            Health = new Health()
            {
                MaxHealth = 100,
                CurrentHealth = 100
            }
        };

        User t = user.Clone() as User;
        t.Name = "Ivan";
        t.Health.CurrentHealth = 50;

        Debug.Log($"{user}");
        Debug.Log($"{t}");
    }

    public enum MyEnum
    {
        None = 0,
        First = 1,
        Second = 2
    }

    public class User : ICloneable
    {
        public string Name;
        public Health Health;
        private Vector3[] _points;

        public Vector3 this[int i]
        {
            get
            {
                return _points[i];
            }
            set
            {
                _points[i] = value;
            }
        }

        public string this[MyEnum value]
        {
            get
            {
                switch (value)
                {
                    case MyEnum.None:
                        return "None";
                    case MyEnum.First:
                        return "First";
                    case MyEnum.Second:
                        return "Second";
                    default:
                        return "";
                }
            }
        }

        public object Clone()
        {
            //return MemberwiseClone();
            return new User()
            {
                Name = Name,
                Health = new Health()
                {
                    MaxHealth = Health.MaxHealth,
                    CurrentHealth = Health.CurrentHealth
                }
            };
        }

        public override string ToString()
        {
            return $"Name {Name} Health {Health}";
        }

    }

    public class Health
    {
        public float MaxHealth;
        public float CurrentHealth;

        public override string ToString()
        {
            return $"Health {CurrentHealth}, MaxHealth {MaxHealth}";
        }
    }
}

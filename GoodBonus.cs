using System;
using UnityEngine;
using Random = UnityEngine.Random;


namespace Assets.MyScripts
{
    public class GoodBonus : InteractiveObject, IFly, IFlicker, IEquatable<GoodBonus>
    {
        public int Point;

        protected Material _material;
        private float _lengthFly;

        protected DisplayBonuses _displayBonuses;  

        protected override void Interaction(Player player)
        {
            _displayBonuses.Display(Point, 0);
            // Add bonus
        }

        private void Start()
        {
            _material = GetComponent<Renderer>().material;
            _lengthFly = Random.Range(1.0f, 5.0f);
            _displayBonuses = new DisplayBonuses();
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
                Mathf.PingPong(Time.time, 1.0f));
        }

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFly),
                transform.localPosition.z);
        }

        public bool Equals(GoodBonus other)
        {
            return Point == other.Point;
        }
    }
}

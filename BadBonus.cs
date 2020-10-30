using System;
using UnityEngine;
using Random = UnityEngine.Random;


namespace Assets.MyScripts
{
    public class BadBonus : InteractiveObject, IFly, IRotation, ICloneable
    {
        private float _lengthFlay;
        private float _speedRotation;
        private int _damage;

        private void Awake()
        {
            _damage = 10;
            _lengthFlay = Random.Range(1.0f, 5.0f);
            _speedRotation = Random.Range(10.0f, 50.0f);
        }

        protected override void Interaction(Player player)
        {
            var playerHealth = player._playerHealth;
            playerHealth.Hurt(_damage);
        }

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFlay),
                transform.localPosition.z);
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }

        public object Clone()
        {
            var result = Instantiate(gameObject, transform.position, transform.rotation, transform.parent);
            return result;
        }
    }
}

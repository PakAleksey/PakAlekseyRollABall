using System;
using UnityEngine;
using Random = UnityEngine.Random;


namespace Assets.MyScripts
{
    public class GoodBonus : InteractiveObject, IFly, IFlicker
    {
        public int Point;
        public event Action<int> OnPointChange = delegate (int i) { };
        private Material _material;
        private float _lengthFly;

        protected override void Interaction()
        {
            OnPointChange.Invoke(Point);
        }

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lengthFly = Random.Range(1.0f, 5.0f);
        }

        public override void Execute()
        {
            if (!IsInteractable) { return; }
            Fly();
            Flicker();
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

    }
}

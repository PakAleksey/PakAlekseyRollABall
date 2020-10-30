using System;
using UnityEngine;

namespace Assets.MyScripts
{
    public class Player : MonoBehaviour, IDisposable
    {
        public float Speed = 3.0f;
        private Rigidbody _rigidbody;
        public PlayerHealth _playerHealth;

        private void Start()
        {
            _playerHealth = new PlayerHealth();
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            Move(); 
        }

        protected void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            _rigidbody.AddForce(movement * Speed);
        }

        public void Dispose()
        {
            Destroy(gameObject);
        }
    }
}

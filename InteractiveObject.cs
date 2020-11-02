﻿using Random = UnityEngine.Random;
using UnityEngine;
using System;
using System.Collections;


namespace Assets.MyScripts
{
    public abstract class InteractiveObject : MonoBehaviour, IInteractable, IComparable<InteractiveObject>
    {
        protected Color _color;
        public bool IsInteractable { get; } = true;
        protected abstract void Interaction(Player player);

        private void OnTriggerEnter(Collider other)
        {
            if (!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }
            Interaction(other.GetComponent<Player>());
            Destroy(gameObject);
        }

        private void Start()
        {
            ((IAction)this).Action();
            //((IInitialization)this).Action();              
        }

        protected static void SpeedBonusPlayer(Player player)
        {
            player.Speed = 10.0f;
        }

        void IAction.Action()
        {
            _color = Random.ColorHSV();
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = _color;
            }
        }

        void IInitialization.Action()
        {
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = Color.cyan;
            }
        }

        public int CompareTo(InteractiveObject other)
        {
            return name.CompareTo(other.name);
        }

    }
}

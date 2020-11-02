using System;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;


namespace Assets.MyScripts
{
    public class GameController : MonoBehaviour, IDisposable
    {
        private ListInteractableObject _interactiveObject;
        public Text _finishGameLabel;
        private DisplayEndGame _displayEndGame;

        private void Awake()
        {
            _interactiveObject = new ListInteractableObject();
            _displayEndGame = new DisplayEndGame(_finishGameLabel);
            foreach(var o in _interactiveObject)
            {
                if(o is BadBonus badBonus)
                {
                    badBonus.CaughtPlayer += CaughtPlayer;
                    badBonus.CaughtPlayer += _displayEndGame.GameOver;
                }
             
            }
        }

        private void CaughtPlayer(object value, CaughtPlayerEventArgs caughtPlayerEventArgs)
        {
            Time.timeScale = 0.0f;
        }

        private void Update()
        {
            for (var i = 0; i < _interactiveObject.Count; i++)
            {
                var interactiveObject = _interactiveObject[i];

                if (interactiveObject == null)
                {
                    continue;
                }
                if (interactiveObject is IFly fly)
                {
                    fly.Fly();
                }
                if (interactiveObject is IFlicker flicker)
                {
                    flicker.Flicker();
                }
                if (interactiveObject is IRotation rotation)
                {
                    rotation.Rotation();
                }
            }
        }

        public void Dispose()
        {
            foreach (var o in _interactiveObject)
            {
                if(o is InteractiveObject interactiveObject)
                {
                    if(o is BadBonus badBonus)
                    {
                        badBonus.CaughtPlayer -= CaughtPlayer;
                        badBonus.CaughtPlayer -= _displayEndGame.GameOver;
                    }
                    Destroy(interactiveObject.gameObject);
                }               
            }
        }

    }
}


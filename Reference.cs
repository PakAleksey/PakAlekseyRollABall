﻿using UnityEngine;
using UnityEngine.UI;

namespace Assets.MyScripts
{
    public sealed class Reference
    {
        private PlayerBall _playerBall;
        private Camera _mainCamera;
        private GameObject _bonuse;
        private GameObject _endGame;
        private GameObject _winGame;
        private GameObject _checkBonus;
        private Canvas _canvas;
        private Button _restartButton;

        public Button RestartButton
        {
            get
            {
                if (_restartButton == null)
                {
                    var gameObject = Resources.Load<Button>("UI/RestartButton");
                    _restartButton = Object.Instantiate(gameObject, Canvas.transform);
                }

                return _restartButton;
            }
        }

        //....

        public PlayerBall PlayerBall
        {
            get
            {
                if (_playerBall == null)
                {
                    var gameObject = Resources.Load<PlayerBall>("MyPrefabs/PlayerBall");
                    _playerBall = Object.Instantiate(gameObject);
                }

                return _playerBall;
            }
        }

        public Canvas Canvas
        {
            get
            {
                if (_canvas == null)
                {
                    _canvas = Object.FindObjectOfType<Canvas>();
                }

                return _canvas;
            }
        }

        public GameObject Bonuse
        {
            get
            {
                if (_bonuse == null)
                {
                    var gameObject = Resources.Load<GameObject>("UI/Bonuse");
                    _bonuse = Object.Instantiate(gameObject, Canvas.transform);
                }

                return _bonuse;
            }
        }

        public GameObject CheckBonus
        {
            get
            {
                if (_checkBonus == null)
                {
                    var gameObject = Resources.Load<GameObject>("UI/CheckBonuse");
                    _checkBonus = Object.Instantiate(gameObject, Canvas.transform);
                }

                return _checkBonus;
            }
        }

        public GameObject WinGame
        {
            get
            {
                if (_winGame == null)
                {
                    var gameObject = Resources.Load<GameObject>("UI/WinGame");
                    _winGame = Object.Instantiate(gameObject, Canvas.transform);
                }

                return _winGame;
            }
        }

        public GameObject EndGame
        {
            get
            {
                if (_endGame == null)
                {
                    var gameObject = Resources.Load<GameObject>("UI/EndGame");
                    _endGame = Object.Instantiate(gameObject, Canvas.transform);
                }

                return _endGame;
            }
        }

        public Camera MainCamera
        {
            get
            {
                if (_mainCamera == null)
                {
                    _mainCamera = Camera.main;
                }
                return _mainCamera;
            }
        }
    }
}

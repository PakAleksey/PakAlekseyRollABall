using System;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Assets.MyScripts
{
    public class GameController : MonoBehaviour, IDisposable
    {
        public PlayerType PlayerType = PlayerType.Ball;
        private PlayerBase _player;
        private ListExecuteObject _interactiveObject;
        private CameraController _cameraController;
        private InputController _inputController;       
        private DisplayBonuses _displayBonuses;
        private DisplayEndGame _displayEndGame;
        private DisplayWin _displayWin;
        private int _countBonuses;
        private int _countCheckPoints;
        private Reference _reference;
        private int _highSpeed = 10;
        private int _BaseSpeed = 3;
        private int _lowSpeed = 1;
        private Timer _timer;


        private void Awake()
        {      
            _interactiveObject = new ListExecuteObject();
            
            _reference = new Reference();

            _player = null;

            if (PlayerType == PlayerType.Ball)
            {
                _player = _reference.PlayerBall;
            }
            
            _cameraController = new CameraController(_player.transform, _reference.MainCamera.transform);
            _interactiveObject.AddExecuteObject(_cameraController);

            if (Application.platform == RuntimePlatform.WindowsEditor)
            {
                _inputController = new InputController(_player);
                _interactiveObject.AddExecuteObject(_inputController);
            }

            _displayEndGame = new DisplayEndGame(_reference.EndGame);
            _displayBonuses = new DisplayBonuses(_reference.Bonuse, _reference.CheckBonus);
            _displayWin = new DisplayWin(_reference.WinGame);

            foreach (var o in _interactiveObject)
            {
                if (o is BadBonus badBonus)
                {
                    badBonus.OnCaughtPlayerChange += CaughtPlayer;
                    badBonus.OnCaughtPlayerChange += _displayEndGame.GameOver;
                }
                if (o is DebuffBonus deBuffBonus)
                {
                    deBuffBonus.DeBuffSpeed += BuffOrDebuffBonus;
                }
                if (o is GoodBonus goodBonus)
                {
                    goodBonus.OnPointChange += AddBonuse;
                }
                if (o is CheckBonus checkBonus)
                {
                    checkBonus.CheckPoint += CheckBonus_CheckPoint;
                }
                if (o is BuffBonus buffBonus)
                {
                    buffBonus.BuffSpeed += BuffOrDebuffBonus;
                }
            }

            _reference.RestartButton.onClick.AddListener(RestartGame);
            _reference.RestartButton.gameObject.SetActive(false);
            _timer = new Timer();
        }

        private void BuffOrDebuffBonus(bool IsGood)
        {
            _timer.IsStart = true;
            if (IsGood)
            {
                _player.Speed = _highSpeed;
            }
            else
            {
                _player.Speed = _lowSpeed;
            }           
            _timer.StopTimer += EndBuffOrDebuff;
        }

        public void EndBuffOrDebuff()
        {
            _player.Speed = _BaseSpeed;
            _timer.StopTimer -= EndBuffOrDebuff;
        }

        private void CheckBonus_CheckPoint()
        {
            _countCheckPoints++;
            _displayBonuses.Display(_countBonuses, _countCheckPoints);
            if (_countCheckPoints >= 5)
            {
                _displayWin.GameWin();
                _reference.RestartButton.gameObject.SetActive(true);
                Time.timeScale = 0.0f;
            }
        }

        private void RestartGame()
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);
            Time.timeScale = 1.0f;
        }

        private void CaughtPlayer(string value, Color args)
        {
            _reference.RestartButton.gameObject.SetActive(true);
            Time.timeScale = 0.0f;
        }

        private void AddBonuse(int value)
        {
            _countBonuses += value;
            _displayBonuses.Display(_countBonuses, _countCheckPoints);
        }

        private void Update()
        {
            for (var i = 0; i < _interactiveObject.Length; i++)
            {
                var interactiveObject = _interactiveObject[i];

                if (interactiveObject == null)
                {
                    continue;
                }
                interactiveObject.Execute();
            }
            _timer.TimerGo();
        }

        public void Dispose()
        {
            foreach (var o in _interactiveObject)
            {
                if (o is BadBonus badBonus)
                {
                    badBonus.OnCaughtPlayerChange -= CaughtPlayer;
                    badBonus.OnCaughtPlayerChange -= _displayEndGame.GameOver;
                }

                if (o is GoodBonus goodBonus)
                {
                    goodBonus.OnPointChange -= AddBonuse;
                }
            }
        }

    }
}


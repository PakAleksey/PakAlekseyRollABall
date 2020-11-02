using System;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;


namespace Assets.MyScripts
{
    public sealed class DisplayEndGame
    {
        private Text _finishGameLabel;

        public DisplayEndGame(Text finishGameLabel)
        {
            _finishGameLabel = finishGameLabel;
            _finishGameLabel.text = String.Empty;
        }

        public void GameOver(object o, CaughtPlayerEventArgs caughtPlayerEventArgs)
        {
            try
            {
                _finishGameLabel.text = $"Вы проиграли. Вас убил {((InteractiveObject)o).name} {caughtPlayerEventArgs.Color} цвета";
            }            
            catch (InvalidCastException ex)
            {
                Debug.Log(ex.Message);
            }
            catch (Exception ex)
            {
                Debug.Log(ex.Message);
            }
            finally
            {
                Debug.Log(typeof(BadBonus).ToString());
            }
        }
    }
}

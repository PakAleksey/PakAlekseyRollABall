using System.Collections.Generic;
using UnityEngine;


namespace Assets.MyScripts
{
    public sealed class SaveController
    {
        public List<object> _saveDataList;
        public SaveController()
        {
            _saveDataList = new List<object>();
        }

        public SaveController(PlayerBase player)
        {
            _saveDataList = new List<object>();
            _saveDataList.Add(player);
        }
    }
}

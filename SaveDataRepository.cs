using Assets.MyScripts.Savers;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


namespace Assets.MyScripts
{
    public sealed class SaveDataRepository
    {
        private readonly IData<SavedData> _data;

        private const string _folderName = "dataSave";
        private const string _fileName = "data.bat";
        private readonly string _path;

        public SaveDataRepository()
        {
            if (Application.platform == RuntimePlatform.WebGLPlayer)
            {
                _data = new PlayerPrefsData();
            }
            else
            {
                _data = new JsonData<SavedData>();
            }
            _path = Path.Combine(Application.dataPath, _folderName);

        }

        public void Save(PlayerBase player)
        {
            if (!Directory.Exists(Path.Combine(_path)))
            {
                Directory.CreateDirectory(_path);
            }
            var savePlayer = new SavedData
            {
                Position = player.transform.position,
                Name = "Roman",
                IsEnabled = true
            };

            _data.Save(savePlayer, Path.Combine(_path, _fileName));
        }

        public void Load(PlayerBase player)
        {
            var file = Path.Combine(_path, _fileName);
            if (!File.Exists(file)) return;
            var newPlayer = _data.Load(file);
            player.transform.position = newPlayer.Position;
            player.name = newPlayer.Name;
            player.gameObject.SetActive(newPlayer.IsEnabled);

            Debug.Log(newPlayer);
        }

        public void SaveAll(List<object> listObjects)
        {
            if (!Directory.Exists(Path.Combine(_path)))
            {
                Directory.CreateDirectory(_path);
            }
            var saveAllObjects = new List<SavedData>();
            foreach(var item in listObjects)
            {
                if(item is GoodBonus goodBonus)
                {
                    var saveGoodBonus = new SavedData()
                    {
                        Position = goodBonus.transform.position,
                        Name = goodBonus.name,
                        IsEnabled = goodBonus.IsInteractable,
                        TypeObject = TypeObject.GoodBonus
                    };
                    saveAllObjects.Add(saveGoodBonus);
                }
                if (item is BadBonus badBonus)
                {
                    var saveBadBonus = new SavedData()
                    {
                        Position = badBonus.transform.position,
                        Name = badBonus.name,
                        IsEnabled = badBonus.IsInteractable,
                        TypeObject = TypeObject.BadBonus
                    };
                    saveAllObjects.Add(saveBadBonus);
                }
                if (item is PlayerBase player)
                {
                    var savePlayer = new SavedData()
                    {
                        Position = player.transform.position,
                        Name = "PakAleksey",
                        IsEnabled = true,
                        TypeObject = TypeObject.Player
                    };
                    saveAllObjects.Add(savePlayer);
                }
            }
            _data.SaveList(saveAllObjects, Path.Combine(_path, _fileName));
        }

        public void LoadAll(List<object> listObjects)
        {           
            var file = Path.Combine(_path, _fileName);
            if (!File.Exists(file))
            {
                Debug.Log($"File not found - {file}");
                return;
            }

            var listSaveData = _data.LoadList(file);

            foreach (var item in listSaveData)
            {
                Debug.Log(item);
            }


            for (int i = 0; i < listSaveData.Count; i++)
            {
                SavedData item = listSaveData[i];
                if (listObjects[i] is PlayerBall playerBase && item.TypeObject == TypeObject.Player)
                {
                    playerBase.transform.position = item.Position;
                    playerBase.name = item.Name;
                    item.IsEnabled = true;
                }
                if (listObjects[i] is GoodBonus goodBonus && item.TypeObject == TypeObject.GoodBonus)
                {
                    goodBonus.transform.position = item.Position;
                    goodBonus.name = item.Name;
                    goodBonus.IsInteractable = item.IsEnabled;
                }
                if (listObjects[i] is BadBonus badBonus && item.TypeObject == TypeObject.BadBonus)
                {
                    badBonus.transform.position = item.Position;
                    badBonus.name = item.Name;
                    badBonus.IsInteractable = item.IsEnabled;
                }
            }
        }
    }
}

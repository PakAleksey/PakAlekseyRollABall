using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using UnityEngine;


namespace Assets.MyScripts.Savers
{
    public sealed class JsonData<T> : IData<T>
    {
        public void Save(T data, string path = null)
        {
            var str = JsonUtility.ToJson(data);
            File.WriteAllText(path, Crypto.CryptoXOR(str));
            // File.WriteAllText(path, str);
        }

        public T Load(string path = null)
        {
            var str = File.ReadAllText(path);
            return JsonUtility.FromJson<T>(Crypto.CryptoXOR(str));
            // return JsonUtility.FromJson<T>(str);
        }

        public void SaveList(List<T> SaveAll, string path)
        {
            var jsonSerializer = new DataContractJsonSerializer(typeof(T));
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                jsonSerializer.WriteObject(fileStream, SaveAll);
            }
        }

        public List<T> LoadList(string path = null)
        {
            var jsonSerializer = new DataContractJsonSerializer(typeof(T));
            using (var fileStream = new FileStream(path, FileMode.Open))
            {
                var newList = jsonSerializer.ReadObject(fileStream) as List<T>;
                return newList;
            }
        }      
    }
}

﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Assets.MyScripts.Savers
{
    public sealed class BinarySerializationData<T> : IData<T>
    {
        private static BinaryFormatter _formatter;

        public BinarySerializationData()
        {
            _formatter = new BinaryFormatter();
        }

        public void Save(T data, string path = null)
        {
            if (data == null && !String.IsNullOrEmpty(path))
            {
                throw new ArgumentException("");
            };
            if (!typeof(T).IsSerializable)
            {
                throw new InvalidOperationException("NotSerialized");
            }
            using (var fs = new FileStream(path, FileMode.Create))
            {
                _formatter.Serialize(fs, data);
            }
        }

        public T Load(string path)
        {
            T result;
            if (!File.Exists(path)) return default(T);
            using (var fs = new FileStream(path, FileMode.Open))
            {
                result = (T)_formatter.Deserialize(fs);
            }
            return result;
        }

        public void SaveList(List<T> SaveAll, string path)
        {
            throw new NotImplementedException();
        }

        public List<T> LoadList(string path = null)
        {
            throw new NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using System.IO;
using Assets.MyScripts.Test;


namespace Assets.MyScripts.Savers
{
    public sealed class StreamData : IData<SavedData>
    {
        public void Save(SavedData data, string path = null)
        {
            if (path == null) return;
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(data.Name);
                sw.WriteLine(data.Position.X);
                sw.WriteLine(data.Position.Y);
                sw.WriteLine(data.Position.Z);
                sw.WriteLine(data.IsEnabled);
            }
        }

        public SavedData Load(string path = null)
        {
            var result = new SavedData();

            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    result.Name = sr.ReadLine();
                    result.Position.X = sr.ReadLine().TrySingle();
                    result.Position.Y = sr.ReadLine().TrySingle();
                    result.Position.Z = sr.ReadLine().TrySingle();
                    result.IsEnabled = sr.ReadLine().TryBool();
                }
            }
            return result;
        }

        public void SaveList(List<SavedData> SaveAll, string path)
        {
            throw new System.NotImplementedException();
        }

        public List<SavedData> LoadList(string path = null)
        {
            throw new System.NotImplementedException();
        }
    }
}

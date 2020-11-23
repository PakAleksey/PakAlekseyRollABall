using System.Collections.Generic;

namespace Assets.MyScripts
{
    public interface IData<T>
    {
        void Save(T data, string path = null);
        T Load(string path = null);

        void SaveList(List<T> SaveAll, string path);

        List<T> LoadList(string path = null);
    }
}

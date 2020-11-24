using UnityEngine;
using UnityEngine.SceneManagement;


namespace Assets.MyScripts
{
    public class TestTow : MonoBehaviour
    {
        public int T;

        private void Start()
        {
            SceneManager.sceneLoaded += SceneManagerOnsceneLoaded;
        }

        private void SceneManagerOnsceneLoaded(Scene arg0, LoadSceneMode arg1)
        {

        }
    }
}

using UnityEngine;
using UnityEngine.UI;

namespace Assets.MyScripts.Test
{
    public class CreateButton : MonoBehaviour
    {
        [SerializeField] private Button _button;

        private void Start()
        {
            var root = FindObjectOfType<VerticalLayoutGroup>().transform;
            for (int i = 0; i < 100; i++)
            {
                var instantiate = Instantiate(_button, root);
                instantiate.GetComponentInChildren<Text>().text = i.ToString();
                instantiate.onClick.AddListener(() => Debug.Log(i));
            }
        }
    }
}

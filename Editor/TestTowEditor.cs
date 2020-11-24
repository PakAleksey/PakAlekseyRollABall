using UnityEditor;


namespace Assets.MyScripts
{
    [CustomEditor(typeof(TestTow))]
    public class TestTowEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            var t = (TestTow)target;
            t.T = EditorGUILayout.IntSlider(t.T, 0, 100);
        }
    }
}

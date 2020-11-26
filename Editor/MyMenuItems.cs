using UnityEditor;

namespace Assets.MyScripts
{    
    public sealed class MyMenuItems
    {
        [MenuItem("PakAlekseyMenu/MyFirstWindow")]
        public static void MyMenu()
        {
            EditorWindow.GetWindow(typeof(MyWindowLesson7HW), true, "PakAlekseyWindow");
        }
    }
}

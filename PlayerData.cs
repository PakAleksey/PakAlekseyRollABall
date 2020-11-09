using UnityEngine;


namespace Assets.MyScripts
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Player")]
    public sealed class PlayerData : ScriptableObject
    {
        public int Speed;
    }
}

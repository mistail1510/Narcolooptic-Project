using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "Level_SO", menuName = "Scriptable Objects/Level")]
    public class LevelData : ScriptableObject
    {
        [SerializeField] public GameObject LevelPrefab;
        [SerializeField] public bool IsCompleted;
        [SerializeField] public LevelData NextLevel;
    }
}

using System.Collections.Generic;
using Data;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "Scriptable Objects/GameData")]
public class GameData : ScriptableObject
{
    [SerializeField] public List<ObjectData> inventory = new List<ObjectData>();
    public delegate void LevelEvent();
    public LevelEvent OnLevelLaunch;
    public LevelEvent OnLevelEnded;
}

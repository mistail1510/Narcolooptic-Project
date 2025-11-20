using Data;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private LevelData _levelData;
    [SerializeField] private ObjectData _checkpointKey;
    [SerializeField] private GameObject _checkpointUI;

    public bool canLaunchNextLevel;
    
    private void Awake()
    {
        canLaunchNextLevel = false; 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        foreach(var obj in _gameData.inventory)
        { 
            if (obj.isKey == true) 
            { 
                canLaunchNextLevel = true;
            }
        }
        if (collision.CompareTag("Player"))
        {
            _checkpointUI.SetActive(true); 
           
            if (canLaunchNextLevel)
            {
                ValidateCheckpoint();
            }
            else
            {
                CheckPointUncomplete();
            }
        }
    }

    private void ValidateCheckpoint()
    {
        _levelData.IsCompleted = true; 
        _gameData.OnLevelLaunch?.Invoke(); 
        canLaunchNextLevel = false;
    }

    private void CheckPointUncomplete()
    {  
        _levelData.IsCompleted = false; 
        _gameData.OnLevelEnded?.Invoke();
        canLaunchNextLevel = false;
    }
    
}

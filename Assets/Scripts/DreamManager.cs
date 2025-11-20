using Data;
using UnityEngine;
using UnityEngine.UI;

public class DreamManager : MonoBehaviour
{  
    [SerializeField] public GameObject CurrentLevel;
    [SerializeField] private GameData _gameData;
    [SerializeField] private LevelData _levelData;
    [SerializeField] private GameObject _awakeCanvas;
    Animator _animator;
    
    void Awake()
    {
        _gameData.inventory.Clear();
        _gameData.OnLevelLaunch += LaunchNextLevel;
        _gameData.OnLevelEnded += EndDream;
    }

    private void OnDestroy()
    {
        _gameData.OnLevelLaunch -= LaunchNextLevel;
        _gameData.OnLevelEnded -= EndDream;
    }

    public void LaunchNextLevel()
    {
        HideAwakeCanvas();
        if (_levelData.NextLevel != null)
        {
            Destroy(CurrentLevel.gameObject);
            if (_awakeCanvas.activeInHierarchy == false)
            {
                CurrentLevel = Instantiate(_levelData.NextLevel.LevelPrefab, transform);
            }
        }
    }

    public void EndDream()
    {
        _gameData.inventory.Clear();
        Destroy(CurrentLevel.gameObject);
    }

    public void HideAwakeCanvas()
    {
        //if (_awakeCanvas.activeInHierarchy == true)
        //{
        //    _awakeCanvas.transform.GetChild(0).GetComponentInChildren<Image>().CrossFadeAlpha(0, 1, true);
        //    if(_awakeCanvas.transform.GetChild(0).GetComponentInChildren<Image>().color.a == 0
        //    {
                _awakeCanvas.SetActive(false);
        //    }
        //}
    }
}


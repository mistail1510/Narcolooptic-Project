using Data;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine.Audio;

public class ObjectsManager : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private ObjectData _objectData;


    private AudioSource audioPickupSource;
    public void AddObjectToInventory()
    {    
        _gameData.inventory.Add(_objectData); 
        
    }
    public void Start()
    {
        audioPickupSource = GetComponents<AudioSource>()[0];
    }
    
    public void Grab()
    {

        if (_gameData.inventory.Count + 1 == 3)
        {
            AddObjectToInventory();
            _gameData.OnLevelLaunch?.Invoke();
        }
        else
        {
            AddObjectToInventory();
        }

        GetComponent<Image>().CrossFadeAlpha(0, 1, true);
        AudioClip clip = null;
        clip = _objectData.AudioPickup;
        audioPickupSource.clip = clip;
        audioPickupSource.Play();
    }
}
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    
    private AudioSource _audioSource;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        _audioSource = GetComponent<AudioSource>();
        
    }

    
    void LightOn()
    {
        AudioClip clip = null;
        clip = _clip;
        _audioSource.clip = clip;
        _audioSource.Play();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

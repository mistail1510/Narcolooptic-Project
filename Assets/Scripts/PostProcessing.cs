using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessing : MonoBehaviour
{
    [SerializeField] public GameObject _cam;
    private DepthOfField _depthOfField;
    private float _startTime;
    float duration = 3.0f;

    private PostProcessVolume _ppVolume;
    private float t;
    private bool _blur = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _ppVolume = _cam.GetComponent<PostProcessVolume>();
        _startTime = Time.deltaTime;
        _ppVolume.profile.TryGetSettings(out _depthOfField);
    }

    void Blur()
    {
        _blur = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (_blur == true)
        {
            t = (Time.time - _startTime) / duration;
            _depthOfField.focusDistance.value = Mathf.SmoothStep( 4, 0.1f,t);     
        }
    }
}

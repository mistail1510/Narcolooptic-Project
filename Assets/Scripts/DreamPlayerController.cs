using System;
using UnityEngine;

public class DreamPlayerController : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody2D _playerRb;
    private float _horizontalInput;
    [SerializeField] float _speed;

    private void Awake()
    {
        _playerRb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        _horizontalInput = Input.GetAxisRaw(("Horizontal"));
        float horizontalMovement = _horizontalInput * _speed * Time.deltaTime;
        _playerRb.linearVelocity = new Vector2(horizontalMovement, _playerRb.linearVelocity.y);
        _animator.SetFloat("Velocity", Math.Abs(_playerRb.linearVelocityX));
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{

    private Rigidbody2D _rigidBody2D;

    private Vector2 _moveInput;

    [SerializeField] private float _playerVelocity = 5f;
    [SerializeField] private float _jumpHeight = 2.5f;

    private InputAction _moveAction;
    private InputAction _jumpAction;   
    

    void Awake()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();

        _moveAction = InputSystem.actions["Move"];
        _jumpAction = InputSystem.actions["Jump"];

    }

    void Update()
    {

        _moveInput = _moveAction.ReadValue<Vector2>();

        _rigidBody2D.linearVelocity = new Vector2(_moveInput.x * _playerVelocity,  _rigidBody2D.linearVelocity.y );

    }


 
  
}

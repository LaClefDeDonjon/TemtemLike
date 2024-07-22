using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{


    [SerializeField] private Temtem[] _temtem = new Temtem[6];
    private Vector2 _direction;
    private Vector3 _velocity = Vector3.zero;
    [SerializeField] private float _speedMove = 1f;
    [SerializeField] private float _speedRotate = 1f;
    [SerializeField] private CharacterController _characterController;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 movement = _characterController.transform.forward * _direction.y * _speedMove * Time.deltaTime;
        movement.y = _velocity.y;

        _characterController.Move(movement);
        _characterController.transform.Rotate(Vector3.up * _direction.x * _speedRotate * Time.deltaTime);


    }

    public void Move(InputAction.CallbackContext Context)
    {
        _direction = Context.ReadValue<Vector2>();
    }


    public Temtem[] GetTemtemSquad()
    {
        return _temtem;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class UserInput : MonoBehaviour
{
     public Movement mov;

     [SerializeField] private InputManager control;

     private float playeraxisX;
     private float playeraxisY;
     public static UserInput input_manager { get; set; }
    
    Invoker _invoker;

    private void Awake()
    {
        input_manager = this;

        //Set Invoker
        _invoker = new Invoker();

        //Set InputController
        control = new InputManager();

        control.Player.Move.performed += _ => Move(_.ReadValue<Vector2>());
        control.Player.Jump.performed += _ => Jump();
        control.Player.Move.canceled += _ => CancelMove();
    }

    void Move(Vector2 direction)
    {
        playeraxisX = direction.x;
        playeraxisY = direction.y;

        ICommand walk_command = new WalkCommand(mov);
        _invoker.AddCommand(walk_command);

    }

    void CancelMove()
    {
        playeraxisX = 0;
        playeraxisY = 0;
    }

    void Jump()
    {
        ICommand jump_command = new JumpCommand(mov);
        _invoker.AddCommand(jump_command);

    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _invoker.UndoCommand();
        }
    }

    private void OnEnable() => control.Enable();

    private void OnDisable() => control.Disable();


    public float GetMovementX()
    {
        return playeraxisX;
    }

    public float GetMovementY()
    {
        return playeraxisY;
    }
}

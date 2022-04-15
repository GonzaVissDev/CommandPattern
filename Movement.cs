using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D Rb2d;
    [SerializeField] private float Speed;
    [SerializeField] private float movementX = 0;
    [SerializeField] private float movementY = 0;
  


    private void Start()
    {
        Rb2d = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        movementX = UserInput.input_manager.GetMovementX();
        movementY = UserInput.input_manager.GetMovementY();
       

    }

    public void Walk()
    {
        Debug.Log("Camino");
    }

    public void StepBack()
    {
        Debug.Log("Camino hacia atras");
    }

    public void Jump()
    {
        Debug.Log("Hago un salto increible");
    }
}

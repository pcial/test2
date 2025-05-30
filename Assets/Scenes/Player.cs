using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Player : MonoBehaviour
{
    public float Speed = 5f;
    public float Jomp = 5f;
    private Rigidbody rb;
    private int isGrounded;


    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {

        Move();
        jump();
    }
    void Move()
    {
        rb h = Input.GetAxisRaw("Hor"){
            
        }
    }
    void jump()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& isGrounded)
        {
            
        }


    }
}

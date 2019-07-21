using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    
    private Rigidbody2D myRb;
    
    private Vector2 MoveVelocity;

    
    


    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {


        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        MoveVelocity = moveInput.normalized * moveSpeed;

    }

    private void FixedUpdate()
    {
        myRb.MovePosition(myRb.position + MoveVelocity * Time.fixedDeltaTime);

        
    }

   
}

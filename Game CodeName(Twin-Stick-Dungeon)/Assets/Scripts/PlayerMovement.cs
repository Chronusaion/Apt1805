using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float moveRotacion;
    private Rigidbody2D myRb;
    
    private Vector2 MoveVelocity;

    public float offSetRotacion;
    


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


        /*Vector3 diferencial = Camera.main.ScreenToViewportPoint(Input.mousePosition) - transform.position;
        float rotacionZ = Mathf.Atan2(diferencial.y, diferencial.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotacionZ + offSetRotacion);*/



    }

    private void FixedUpdate()
    {
        myRb.MovePosition(myRb.position + MoveVelocity * Time.fixedDeltaTime);

        
    }

   
}

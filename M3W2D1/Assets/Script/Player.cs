using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerNumber;
    public float speed;
    public float jump;
    
    private Rigidbody2D rb;
    private Vector2 movement;

  
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("P"+ playerNumber +"Horizontal");
        
        if ( Input.GetButtonDown("P"+ playerNumber +"Jump"))
        {
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }
        
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
    }
}

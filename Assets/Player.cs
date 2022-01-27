using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //Basic movement
        rb.MovePosition(rb.position + new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")).normalized * speed/10);
        
        //Player kigger retningen de bevæger sig
        transform.localScale = new Vector3(Input.GetAxisRaw("Horizontal") != 0 ? Input.GetAxisRaw("Horizontal") : transform.localScale.x, 1, 1);
    }
}

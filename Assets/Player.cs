using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    [Space]
    public Item Holding = Item.None;

    //Items Player kan holde
    public enum Item
    {
        None, Beer, Food
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //Brug denne funktion til movement
    private void FixedUpdate()
    {
        //Basic movement
        rb.MovePosition(rb.position + new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")).normalized * speed/10);
        
        //Player kigger retningen de bevæger sig
        transform.localScale = new Vector3(Input.GetAxisRaw("Horizontal") != 0 ? Input.GetAxisRaw("Horizontal") : transform.localScale.x, 1, 1);
    }

    //Brug denne til alt andet
    private void Update()
    {
        
    }
}

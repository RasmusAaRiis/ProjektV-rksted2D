using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinBehaviour : MonoBehaviour
{
    private Transform food;
    [SerializeField] private float speed;
    public GameObject Food;
    Animator anim;
    float movement;
    private bool left, right;

    // Start is called before the first frame update
    void Start()
    {
        right = true;
        Food = GameObject.Find("Beef");
        food = Food.transform;
        anim = GetComponent<Animator>();
        anim.SetBool("walking", true);
        TurnLeft();
    }

    // Update is called once per frame
    void Update()
    {
        FollowFood();
        float movement = 1; //skal være lig med goblins horizontale bevægelse
        Debug.Log(movement);
        if (movement < 0)
        { 
            TurnLeft();
        }
        else if (movement > 0)
        {        
            TurnRight();
        }
            
       
    }
    public void FollowFood()
    {
        transform.position = Vector3.MoveTowards(transform.position, food.position, speed * Time.deltaTime);
        
    }
    public void TurnLeft()
    {
        if (left)
            return;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        left = true;
        right = false;
    }
    public void TurnRight()
    {
        if (right)
            return;
        transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        left = false;
        right = true;
    }
}

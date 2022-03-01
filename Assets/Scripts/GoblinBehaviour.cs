using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinBehaviour : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float speed;
    public GameObject Food;
    Animator anim;
    private SpriteRenderer goblinSprite;
    public GameObject Exit;

    

    // Start is called before the first frame update
    void Start()
    {
        
        Food = GameObject.Find("Beef");
        target = Food.transform;
        anim = GetComponent<Animator>();
        goblinSprite = GetComponent<SpriteRenderer>();
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowFood();
        Rotate(target.position.x, transform.position.x);


    }
    public void FollowFood()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        
    }


    void Rotate(float targetX, float goblinX)
    {
        if (goblinX >= targetX)
        {
            goblinSprite.flipX = true;
        }
        else
        {
            goblinSprite.flipX = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject == Food)
        {
        
        Destroy(Food);
            target = Exit.transform; 

        }

        if (collision.gameObject == Exit)
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinBehaviour : MonoBehaviour
{
    private Transform food;
    [SerializeField] private float speed;
    public GameObject Chocolate;

    // Start is called before the first frame update
    void Start()
    {
        Chocolate = GameObject.Find("Chocolate");
        food = Chocolate.transform;
    }

    // Update is called once per frame
    void Update()
    {
        FollowFood();
    }
    public void FollowFood()
    {
        transform.position = Vector3.MoveTowards(transform.position, food.position, speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    private bool movedown = true;
    
    public float velocity = 2f;
    public Transform pointA;
    public Transform pointB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (transform.position.y > pointA.position.y)
    {
        movedown = true;
    }
    if (transform.position.y < pointB.position.y)
    {
        movedown = false;
    }
    if (movedown)
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - velocity * Time.deltaTime);
    }else{
        transform.position = new Vector2(transform.position.x, transform.position.y + velocity * Time.deltaTime);      
    }
    }

}

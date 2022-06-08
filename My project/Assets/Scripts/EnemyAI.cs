using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed;
    public float distance;
    
    bool isright = true;
    
    public Transform isground;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D ground = Physics2D.Raycast(isground.position, Vector2.down, distance);

        if(ground.collider == false)
        {
            if(isright == true)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                isright = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                isright = true;
            }
        }
    } 

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Verificadores de colisores")]
    public Rigidbody2D body;
    public Transform footposition;
    public float checkradius;
    public LayerMask layerground;
    private bool isground;

    [Header("Biblioteca da animação")]
    public Animator animator;
    
    [Header("Parametros do player")]
    public float speed, jumpforce;
    private float direction;
    private bool rightlook = true;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        CheckSurroundingds();
        Flip();
        SetAnim();
        Move();
        Jump();
    }

    void CheckSurroundingds()
    {
        // Verificando se os pés estão no chão 
        isground = Physics2D.OverlapCircle(footposition.position , 0.3f, layerground);
    }

     void SetAnim()
    {
        // Verificações das animações
        animator.SetBool("isground", isground);
        animator.SetFloat("speed_y", body.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(direction));
    }
    
    void Flip()
    {
        // Mudando a direção do personagem
        if((direction < 0 && rightlook) || (direction > 0 && !rightlook))   
        {
            rightlook = !rightlook;
            transform.Rotate(0f, 180f, 0f);
        }    
    }
 

    void Move() 
    {
        // Checando os comandos do teclado (direita e esquerda)
        direction = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(direction * speed, body.velocity.y); 
    }

    void Jump()
    {
        // Verificando se está no chão
        if(isground && Input.GetKeyDown(KeyCode.Space))
        {
            body.velocity = Vector2.up * jumpforce;
        }       
    }
}


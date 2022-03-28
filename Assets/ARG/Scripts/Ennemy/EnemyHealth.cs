using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{    
    public int life = 10;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("PlayerBullet"))
        {
            life = life - 1;
        }
        
    }

    private void FixedUpdate()
    {
        if (life <= 0)
        {
            Dying();
        }

    }
   
    private void Dying()
    {
        
        animator.SetBool("IsDead", true);
        
        GetComponent<Collider2D>().enabled = false;
        Destroy(gameObject, 1.1f);

    }
}

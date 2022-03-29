using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public int life = 10;
    

    private void Awake()
    {
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("PlayerBullet"))
        {
            life = life - 1;
            //deadSound[0].Play();
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


        GetComponent<Collider2D>().enabled = false;
        Destroy(gameObject, 1.1f);

    }
}
